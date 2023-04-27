using System;
using AppInAction.DI.MultipleImplementation.Interfaces;

namespace AppInAction.DI.MultipleImplementation.Services
{
    public class FacebookSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending Facebook message: {message}");
        }
    }
}