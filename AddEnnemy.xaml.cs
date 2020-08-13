using System.IO;
using System.Windows;

namespace JDR
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class AddEnnemy : Window
    {
        public AddEnnemy()
        {
            InitializeComponent();
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




            StreamReader file = new StreamReader(@"c:\JDR(Lisa)\ListEnnemy.txt");
            while ((line = file.ReadLine()) != null)
            {
                container = container + "%" + line;
            }
            container = container + "%" + name + " " + hp + " " + xp + " " + gold + " " + loot + " " + aptitude + " " + atk;
            file.Close();
            Service.TXTFile tf = new Service.TXTFile();
            tf.addEnnemy(container, "ListEnnemy");
            WAddEnnemy ad = new WAddEnnemy();
            ad.Show();
            this.Close();
        }
    }
}
