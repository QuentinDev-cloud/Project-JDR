using System;
using System.IO;
using System.Linq;

namespace JDR.Service
{
    class TXTFile
    {
        public string select(int number)
        {
            string choice = "";
            int counter = 0;           
            string line;
            StreamReader file = new StreamReader(@"c:\JDR(Lisa)\Player.txt");
            //Now read the file line by line
            while ((line = file.ReadLine()) != null)
            {
                choice = line;
                counter++;
                if (counter >= number)
                {
                    break;
                }
            }
            file.Close();
            return choice;
        }

        public void clear(string element)
        {
            string[] elements = {};

            StreamWriter writefile = new StreamWriter(@"c:\JDR(Lisa)\"+element+".txt");
            foreach (string line in elements)
            {
                writefile.WriteLine(line);
            }
            writefile.Close();
        }

        public void clearPlayerInventory(string items)
        {
            string[] words = items.Split(' ');
            StreamWriter writefile = new StreamWriter(@"c:\JDR(Lisa)\PlayerCreation.txt");
            int cc = 0;
            foreach (string line in words)
            {
                if (cc == 1)
                {
                    writefile.WriteLine(line);
                }
                cc = 1;
            }
            writefile.Close();
        }

        public void clearPlayerCreation()
        {
            string[] words = { "","","","" };
            StreamWriter writefile = new StreamWriter(@"c:\JDR(Lisa)\PlayerCreation.txt");
            foreach (string line in words)
            {               
                writefile.WriteLine(line);                
            }
            writefile.Close();
        }



        static long CountLinesInFile(string f)
        {
            long count = 1;
            StreamReader r = new StreamReader(f);
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    count++;
                }
            }
            r.Close();
            return count;
        }

        public void writeW(string player, string element)
        {
            var number = CountLinesInFile(@"c:\JDR(Lisa)\" + element + ".txt");
            

            StreamWriter writefile = new StreamWriter(@"c:\JDR(Lisa)\"+element+".txt", true);
            string[] elements = { number+"."+player };

            foreach (string line in elements)
            {
                writefile.WriteLine(line);
            }
            writefile.Close();
        }

        public void write(string player, string element)
        {
            Console.WriteLine(player);
            StreamWriter writefile = new StreamWriter(@"c:\JDR(Lisa)\" + element + ".txt", true);
            string[] elements = { player };
            Console.WriteLine(elements);

            foreach (string line in elements)
            {
                Console.WriteLine(line);
                writefile.WriteLine(line);
            }
            writefile.Close();
        }

        public void delete(string value, string element)
        {
            string[] words = value.Split('/');
            StreamWriter writefile = new StreamWriter(@"c:\JDR(Lisa)\" + element + ".txt", false);

            // Part 3: loop over result array.
            int start = 0;
            foreach (string word in words)
            {
                if (start == 1)
                {
                    writefile.WriteLine(word);
                }
                start=1;
                
            }
            writefile.Close();
            
        }

        public void delete2(string value, string element)
        {
            string[] words = value.Split('/');
            StreamWriter writefile = new StreamWriter(@"c:\JDR(Lisa)\" + element + ".txt", true);

            // Part 3: loop over result array.
            foreach (string word in words)
            {                
                writefile.WriteLine(word);          

            }
            writefile.Close();

        }

        public void addEnnemy(string value, string element)
        {
            string[] words = value.Split('%');
            StreamWriter writefile = new StreamWriter(@"c:\JDR(Lisa)\" + element + ".txt", false);

            // Part 3: loop over result array.
            int cc = 0;
            foreach (string word in words)
            {
                if (cc == 1)
                {
                    writefile.WriteLine(word);
                }
                cc = 1;
            }
            writefile.Close();

        }

        public void change(string value, string element)
        {
            string[] words = value.Split(' ');
            StreamWriter writefile = new StreamWriter(@"c:\JDR(Lisa)\" + element + ".txt", false);

            // Part 3: loop over result array.
            int cc = 0;
            foreach (string word in words)
            {
                if (cc == 1)
                {
                    writefile.WriteLine(word);
                }
                cc = 1;

                

            }
            writefile.Close();

        }

        public void change2(string value, string element)
        {
            string[] words = value.Split('%');
            StreamWriter writefile = new StreamWriter(@"c:\JDR(Lisa)\" + element + ".txt", false);

            // Part 3: loop over result array.
            int cc = 0;
            foreach (string word in words)
            {
                if (cc == 1)
                {
                    writefile.WriteLine(word);
                }
                cc = 1;
            }
            writefile.Close();

        }

        public void create(string fileName)
        {
            string folderName = @"c:\JDR(Lisa)";
            string pathString = System.IO.Path.Combine(folderName);
            System.IO.Directory.CreateDirectory(pathString);             
            pathString = System.IO.Path.Combine(pathString, fileName);
            if (!System.IO.File.Exists(pathString))
            {
                System.IO.FileStream fs = System.IO.File.Create(pathString);
                {
                    for (byte i = 0; i < 100; i++)
                    {
                        fs.WriteByte(i);
                    }
                }
                fs.Close();
            }
            
        }

        public void getName(string name)
        {
        }

        public void getHp(string hp)
        {
           
        }

        public void getDamage(string damage)
        {
            
        }
    }
}
