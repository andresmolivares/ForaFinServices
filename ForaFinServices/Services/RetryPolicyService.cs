using Polly.Retry;
using Polly;
using System.Net;
using ForaFinServices.Settings;
using ForaFinServices.Services.Interfaces;

namespace ForaFinServices.Services
{
    public class RetryPolicyService : IRetryPolicyService
    {
        public readonly RetryPolicySettings _retryPolicySettings;
        private readonly ILogger<RetryPolicyService> _logger;
        private readonly AsyncRetryPolicy<HttpResponseMessage> _policy;

        public RetryPolicyService(RetryPolicySettings retryPolicySettings, ILogger<RetryPolicyService> logger) 
        {
            _retryPolicySettings = retryPolicySettings;
            _logger = logger;
            _policy = CreateRetryPolicy();
        }

        public async Task<HttpResponseMessage> GetWithPolicy(Func<Task<HttpResponseMessage>> executeRequest)
        {
            return await _policy.ExecuteAsync(async () =>
            {
                // Call external service with retry policy
                return await ExecuteWithPolicy(executeRequest);
            });
        }

        private AsyncRetryPolicy<HttpResponseMessage> CreateRetryPolicy()
        {
            return Policy
                // Handle 429 responses
                .HandleResult<HttpResponseMessage>(r => r.StatusCode == HttpStatusCode.TooManyRequests)
                // Handle exceptions if needed
                .Or<HttpRequestException>(ex => ex.StatusCode == HttpStatusCode.TooManyRequests)
                .WaitAndRetryAsync(
                    retryCount: _retryPolicySettings.RetryCount, // Max number of retries
                    sleepDurationProvider: (retryAttempt, response, context) =>
                    {
                        if(response?.Result?.Headers?.RetryAfter?.Delta != null)
                        {
                            // Respect Retry-After header if provided
                            return response.Result.Headers.RetryAfter.Delta.Value;
                        }

                        // Default to exponential backoff if Retry-After is not provided
                        return TimeSpan.FromSeconds(Math.Pow(2, retryAttempt));
                    },
                    onRetryAsync: async (response, timespan, retryAttempt, context) =>
                    {
                        // Log retry information
                        Console.WriteLine($"Retry {retryAttempt} after {timespan.TotalSeconds}s due to {response?.Result?.StatusCode ?? HttpStatusCode.TooManyRequests}");

                        await Task.CompletedTask;
                    }
                );
        }

        private async Task<HttpResponseMessage> ExecuteWithPolicy(Func<Task<HttpResponseMessage>> executeRequest)
        {
            while(true)
            {
                var response = await executeRequest();

                switch(response.StatusCode)
                {
                    case HttpStatusCode.TooManyRequests:
                        if(response.Headers.RetryAfter?.Delta != null)
                        {
                            var retryAfter = response.Headers.RetryAfter.Delta.Value;
                            _logger.LogError($"Too many requests. Retrying after {retryAfter.TotalSeconds} seconds...");
                            await Task.Delay(retryAfter);
                        }
                        else
                        {
                            // Default backoff if Retry-After header is not provided
                            await Task.Delay(TimeSpan.FromSeconds(_retryPolicySettings.RetryAfterSeconds));
                        }
                        break;
                    default:
                        return response.EnsureSuccessStatusCode();
                }
            }
        }
    }
}
