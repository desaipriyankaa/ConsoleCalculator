using System;

namespace ConsoleCalculator
{
    class CalculationException : Exception
    {
        private static readonly string DefaultMessage = "An error occured during calculation. Ensure that the operator supported and that the values are within valid ranges for the requested operation.";
       
        /// <summary>
        /// Creates a new <see cref="CalculationException"/> with pre-defined message.
        /// </summary>
        public CalculationException() : base(DefaultMessage)
        {
        }

        /// <summary>
        /// Creates a new <see cref="CalculationException"/> with user-supplied message.
        /// </summary>
        /// <param name="message"></param>
        public CalculationException(string message) : base(message)
        {               
        }

        /// <summary>
        /// Creates a new <see cref="CalculationException"/> with pre-defined message and a wrapped innerException.
        /// </summary>
        /// <param name="innerException"></param>
        public CalculationException(Exception innerException) : base(DefaultMessage, innerException)
        {         
        }

        /// <summary>
        /// Creates a new <see cref="CalculationException"/> with user-supplied message and wrapped innerException.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public CalculationException(string message, Exception innerException) : base(message,innerException)
        {
        }
    }
}
