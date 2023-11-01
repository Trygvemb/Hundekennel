using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ModernDesign.MVVM.Model
{
    // Could have probably been made as a static class library or something
    public static class ExcelDataUploader
    {
        // IMPORTANT
        // You have to save the file as CSV UTF-8 (Comma delimited) (*.csv)
        // That allows this code to easily parse the file

        public static void UploadExcelFile(string filePath)
        {
            // This file path is temporary and only works on my local machine.
            filePath = @"C:\Users\jacob\Downloads\HundeData.csv";

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string? line;

                    // Ignore the first line
                    line = sr.ReadLine();

                    line = sr.ReadLine();

                    string[] words = line.Split(';');

                    // Put all words into their own variable for ease of testing
                    string pd = words[1];
                    string name = words[3];
                    DateTime dob = DateTime.Parse(words[11]);
                    string dad = words[5];
                    string mom = words[6];
                    string gender = words[18];
                    bool isDead = bool.Parse(words[20]);

                    Dog dog = new Dog(pd, name, dob, dad, mom, gender,)
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
