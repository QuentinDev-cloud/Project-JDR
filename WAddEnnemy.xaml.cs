using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace JDR
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class WAddEnnemy : Window
    {
        public WAddEnnemy()
        {
            InitializeComponent();
            readerEL();
            readerEG();
        }

        public void readerEL()
        {

            int counter = 0;
            string line;
            StreamReader file = new StreamReader(@"c:\JDR(Lisa)\ListEnnemy.txt");
            //Now read the file line by line
            while ((line = file.ReadLine()) != null)
            {
                // Get Name
                string[] words = line.Split(' ');
                lboxEnnemyListAdd.Items.Insert(counter, words[0]);
                counter++;
            }
            file.Close();
        }

        public void readerEG()
        {

            int counter = 0;
            string line;
            StreamReader file = new StreamReader(@"c:\JDR(Lisa)\GameEnnemy.txt");
            //Now read the file line by line
            while ((line = file.ReadLine()) != null)
            {
                // Get Name
                string[] words = line.Split(' ');
                lboxEnnemyListIn.Items.Insert(counter, words[0]);
                counter++;
            }
            file.Close();
        }





        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lboxEnnemyListIn.SelectedItem != null)
                {
                    string name = "" + lboxEnnemyListIn.SelectedItem;
                    StatsEnnemy stats = new StatsEnnemy(name);
                    stats.Show();
                    this.Close();
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

        private void btnAddEn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lboxEnnemyListAdd.SelectedItem != null)
                {
                    string ennemy = "" + lboxEnnemyListAdd.SelectedItem;
                    string line;
                    string container = "";
                    StreamReader file = new StreamReader(@"c:\JDR(Lisa)\ListEnnemy.txt");
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] words = line.Split(' ');
                        // Get Name
                        if (ennemy == words[0])
                        {
                            Service.Service serv = new Service.Service();
                            string id = serv.RandomString(6);
                            container = id + "/" + words[0] + " " + words[1] + " " + words[2] + " " + words[3] + " " + words[4] + " " + words[5] + " " + words[6];
                        }
                    }
                    file.Close();
                    Service.TXTFile tf1 = new Service.TXTFile();
                    tf1.write(container, "GameEnnemy");
                    WAddEnnemy sten = new WAddEnnemy();
                    sten.Show();
                    this.Close();

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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddEnnemy ae = new AddEnnemy();
            ae.Show();
            this.Close();
        }

        private void btnDeleteEn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lboxEnnemyListIn.SelectedItem != null)
                {
                    lboxEnnemyListIn.Items.Remove(lboxEnnemyListIn.SelectedItem);

                    var list = "";

                    foreach (var item in lboxEnnemyListIn.Items)
                    {
                        list = list+"/"+item.ToString();
                    }
                    Service.TXTFile tXT = new Service.TXTFile();
                    tXT.delete(list, "GameEnnemy");


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
            WAddEnnemy sten = new WAddEnnemy();
            sten.Show();
            this.Close();
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            Service.TXTFile tx = new Service.TXTFile();
            tx.clear("GameEnnemy");
            WAddEnnemy sten = new WAddEnnemy();
            sten.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lboxEnnemyListAdd.SelectedItem != null)
                {
                    lboxEnnemyListAdd.Items.Remove(lboxEnnemyListAdd.SelectedItem);

                    var list = "";

                    foreach (var item in lboxEnnemyListAdd.Items)
                    {
                        list = list + "/" + item.ToString();
                    }
                    Service.TXTFile tXT = new Service.TXTFile();
                    tXT.delete(list, "ListEnnemy");


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
            WAddEnnemy sten = new WAddEnnemy();
            sten.Show();
            this.Close();
        }
    }    
}
