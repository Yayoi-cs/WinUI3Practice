using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI3Practice
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }
        private void ColorPicker_ColorChanged(ColorPicker sender, ColorChangedEventArgs args)
        {
            Border1.Background = new SolidColorBrush(ColorPicker.Color);
            Border2.Background = new SolidColorBrush(Color.FromArgb(Convert.ToByte(ColorPicker.Color.A - 50),ColorPicker.Color.R, ColorPicker.Color.G, ColorPicker.Color.B));
            Border3.Background = new SolidColorBrush(Color.FromArgb(Convert.ToByte(ColorPicker.Color.A - 100), ColorPicker.Color.R, ColorPicker.Color.G, ColorPicker.Color.B));
            Border4.Background = new SolidColorBrush(Color.FromArgb(Convert.ToByte(ColorPicker.Color.A - 150), ColorPicker.Color.R, ColorPicker.Color.G, ColorPicker.Color.B));
            Border5.Background = new SolidColorBrush(Color.FromArgb(Convert.ToByte(ColorPicker.Color.A - 200), ColorPicker.Color.R, ColorPicker.Color.G, ColorPicker.Color.B));
        }
    }
}
