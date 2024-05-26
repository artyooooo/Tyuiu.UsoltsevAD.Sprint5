using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.UsoltsevAD.Sprint5.Task5.V27.Lib
{
    public class DataService : ISprint5Task5V27
    {
        public double LoadFromDataFile(string path)
        {
            int counter = 0;
            double value = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) % 5 == 0)
                    {
                        value += Convert.ToDouble(line);
                        counter += 1;
                    }
                }
            }
            return value / counter;
        }
    }
}
