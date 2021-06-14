using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace TestFS
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch swTotalTime = new Stopwatch();
            string mediaFolder = @"V:\media\";

            swTotalTime.Restart();

            int count = 0;
            try
            {
                string[] tempBadDirectories = Directory.GetDirectories(mediaFolder, "*.bad", SearchOption.AllDirectories);
                count = tempBadDirectories.Length;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Directory.GetDirectories('*.bad') failed. " + ex.Message);
            }
                
            Console.WriteLine("There are " + count + " 'bad' directories");

            try
            {
                string[] tempBadDirectories = Directory.GetDirectories(mediaFolder, "*.del", SearchOption.AllDirectories);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Directory.GetDirectories('*.del') failed. " + ex.Message);
            }
                
            Console.WriteLine("There are " + count + " 'del' directories");

            try
            {
                string[] tempBadDirectories = Directory.GetDirectories(mediaFolder, "*.bdel", SearchOption.AllDirectories);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Directory.GetDirectories('bdel') failed. " + ex.Message);
            }
                
            Console.WriteLine("There are " + count + " 'bdel' directories");

            Console.WriteLine("Done");
        }
    }
}
