using System;
using System.Reflection;
using System.Windows;

namespace WPF.Popup
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string path = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"hh.html");
            this.webBrowser.Source = new Uri(path);
        }
    }
}
