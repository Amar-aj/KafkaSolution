﻿using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProducer;

internal class GenerateMessage
{
    public async Task CreateMessage()
    {
        var config = new ProducerConfig
        {
            BootstrapServers = "localhost:9092",
            ClientId = "my-app",
            BrokerAddressFamily = BrokerAddressFamily.V4,
        };
        using var producer = new ProducerBuilder<Null, string>(config).Build();
        await producer.ProduceAsync("my-topic", new Message<Null, string> { Value = "Welcome" });
        Console.WriteLine("Please enter the message you want to send");
        var input = Console.ReadLine();
        var message = new Message<Null, string>
        {
            Value = input
        };
        var deliveryReport = await producer.ProduceAsync("my-topic", message);
        Console.WriteLine($"Message delivered to {deliveryReport.TopicPartitionOffset}");
    }
}
