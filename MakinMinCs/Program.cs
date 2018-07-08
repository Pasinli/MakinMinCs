using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MakingMin
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("min and drag and drop the file .!");
            Console.WriteLine(" ");
            Console.WriteLine("quit for exit");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            x:

            string cmd = Console.ReadLine(), filePath = "", bytString = "";
            Regex rg = new Regex(@"\s");


            if (cmd[0].ToString() + cmd[1].ToString() + cmd[2].ToString() == "min")
            {
                for (int i = 0; i < cmd.Length; i++)
                {
                    if (i > 2 && cmd[i] != '"')
                        filePath += cmd[i];
                }
                try
                {
                    string[] text = rg.Split(File.ReadAllText(filePath));
                    for (int i = 0; i < text.Length; i++)
                    {
                        bytString += text[i];

                    }
                    File.WriteAllText(filePath, bytString);
                    Console.WriteLine("İşlem tamam!");
                }
                catch
                {

                    Console.WriteLine("Dosya anlaşılamadı.");
                }


            }
            else if (cmd[0].ToString() + cmd[1].ToString() + cmd[2].ToString() + cmd[3].ToString() == "quit")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Komut anlaşılamadı ?", cmd[0].ToString() + cmd[1].ToString() + cmd[2].ToString());
            }


            Console.WriteLine("\t");
            goto x;


        }
    }
}
