using System;
using AppInAction.DI.Interfaces;
using AppInAction.DI.Models;

namespace AppInAction.DI.Services.EmailServices
{
    public class EmailSender : IEmailSender
    {
        private readonly NetworkClient _client;
        private readonly MessageFactory _factory;

        public EmailSender(MessageFactory factory, NetworkClient client)
        {
            _client = client;
            _factory = factory;
        }
        
        public void SendEmail(string username)
        {
            var email = _factory.Create(username);
            _client.SendEmail(email);
            Console.WriteLine($"Email send to {username}");
        }
    }
}