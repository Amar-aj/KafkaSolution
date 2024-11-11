// See https://aka.ms/new-console-template for more information
using ConsoleAppProducer;

Console.WriteLine("Hello, World!");

ProduceMessage produceMessage = new ProduceMessage();
produceMessage.CreateMessage().Wait();