﻿namespace Ifolor.ConsumerService.Infrastructure.Messaging
{   
    /// <summary>
    /// Setting for RabbitMQ 
    /// </summary>
    public class RabbitMQConfig
    {
        public string HostName { get; set; } = "localhost";
        public string QueueName { get; set; } = "sendordata";
        public string Username { get; set; } = "guest";
        public string Password { get; set; } = "guest";
    }
}
