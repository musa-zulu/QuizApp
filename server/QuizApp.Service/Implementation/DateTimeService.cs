using QuizApp.Service.Contract;
using System;

namespace QuizApp.Service.Implementation
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}