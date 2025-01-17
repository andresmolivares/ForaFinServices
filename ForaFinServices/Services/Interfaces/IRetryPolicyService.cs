namespace ForaFinServices.Services.Interfaces
{
    public interface IRetryPolicyService
    {
        Task<HttpResponseMessage> GetWithPolicy(Func<Task<HttpResponseMessage>> executeRequest);
    }
}
