﻿using System;
using Windows.UI.Xaml;

namespace Caliburn.Micro.HelloUWP.Views
{
    public sealed partial class ThirdView
    {
        public ThirdView()
        {
            InitializeComponent();
        }

        private void Test(object sender, RoutedEventArgs e)
        {
            Title.Text = "Cliced";
        }
    }
}
