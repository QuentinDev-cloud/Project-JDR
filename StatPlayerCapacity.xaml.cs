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
    public partial class StatPlayerCapacity : Window
    {
        public StatPlayerCapacity()
        {           
            InitializeComponent();
            Service.TXTFile tf = new Service.TXTFile();
            tf.create("ListCapacity.txt");
            readerPC();
            readerLC();
        }
        
        public void readerLC()
        {

            int counter = 0;
            string line;
            StreamReader file = new StreamReader(@"c:\JDR(Lisa)\ListCapacity.txt");
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
                        lboxListCapacity.Items.Insert(counter, word);
                    }
                    cc = 1;

                }
                counter++;
            }
            file.Close();
        }

        public void readerPC()
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
                    string[] inventory = words[2].Split('/');
                    int counter = 0;
                    int state = 0;
                    foreach (string value in inventory)
                    {
                        if (state != 0)
                        {
                            lboxPlayerCapacity.Items.Insert(counter, value);
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
                if (lboxPlayerCapacity.SelectedItem != null)
                {
                    string name = "" + lboxPlayerCapacity.SelectedItem;
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
                if (lboxListCapacity.SelectedItem != null)
                {
                    string item = "" + lboxListCapacity.SelectedItem;
                    string container = "";
                    int counter = 0;
                    string line;
                    StreamReader file = new StreamReader(@"c:\JDR(Lisa)\PlayerCreation.txt");
                    while ((line = file.ReadLine()) != null)
                    {                        
                        if (counter == 2)
                        {
                            line = line + "/" + item;
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
                    tf.change(container, "PlayerCreation");
                    PlayerCapacity pi = new PlayerCapacity();
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

        private void btnAddCapacity_Click(object sender, RoutedEventArgs e)
        {
            AddCapacity ac = new AddCapacity();
            ac.Show();
            this.Close();
        }

        private void btnDeleteCapacity_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lboxPlayerCapacity.SelectedItem != null)
                {
                    lboxPlayerCapacity.Items.Remove(lboxPlayerCapacity.SelectedItem);
                    var list = "";
                    foreach (var item in lboxPlayerCapacity.Items)
                    {
                        list = list + "/" + item.ToString();
                    }
                    string container = "";
                    int counter = 0;
                    string line;
                    StreamReader file = new StreamReader(@"c:\JDR(Lisa)\PlayerCreation.txt");
                    while ((line = file.ReadLine()) != null)
                    {
                        if (counter == 2)
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
                    PlayerCapacity pi = new PlayerCapacity();
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
                if (counter == 2)
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
            PlayerCapacity pi = new PlayerCapacity();
            pi.Show();
            this.Close();
        }

        private void btnValidate_Click(object sender, RoutedEventArgs e)
        {           
            this.Close();
        }

       
    }    
}
