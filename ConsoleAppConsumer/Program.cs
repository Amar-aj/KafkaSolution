// See https://aka.ms/new-console-template for more information
using ConsoleAppConsumer;

Console.WriteLine("Hello, Consumer!");


GetMessage message=new GetMessage();
message.ReadMessage();
Console.WriteLine(message.ToString());
