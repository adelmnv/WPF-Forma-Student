using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Study
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, Abstractions.IView
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string TextBox { get => tbxEnter.Text; set => tbxEnter.Text = value; }
        public string Id { get=> tbxId.Text; set => tbxId.Text = value; }
        public string StName { get => tbxName.Text; set => tbxName.Text = value; }
        public string Roll { get => tbxRoll.Text; set => tbxRoll.Text = value; }
        public string All { get => tbxAll.Text; set => tbxAll.Text = value; }
        public string Button { get; set; }

        public event EventHandler GetInformation;
        private void bt_First(object sender, RoutedEventArgs e)
        {
            Button = "first";
            if (GetInformation != null)
                GetInformation.Invoke(this, e);
        }
        private void bt_Previous(object sender, RoutedEventArgs e)
        {
            Button = "previous";
            if (GetInformation != null)
                GetInformation.Invoke(this, e);
        }

        private void bt_Next(object sender, RoutedEventArgs e)
        {
            Button = "next";
            if (GetInformation != null)
                GetInformation.Invoke(this, e);
        }

        private void bt_Last(object sender, RoutedEventArgs e)
        {
            Button = "last";
            if (GetInformation != null)
                GetInformation.Invoke(this, e);
        }

        private void bt_Search(object sender, RoutedEventArgs e)
        {
            Button = "search";
            if(GetInformation != null)
                GetInformation.Invoke(this, e);
        }
    }
}
