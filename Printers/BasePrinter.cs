using Epos.Utilities.Interfaces;
using System;

namespace Epos.Utilities.Printers
{
    public abstract partial class BasePrinter : IDisposable
    {
        
        //public event EventHandler StatusChanged;

        protected virtual bool IsConnected => false;

        protected BasePrinter()
        {
           
        }

        protected virtual void Connect()
        {

        }

        protected virtual void Reconnect()
        {
         
        }

        public virtual void Set(IPrintCommand command)
        {

        }

        public virtual void Print(IFluentPrint document)
        {

        }
        public virtual void StartMonitoring()
        {
            
        }

        public virtual void StopMonitoring()
        {
            
        }

        ~BasePrinter()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
           
        }
    }
}