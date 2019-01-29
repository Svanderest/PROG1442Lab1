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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double Total = 0.0;
            int Tip = 0;
            lblGrandTotalResult.Text = "";
            lblGrandTotalResult.Foreground = (SolidColorBrush)Resources["DefaultBrush"];
            if (!double.TryParse(txtTotal.Text, out Total))            
                lblGrandTotalResult.Text += "Please enter a valid numerical total. ";
            if (cmbTip.SelectedIndex == -1 || !int.TryParse(((ComboBoxItem)cmbTip.SelectedItem).Content.ToString(), out Tip))
                lblGrandTotalResult.Text += "Please select a tip amount. ";
            if (lblGrandTotalResult.Text.Length == 0)
                lblGrandTotalResult.Text = new Calculator(Total, Tip, (bool)chkTaxex.IsChecked).GrandTotal.ToString();
            else
                lblGrandTotalResult.Foreground = (SolidColorBrush)Resources["ErrorBrush"];
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lblGrandTotalResult.Text = "";
            txtTotal.Text = "";
            lblGrandTotalResult.Foreground = (SolidColorBrush)Resources["DefaultBrush"];
        }
    }
}
