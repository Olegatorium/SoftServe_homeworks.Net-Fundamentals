using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    static class Donor
    {

        private static string currentPhotoPath;

        public static string CurrentPhotoPath
        {
            get { return currentPhotoPath; }
            set { currentPhotoPath = value; }
        }

        public static bool IsImageFile(string filePath)
        {
            string extension = Path.GetExtension(filePath);
            string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif" };

            return allowedExtensions.Contains(extension.ToLower());
        }


        public static void SaveData(string date, string name, string surname, string id, string number,
     string email, string bloodType, string photoPath)
        {
         
            Random random = new Random();
            int donorId = random.Next(10000, 99999);

            string info = donorId + "|" + date + "|" + name + "|" + surname + "|" + id + "|" + number +
                "|" + email + "|" + bloodType + "|" + photoPath;

            using (StreamWriter sw = File.AppendText("DonorsData.txt"))
            {
                sw.WriteLine(info);
            }



            MessageBox.Show("You entered data successfully");
        }


        public static List<string> GetAllRecords()
        {
            List<string> records = new List<string>();

            using (StreamReader sr = new StreamReader("DonorsData.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    records.Add(line);
                }
            }

            return records;
        }
        
    }
}

