using System;
using Windows.UI.Xaml;

namespace Caliburn.Micro.HelloUWP.Views
{
    public sealed partial class SecondView
    {
        public SecondView()
        {
            InitializeComponent();
        }

        private void Test(object sender, RoutedEventArgs e)
        {
            Title.Text = "Cliced";
        }
    }
}
