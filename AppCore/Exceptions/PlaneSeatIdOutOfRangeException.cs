using System;

namespace AppCore.Exceptions
{
    [Serializable]
    public class PlaneSeatIdOutOfRangeException : Exception
    {
        public PlaneSeatIdOutOfRangeException() { }

        public PlaneSeatIdOutOfRangeException(string message) : base(message) { }

        public PlaneSeatIdOutOfRangeException(string message, Exception inner) : base(message, inner) { }
    }
}