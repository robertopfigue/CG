using System.Diagnostics.CodeAnalysis;

namespace CG.Infra.Exception
{
    [ExcludeFromCodeCoverage]
    public class DomainException : ExceptionBase
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
