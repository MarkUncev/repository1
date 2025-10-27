using System;

namespace NotificationApp
{
    public class Notification
    {
        // События (делегаты) для уведомлений
        public event Action<string> OnMessageSent;   // Для отправки сообщения
        public event Action<string> OnCallMade;      // Для звонка
        public event Action<string> OnEmailSent;     // Для email

        // Метод отправки сообщения — вызывает событие
        public void SendMessage(string message)
        {
            OnMessageSent?.Invoke(message);
        }

        // Метод совершения звонка — вызывает событие
        public void MakeCall(string phoneNumber)
        {
            OnCallMade?.Invoke(phoneNumber);
        }

        // Метод отправки email — вызывает событие
        public void SendEmail(string email)
        {
            OnEmailSent?.Invoke(email);
        }
    }
}