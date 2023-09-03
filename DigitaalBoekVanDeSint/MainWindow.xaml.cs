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

namespace DigitaalBoekVanDeSint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

    

        private void BtnRegisteren_CLick(object sender, RoutedEventArgs e)
        {
            string naamToevoegen = NaamKinderen.Text;
            if (ComboBoxKinderen.SelectedIndex != -1)
            {
                ComboBoxItem geselecteerdeItem = (ComboBoxItem)ComboBoxKinderen.SelectedItem;
                string itemtekst = geselecteerdeItem.Content.ToString();
                if(itemtekst.Contains("Stout"))
                {
                    ListBoxItem itemsToevoegen = new ListBoxItem();
                    itemsToevoegen.Content = naamToevoegen;
                    ListBoxStoutKind.Items.Add(itemsToevoegen);
                    NaamKinderen.Clear();
                }
                else if(itemtekst == "Flink")
                {
                    ListBoxItem itemsToevoegen = new ListBoxItem();
                    itemsToevoegen.Content = naamToevoegen;
                    ListBoxFlinkKind.Items.Add(itemsToevoegen);
                    NaamKinderen.Clear();
                }

            }
            NaamKinderen.Focus();

        }

        private void BtnVerwijder_Click(object sender, RoutedEventArgs e)
        {
            ListBoxFlinkKind.Items.Remove(ListBoxFlinkKind.SelectedItem);
            ListBoxFlinkKind.SelectedIndex = -1;
            ListBoxStoutKind.Items.Remove(ListBoxStoutKind.SelectedItem);
            ListBoxStoutKind.SelectedIndex = -1;

        }

        private void knopNaarStout_Click(object sender, RoutedEventArgs e)
        {
                      
                ListBoxStoutKind.Items.Add((ListBoxItem)ListBoxFlinkKind.SelectedItem);
               ListBoxStoutKind.Items.Remove((ListBoxItem)ListBoxFlinkKind.SelectedItem);    
            
        }
    }
}
