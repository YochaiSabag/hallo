using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApp.utilities
{
    internal class FileIO
    {
        private string path;

        public FileIO(string path)
        {
            this.path = path;
        }


        public string readText(string file)
        {
            using (TextReader reader = File.OpenText(path + file)) { 
            
                return reader.ReadToEnd();
            }
        }

        public void writeText(string file, string text) { 
        
            using (TextWriter writer = File.CreateText(path + file))
            {
                writer.Write(text);
            }
        }

    }
}
