using System.IO;
using System.Windows;

namespace JDR
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Service.TXTFile tf = new Service.TXTFile();
            tf.create("Player.txt");
            tf.create("ListEnnemy.txt");
            tf.create("GameEnnemy.txt");
            reader();
        }

        public void reader()
        {

            int counter = 0;
            string line;
            StreamReader file = new StreamReader(@"c:\JDR(Lisa)\Player.txt");
            //Now read the file line by line
            while ((line = file.ReadLine()) != null)
            {
                // Get Name
                string[] words = line.Split(' ');
                int cc = 0;
                foreach (string word in words)
                {
                    if (cc == 0)
                    {
                        lboxPlayerList.Items.Insert(counter, word);
                    }
                    cc = 1;

                }
                counter++;
            }
            file.Close();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            Map map = new Map();
            map.Show();
            this.Close();
        }

        private void btnAddPlayer_Click(object sender, RoutedEventArgs e)
        {
            Service.TXTFile tf = new Service.TXTFile();
            tf.create("PlayerCreation.txt");
            WAddPlayer adp = new WAddPlayer();
            adp.Show();
            this.Close();
        }

        private void btnClearPlayer_Click(object sender, RoutedEventArgs e)
        {
            Service.TXTFile tx = new Service.TXTFile();
            tx.clear("Player");
            MainWindow mn = new MainWindow();
            mn.Show();
            this.Close();
            

        }
    }
}
