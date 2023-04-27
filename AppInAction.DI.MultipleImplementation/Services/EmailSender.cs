using System;
using AppInAction.DI.MultipleImplementation.Interfaces;

namespace AppInAction.DI.MultipleImplementation.Services
{
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending Email message: {message}");
        }
    }
}