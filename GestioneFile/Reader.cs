using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneFile
{
    internal class Reader
    {
        private string filePath;

        public Reader(path)
        {
            filePath = Path;
        }

        public void LeggiFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write("Errore nella lettura del file" + ex.Message);
            }
        }
    }
}
