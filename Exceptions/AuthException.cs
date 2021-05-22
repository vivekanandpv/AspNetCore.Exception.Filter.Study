using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Exception.Filter.Study.Exceptions
{

    [Serializable]
    public class AuthException : System.Exception
    {
        public AuthException() { }
        public AuthException(string message) : base(message) { }
        public AuthException(string message, System.Exception inner) : base(message, inner) { }
        protected AuthException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }




    [Serializable]
    public class DomainValidationException : System.Exception
    {
        public DomainValidationException() { }
        public DomainValidationException(string message) : base(message) { }
        public DomainValidationException(string message, System.Exception inner) : base(message, inner) { }
        protected DomainValidationException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
