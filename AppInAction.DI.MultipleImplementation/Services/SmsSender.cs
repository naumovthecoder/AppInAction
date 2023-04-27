using System;
using AppInAction.DI.MultipleImplementation.Interfaces;

namespace AppInAction.DI.MultipleImplementation.Services
{
    public class SmsSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending SMS message: {message}");
        }
    }
}