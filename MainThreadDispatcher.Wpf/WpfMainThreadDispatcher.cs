using System;
using System.Threading.Tasks;
using System.Windows;

namespace MainThreadDispatcher.Wpf
{
    public sealed class WpfMainThreadDispatcher : IMainThreadDispatcher
    {
        public void Invoke(Action action) => Application.Current.Dispatcher.Invoke(action);

        public async Task InvokeAsync(Action action) => await Application.Current.Dispatcher.InvokeAsync(action);

        public async Task<T> InvokeAsync<T>(Func<T> func) => await Application.Current.Dispatcher.InvokeAsync(func);
    }
}
