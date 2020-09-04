using oop_lab2.text_elements;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab2.io_file_work
{
    public class File
    {
        private string ipath = @"D:\grsu\input.txt";
        private string opath = @"D:\grsu\output.txt";
        public string rText;
        public File()
        {
            readFile();
            FullText ft = new FullText(rText);
            Console.WriteLine(ft.buildedStrFullText);
            writeToFile(ft);
            Console.ReadKey();
        }
        public void readFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(ipath))
                {
                    rText = sr.ReadToEnd();
                }
                Console.WriteLine("Reading completed");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void writeToFile(FullText ft)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(opath, false, System.Text.Encoding.Default))
                {
                    sw.Write(ft.buildedStrFullText);
                }
                Console.WriteLine("Writing completed");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
