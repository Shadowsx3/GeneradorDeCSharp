using System;

namespace PracticoNoObligatorio.Clases.Managers
{
    public class NumException:Exception
    {
            public NumException() { }

            public NumException(string message)
                : base(message)
            {
            }

            public NumException(string message, Exception inner)
                : base(message, inner)
            {
            }
    }
}