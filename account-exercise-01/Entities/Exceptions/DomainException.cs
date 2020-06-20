using System;

namespace Course.Entities.DomainExceptions
{
  class DomainException : ApplicationException
  {
    public DomainException(string message) : base(message) { }
  }
}