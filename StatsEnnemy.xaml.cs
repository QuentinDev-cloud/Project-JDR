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
    /// Logique d'interaction pour StatsEn.xaml
    /// </summary>
    public partial class StatsEnnemy : Window
    {
        public StatsEnnemy(string name)
        {
            InitializeComponent();
            txtName.Text = name; 
            string line;
            StreamReader file = new StreamReader(@"c:\JDR(Lisa)\GameEnnemy.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(' ');
                if (name == words[0])
                {
                    txtHp.Text = words[1];
                    txtXp.Text = words[2];
                    txtGold.Text = words[3];
                    txtAtk.Text = words[4];
                }
            }
            file.Close();

        }

        private void bntAddEnnemy_Click(object sender, RoutedEventArgs e)
        {         

            string line;
            string container = "";
            string name = txtName.Text;
            string hp = txtHp.Text;
            string xp = txtXp.Text;
            string gold = txtXp.Text;
            string loot = "";
            string aptitude = "";
            string atk = txtAtk.Text;

            if (name == "" || name == null)
            {
                name = "none";
            }

            if (hp == "" || hp == null)
            {
                hp = "1";
            }

            if (xp == "" || xp == null)
            {
                xp = "1";
            }

            if (gold == "" || gold == null)
            {
                gold = "1";
            }

            if (loot == "" || loot == null)
            {
                loot = "none";
            }
            if (aptitude == "" || aptitude == null)
            {
                aptitude = "none";
            }
            if (atk == "" || atk == null)
            {
                atk = "none";
            }

            
            StreamReader file = new StreamReader(@"c:\JDR(Lisa)\GameEnnemy.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(' ');    
                if (name == words[0])
                {
                    MessageBox.Show("0");
                    container = container + "%" + name + " " + hp + " " + xp + " " + gold + " " + loot + " " + aptitude + " " + atk;
                }
                else
                {
                    MessageBox.Show("1");
                    container = container + "%" + line;
                }               
            }
            file.Close();
            Service.TXTFile tf = new Service.TXTFile();
            tf.addEnnemy(container, "GameEnnemy");
            WAddEnnemy ad = new WAddEnnemy();
            ad.Show();
            this.Close();
        }
    }
}
