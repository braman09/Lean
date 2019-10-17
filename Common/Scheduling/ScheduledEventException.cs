using System;

namespace QuantConnect.Scheduling
{
    /// <summary>
    /// Throw this if there is an exception in the callback function of the scheduled event
    /// </summary>
    public class ScheduledEventException : Exception
    {
        /// <summary>
        /// Gets the name of the scheduled event
        /// </summary>
        public string ScheduledEventName { get; }

        /// <summary>
        /// ScheduledEventException constructor
        /// </summary>
        /// <param name="name">The name of the scheduled event</param>
        /// <param name="message">The exception as a string</param>
        /// <param name="innerException">The exception that is the cause of the current exception</param>
        public ScheduledEventException(string name, string message, Exception innerException) : base(message, innerException)
        {
            ScheduledEventName = name;
        }
    }
}