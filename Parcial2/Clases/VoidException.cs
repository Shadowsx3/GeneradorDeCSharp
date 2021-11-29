using System;

namespace Parcial2.Clases
{
    public class VoidException : Exception
    {
        public VoidException() { }

        public VoidException(string message)
            : base(message)
        {
        }
        public VoidException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}