using AppInAction.DI.MultipleImplementation.Interfaces;

namespace AppInAction.DI.MultipleImplementation.Services
{
    public class SingleMessageSender
    {
        private readonly IMessageSender _messageSender;

        public SingleMessageSender(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public void SendMessage(string message) => 
            _messageSender.SendMessage(message);
    }
}