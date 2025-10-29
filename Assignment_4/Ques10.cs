// Q10. Design a delegate Notifier for sending notifications.
// • Implement SendEmail and SendSMS.
// • Call both methods using delegate chaining for the message "Assignment Submitted Successfully".

using System;

namespace Assignment_4
{
    internal class Ques10
    {
        delegate void Notifier(string msg);

        static void SendEmail(string msg) => Console.WriteLine("Email: " + msg);
        static void SendSMS(string msg) => Console.WriteLine("SMS: " + msg);

        static void Main(string[] args)
        {
            Notifier notify = SendEmail;
            notify += SendSMS;

            notify("Assignment Submitted Successfully");
            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
