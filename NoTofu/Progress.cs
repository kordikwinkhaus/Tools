using System;
using System.Threading;

namespace NoTofu
{
    public class Progress<T> : IProgress<T>
    {
        private readonly Action<T> m_handler;
        private readonly SynchronizationContext m_synchronizationContext;

        public Progress(Action<T> handler) 
        {
            if (handler == null) throw new ArgumentNullException("handler");
            if (SynchronizationContext.Current == null) throw new InvalidOperationException("Call ctor on UI thread.");

            this.m_synchronizationContext = SynchronizationContext.Current;
            this.m_handler = handler;
        }

        public void Report(T value)
        {
            Action<T> handler = this.m_handler;
            if (handler != null)
            {
                this.m_synchronizationContext.Post(this.InvokeHandlers, value);
            }
        }

        private void InvokeHandlers(object state)
        {
            T t = (T)(state);
            m_handler(t);
        }
    }
}
