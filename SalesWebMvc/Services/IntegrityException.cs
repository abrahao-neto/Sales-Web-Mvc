using System;

namespace SalesWebMvc.Services
{
    public class IntegrityException : AccessViolationException
    {
        public IntegrityException(string message) : base(message)
        {
        }
    }
}
