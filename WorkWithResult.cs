using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SpeedWriter
{
    public static class WorkWithResult
    {
        public static bool Save(string playerName, int result)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("Result.txt", true))
                {
                    string str = $"{playerName},{result}";
                    writer.WriteLine(str);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool isNewRecord(int result)
        {
            try
            {
                using(StreamReader reader = new StreamReader("Result.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        int resFromReader = int.Parse(reader.ReadLine().Split(',')[1].Trim());
                        if (result <= resFromReader)
                            return false;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
