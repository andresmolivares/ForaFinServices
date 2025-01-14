using ForaFinServices.Handlers;
using ForaFinServices.Handlers.Messages;
using System.Collections.Concurrent;

namespace ForaFinServices.Services
{
    public class QueueService : BackgroundService
    {
        private readonly ILogger<QueueService> _logger;
        private readonly BlockingCollection<IMessage> _queue = new();
        private readonly ConcurrentDictionary<Type, List<IMessageHandler>> _handlers = new();

        public QueueService(ILogger<QueueService> logger, IEnumerable<IMessageHandler> messageHandlers)
        {
            _logger = logger;
            // Register handlers for each supported message type
            foreach(var handler in messageHandlers)
            {
                foreach(var messageType in handler.GetSupportedMessageTypes())
                {
                    if(!_handlers.ContainsKey(messageType))
                    {
                        _handlers[messageType] = new List<IMessageHandler>();
                    }
                    _handlers[messageType].Add(handler);
                    _logger.LogDebug($"Registered handler for message type: {messageType.Name}");
                }
            }
        }

        /// <summary>
        /// Publish a message
        /// </summary>
        /// <param name="message"></param>
        public void PublishMessage(IMessage message)
        {
            _queue.Add(message);
            _logger.LogDebug($"Message published: {message.MessageType}");
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogDebug("QueueService is starting.");

            await Task.Run(async () =>
            {
                while(!stoppingToken.IsCancellationRequested)
                {
                    if(_queue.TryTake(out var message, TimeSpan.FromSeconds(1)))
                    {
                        var messageType = message.GetType();
                        _logger.LogDebug($"Processing message: {messageType.Name}");

                        if(_handlers.TryGetValue(messageType, out var handlers))
                        {
                            foreach(var handler in handlers)
                            {
                                try
                                {
                                    // Process a message
                                    await handler.HandleAsync(message);
                                }
                                catch(Exception ex)
                                {
                                    _logger.LogError(ex, $"Error while processing message: {messageType.Name}");
                                }
                            }
                        }
                        else
                        {
                            _logger.LogWarning($"No handlers found for message type: {messageType.Name}");
                        }
                    }
                }
            }, stoppingToken);

            _logger.LogDebug("QueueService is stopping.");
        }
    }
}

