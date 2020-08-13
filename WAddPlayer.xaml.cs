using System.IO;
using System.Windows;

namespace JDR
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class WAddPlayer : Window
    {
        public WAddPlayer()
        {
            InitializeComponent();
        }

        private void bntAddPlayer_Click(object sender, RoutedEventArgs e)
        {
            string item = txtPlayerName.Text;
            string container = "";
            int counter = 0;
            string line;
            StreamReader file = new StreamReader(@"c:\JDR(Lisa)\PlayerCreation.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (counter == 0)
                {                    
                    container = item + "" + container;
                }
                else
                {
                    container = container + " " + line;
                }
                counter++;
            }
            file.Close();
            Service.TXTFile tf = new Service.TXTFile();
            tf.write(container, "Player");
            tf.clearPlayerCreation();
            MainWindow mn = new MainWindow();
            mn.Show();
            this.Close();
        }

        private void bntReturnPlayer_Click(object sender, RoutedEventArgs e)
        {

            MainWindow mn = new MainWindow();
            mn.Show();
            this.Close();
        }

        private void bntPlayerInventory_Click(object sender, RoutedEventArgs e)
        {
            PlayerInventory pi = new PlayerInventory();
            pi.Show();
            this.Close();
        }

        private void bntPlayerCapacity_Click(object sender, RoutedEventArgs e)
        {
            PlayerCapacity pc = new PlayerCapacity();            
            pc.Show();
            this.Close();
        }

        private void bntPlayerLife_Click(object sender, RoutedEventArgs e)
        {
            PlayerLife pl = new PlayerLife();
            pl.Show();
            this.Close();

        }
    }
}
