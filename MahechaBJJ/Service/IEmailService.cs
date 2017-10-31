using System;
using MahechaBJJ.Model;

namespace MahechaBJJ.Service
{
    public interface IEmailService
    {
        void StartEmailActivity(EmailMessage message);
    }
}
