using System.IO;
using System.Windows;

namespace JDR
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class AddItem : Window
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void bntAddItem_Click(object sender, RoutedEventArgs e)
        {
            string item = txtAddItem.Text; 
            string container = "";
            string line;
            StreamReader file = new StreamReader(@"c:\JDR(Lisa)\ListInventory.txt");
            while ((line = file.ReadLine()) != null)
            {            
                container = container + " " + line;      
            }
            container = container + " " + item;
            file.Close();
            Service.TXTFile tf = new Service.TXTFile();
            tf.change(container, "ListInventory");
            PlayerInventory ad = new PlayerInventory();
            ad.Show();
            this.Close();
        }
    }
}
