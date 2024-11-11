// See https://aka.ms/new-console-template for more information
using ConsoleAppProducer;

Console.WriteLine("Hello, Producer!");

GenerateMessage produceMessage = new GenerateMessage();
produceMessage.CreateMessage().Wait();