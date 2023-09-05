using myApp.utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace myApp
{
    class Program
    {
        private static string path = @"C:\Users\LogIn\Documents\project\myApp\myApp\appData\";
        private static FileIO fileIO = new FileIO(path);

        static void Main(string[] args)
        {
            int choise = fileIO.readText("appMenu.txt").ElementAt(20) - '0';
            selectFromMenue(choise);
        }
        public static void selectFromMenue(int choise) {
            switch (choise)
            {
                case 1:
                    callReverseNumbers();
                    break;
                default: throw new ArgumentException("word choise number");
            }
        }
        public static void callReverseNumbers()
        { 
            int content = Int32.Parse(fileIO.readText("appNumInput.txt"));
            string txt = Implementions.ReverseNumbers(content).ToString();
            fileIO.writeText("appResults.txt", txt);
        }
    }
}
