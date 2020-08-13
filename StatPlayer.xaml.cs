using JDR.Service;
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
    public partial class StatPlayer : Window
    {

        public StatPlayer(string name)
        {
            SuperGlobal.GlobalName = name;
            InitializeComponent();
            txtPlayerName.Text = name;
            readAll();
        }

        public void readAll()
        {
            string name = SuperGlobal.GlobalName;
            string line;
            StreamReader file = new StreamReader(@"c:\JDR(Lisa)\Player.txt");
            //Now read the file line by line
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(' ');
                // Get Name
                if (name == words[0])
                {
                    txtPlayerHp.Text = words[1];
                }              
            }
            file.Close();

        }

        private void btnAddPlayer_Click(object sender, RoutedEventArgs e)
        {           
            this.Close();
        }

        private void bntPlayerInventory_Click(object sender, RoutedEventArgs e)
        {
            StatPlayerInventory sti = new StatPlayerInventory();
            sti.Show();
        }

        private void bntPlayerCapacity_Click(object sender, RoutedEventArgs e)
        {
            StatPlayerCapacity sti = new StatPlayerCapacity();
            sti.Show();
        }
    }
}
