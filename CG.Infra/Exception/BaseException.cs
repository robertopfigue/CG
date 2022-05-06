using System.Diagnostics.CodeAnalysis;

namespace CG.Infra
{
    [ExcludeFromCodeCoverage]
    public abstract class ExceptionBase : IOException
    {
        protected ExceptionBase(string message) : base(message) { }

        protected ExceptionBase(string message, IOException innerException) : base(message, innerException) { }
    }
}
