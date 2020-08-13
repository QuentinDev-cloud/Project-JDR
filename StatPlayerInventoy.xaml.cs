using JDR.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace JDR
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class StatPlayerInventory : Window
    {
        public StatPlayerInventory()
        {
            InitializeComponent();
            Service.TXTFile tf = new Service.TXTFile();
            tf.create("ListInventory.txt");
            readerPI();
            readerLI();
        }

        public void readerLI()
        {

            int counter = 0;
            string line;
            StreamReader file = new StreamReader(@"c:\JDR(Lisa)\ListInventory.txt");
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
                        lboxListInventory.Items.Insert(counter, word);
                    }
                    cc = 1;

                }
                counter++;
            }
            file.Close();
        }

        public void readerPI()
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
                    string[] inventory = words[3].Split('/');
                    int counter = 0;
                    int state = 0;
                    foreach (string value in inventory)
                    {
                        if (state != 0)
                        {
                            lboxPlayerInventory.Items.Insert(counter, value);
                            counter++;
                        }
                        state++;
                    }
                }
            }
            file.Close();
        }



        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lboxPlayerInventory.SelectedItem != null)
                {
                    string name = "" + lboxPlayerInventory.SelectedItem;
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
            try
            {
                if (lboxListInventory.SelectedItem != null)
                {
                    string name = SuperGlobal.GlobalName;
                    string item = "" + lboxListInventory.SelectedItem;
                    string container = "";
                    string line;
                    StreamReader file = new StreamReader(@"c:\JDR(Lisa)\Player.txt");
                    while ((line = file.ReadLine()) != null)
                    {                      
                        string[] splitline = line.Split(' ');
                        if (name == splitline[0])
                        {
                            string line2 = "";
                            int cc = 0;
                            foreach (string value in splitline)
                            {
                                if (cc == 3)
                                {
                                    string value2 = "";
                                    value2 = value + "/" + item;
                                    line2 = line2 + " " + value2;
                                }else if (cc == 0)
                                {
                                    line2 = line2 + value;
                                }else
                                {
                                    line2 = line2 + " " + value;
                                }

                                cc++;
                            }    
                            container = container + "%" + line2;
                        }
                        else
                        {
                            container = container + "%" + line;
                        }
                    }
                    file.Close();
                    Service.TXTFile tf = new Service.TXTFile();
                    tf.change2(container, "Player");
                    StatPlayerInventory sp = new StatPlayerInventory();
                    sp.Show();
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

        private void btnAddItem_Click(object sender, RoutedEventArgs e)
        {
            AddItem ai = new AddItem();
            ai.Show();
            this.Close();
        }

        private void btnDeleteItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lboxPlayerInventory.SelectedItem != null)
                {
                    lboxPlayerInventory.Items.Remove(lboxPlayerInventory.SelectedItem);
                    var list = "";
                    foreach (var item in lboxPlayerInventory.Items)
                    {
                        list = list + "/" + item.ToString();
                    }
                    string container = "";
                    int counter = 0;
                    string line;
                    StreamReader file = new StreamReader(@"c:\JDR(Lisa)\PlayerCreation.txt");
                    while ((line = file.ReadLine()) != null)
                    {
                        if (counter == 3)
                        {                            
                            container = container + " " + list;
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
                    PlayerInventory pi = new PlayerInventory();
                    pi.Show();
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

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            string container = "";
            int counter = 0;
            string line;
            StreamReader file = new StreamReader(@"c:\JDR(Lisa)\PlayerCreation.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (counter == 3)
                {
                    line = "";
                    container = container + " " + line;
                }
                else
                {
                    container = container + " " + line;
                }
                counter++;
            }
            file.Close();
            Service.TXTFile tf = new Service.TXTFile();
            tf.clearPlayerInventory(container);
            PlayerInventory pi = new PlayerInventory();
            pi.Show();
            this.Close();
        }

        private void btnValidate_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }    
}
