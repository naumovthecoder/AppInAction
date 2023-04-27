using System;
using AppInAction.DI.MultipleImplementation.Interfaces;

namespace AppInAction.DI.MultipleImplementation.Services
{
    public class UnregisteredSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            throw new Exception("I'm never registered so shouldn't be called");
        }
    }
}