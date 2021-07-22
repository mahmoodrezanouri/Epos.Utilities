using Tei.Epos.Utilities.Interfaces;

namespace Tei.Epos.Utilities
{
    public abstract partial class BaseCommandEmitter : IPrintCommand
    {
        public virtual void Print(string data) 
        {
            
        }
        public void Print(IFluentPrint document)
        {
            throw new System.NotImplementedException();
        }
        public void SetConfig(IConfig config)
        {

        }
    }
}
