using System.IO;
using System.Windows;

namespace JDR
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class PlayerLife : Window
    {
        public PlayerLife()
        {
            InitializeComponent();
        }

        private void bntAddEnnemy_Click(object sender, RoutedEventArgs e)
        {
            string life = txtAddEnnemy.Text;         
            string container = "";
            int counter = 0;
            string line;
            StreamReader file = new StreamReader(@"c:\JDR(Lisa)\PlayerCreation.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (counter == 1)
                {                    
                    container = container + " " + life;
                }
                else
                {
                    container = container + " " + line;
                }
                counter++;
            }
            file.Close();
            Service.TXTFile tf = new Service.TXTFile();
            tf.change(container, "PlayerCreation");
            WAddPlayer wa = new WAddPlayer();
            wa.Show();
            this.Close();
        }
    }
}
