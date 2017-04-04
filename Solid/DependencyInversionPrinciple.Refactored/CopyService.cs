namespace Solid.DependencyInversionPrinciple.Refactored
{
    public class CopyService
    {
        public void Copy(IReader reader, IWriter writer) {}
    }

    public interface IWriter
    {
    }

    public interface IReader
    {
    }
}
