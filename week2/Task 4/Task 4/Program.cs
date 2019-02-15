using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\firstadik\Desktop\PP2\week2\Task 4\Mc.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sr = new StreamWriter(fs);
            sr.WriteLine("Alen");
            sr.Close();
            fs.Close();
            File.Copy(@"C:\Users\firstadik\Desktop\PP2\week2\Task 4\Mc.txt", @"C:\Users\firstadik\Desktop\PP2\week2\Task 4\Alen\Mc.txt");

            File.Delete(@"C:\Users\firstadik\Desktop\PP2\week2\Task 4\Mc.txt");



        }
    }
}