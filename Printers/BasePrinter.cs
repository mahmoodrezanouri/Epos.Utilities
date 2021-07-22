using Tei.Epos.Utilities.Interfaces;
using System;

namespace Tei.Epos.Utilities.Printers
{
    public abstract partial class BasePrinter : IDisposable
    {
        public PrinterStatusEventArgs Status { get; private set; } = null;

        public event EventHandler StatusChanged;

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

        public void PrintOutPut(string printData)
        {
            Status = new PrinterStatusEventArgs()
            {
                PrintData = printData,
            };

            StatusChanged?.Invoke(this, Status);
          
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