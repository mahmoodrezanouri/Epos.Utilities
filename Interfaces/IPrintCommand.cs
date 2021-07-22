namespace Epos.Utilities.Interfaces
{
    public interface IPrintCommand
    {
        void Print(string data);

        void Print(IFluentPrint document);

        void SetConfig(IConfig config);
    }
}
