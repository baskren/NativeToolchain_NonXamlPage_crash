using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace App2
{
    [Windows.UI.Xaml.Data.Bindable]
    class NotXamlPage : Page
    {
        Button _button;

        public NotXamlPage()
        {
            _button = new Button
            {
                Content = "XAML PAGE",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };
            Grid.SetRow(_button, 1);

            Content = new Grid
            {
                RowDefinitions = 
                {
                    new RowDefinition{ Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition{ Height = new GridLength(1, GridUnitType.Star)},
                },
                Children =
                {
                    new TextBlock
                    {
                        Text = "NOT A XAML PAGE",
                        HorizontalAlignment = HorizontalAlignment.Center,
                        VerticalAlignment = VerticalAlignment.Center
                    },
                    _button
                }
            };

            _button.Click += _button_Click;
        }

        private void _button_Click(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(MainPage), null);
        }
    }
}
