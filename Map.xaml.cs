using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace JDR
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class Map : Window
    {
        public Map()
        {
            InitializeComponent();
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

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mn = new MainWindow();
            mn.Show();
            this.Close();
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lboxPlayerList.SelectedItem != null)
                {
                    string name = "" + lboxPlayerList.SelectedItem;
                    StatPlayer stats = new StatPlayer(name);
                    stats.Show();
                    

                }
                else
                {
                    MessageBox.Show("Aucune ligne n'est sélectionnée.");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            };
        }

        private void btnEnnemy_Click(object sender, RoutedEventArgs e)
        {
            WAddEnnemy stsen = new WAddEnnemy();
            stsen.Show();
            
        }
    }
}
