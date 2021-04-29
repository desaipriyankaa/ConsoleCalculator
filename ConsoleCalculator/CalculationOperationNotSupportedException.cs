using System;
using System.Collections;

namespace ConsoleCalculator
{
    public class CalculationOperationNotSupportedException : CalculationException
    {
        public string Operation { get; }

        /// <summary>
        /// Creates a new <see cref="CalculationOperationNotSupportedException"/> with pre-supplied message.
        /// </summary>
        public CalculationOperationNotSupportedException()
            : base("Specified operation was out of the range of valid values.")
        {
        }

        /// <summary>
        /// Creates a new <see cref="CalculationOperationNotSupportedException"/> with the operation that is not supported.
        /// </summary>
        public CalculationOperationNotSupportedException(string operation) : this()
        {
            Operation = operation;
        }

        /// <summary>
        /// Creates a new <see cref="CalculationOperationNotSupportedException"/> with user-supplied message and wrapped innerException.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public CalculationOperationNotSupportedException(string message, Exception innerException)
            : base(message,innerException)
        {        
        }

        /// <summary>
        /// Creates a new <see cref="CalculationOperationNotSupportedException"/> with the operation that is not supported and user-defined message.
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="message"></param>
        public CalculationOperationNotSupportedException(string operation, string message) 
            : base(message)
        {
            Operation = operation;
        }

        public override string Message
        {
            get
            {
                string message = base.Message;

                if (Operation != null)
                {
                    return message + Environment.NewLine + $"Unsupported Operation : {Operation}";
                }
                return message;

            }

        }
    }
}
