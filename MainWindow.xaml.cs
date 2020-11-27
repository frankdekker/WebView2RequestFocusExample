using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace WebView2RequestFocusExample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is TabControl tabControl)
            {
                Debug.WriteLine("Selected index:" + tabControl.SelectedIndex);
                if (tabControl.SelectedIndex == 0)
                {
                    WebViewA.Focus();
                }
                else if (tabControl.SelectedIndex == 1)
                {
                    WebViewB.Focus();
                }
            }
        }
    }
}
