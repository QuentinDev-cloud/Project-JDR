using System.IO;
using System.Windows;

namespace JDR
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class AddCapacity : Window
    {
        public AddCapacity()
        {
            InitializeComponent();
        }

        private void bntAddCapacity_Click(object sender, RoutedEventArgs e)
        {
            string item = txtAddCapacity.Text; 
            string container = "";
            string line;
            StreamReader file = new StreamReader(@"c:\JDR(Lisa)\ListCapacity.txt");
            while ((line = file.ReadLine()) != null)
            {            
                container = container + " " + line;      
            }
            container = container + " " + item;
            file.Close();
            Service.TXTFile tf = new Service.TXTFile();
            tf.change(container, "ListCapacity");
            PlayerCapacity ac = new PlayerCapacity();
            ac.Show();
            this.Close();
        }
    }
}
