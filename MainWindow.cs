using Delta.WPF;
using RiotPlayButton.Components;
using System.Windows;

namespace RiotPlayButton
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            Title = "MVU Application";
            Width = 800;
            Height = 600;
#if DEBUG
            HotReloadService.UpdateApplicationEvent += ReloadUI;
#endif
            ApplicationRoot.Initialize (new RiotPlayButtonComponent (), this);
        }

        private void ReloadUI(Type[] obj)
        {
            Dispatcher.BeginInvoke (() =>
            {
                ApplicationRoot.Instance.Rebuild ();
            });
        }
    }
}