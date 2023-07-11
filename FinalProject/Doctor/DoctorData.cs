using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    class DoctorData
    {
        public void SaveData(string chosenDoctor, string name, string surname, string experience, string salary,
                           string numberOfDeclaredPatients, string numberOfPerformedOperations)
        {
            Doctor doctor;

            switch (chosenDoctor)
            {
                case "Cardiologist":
                case "Neurologist":
                case "Dermatologist":
                case "Beautician":
                case "Dentist":
                    doctor = new Doctor();
                    doctor.DoctorSpecialty = chosenDoctor;
                    doctor.Name = name;
                    doctor.Surname = surname;
                    doctor.Experience = int.Parse(experience);
                    doctor.Salary = decimal.Parse(salary);
                    break;
                case "Pediatrician":
                    Pediatrician pediatrician = new Pediatrician();
                    pediatrician.DoctorSpecialty = chosenDoctor;
                    pediatrician.Name = name;
                    pediatrician.Surname = surname;
                    pediatrician.Experience = int.Parse(experience);
                    pediatrician.Salary = decimal.Parse(salary);
                    pediatrician.DeclaredPatients = int.Parse(numberOfDeclaredPatients);
                    doctor = pediatrician;
                    break;
                case "Surgeon":
                    Surgeon surgeon = new Surgeon();
                    surgeon.DoctorSpecialty = chosenDoctor;
                    surgeon.Name = name;
                    surgeon.Surname = surname;
                    surgeon.Experience = int.Parse(experience);
                    surgeon.Salary = decimal.Parse(salary);
                    surgeon.Surgeries = int.Parse(numberOfPerformedOperations);
                    doctor = surgeon;
                    break;
                default:
                    MessageBox.Show("Invalid doctor type");
                    return;
            }

            string info = $"{doctor.DoctorSpecialty}|{doctor.Name}|{doctor.Surname}|{doctor.Experience}|{doctor.Salary}";

            if (doctor is Pediatrician)
            {
                Pediatrician pediatrician = (Pediatrician)doctor;
                info += $"|{pediatrician.DeclaredPatients}";
            }
            else if (doctor is Surgeon)
            {
                Surgeon surgeon = (Surgeon)doctor;
                info += $"|{surgeon.Surgeries}";
            }

            using (StreamWriter sw = File.AppendText("StaffData.txt"))
            {
                sw.WriteLine(info);
            }

            MessageBox.Show("You entered data successfully");
        }

        public List<string> GetDoctorRecords()
        {
            List<string> records = new List<string>();

            using (StreamReader sr = new StreamReader("StaffData.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    records.Add(line);
                }
            }

            return records;
        }

        public void FilterData()
        {
            List<string> surgeons = new List<string>();
            List<string> pediatricians = new List<string>();

            using (StreamReader sr = new StreamReader("StaffData.txt", false))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] fields = line.Split('|');

                    string doctorSpecialty = fields[0];
                    int experience = int.Parse(fields[3]);

                    if (doctorSpecialty == "Surgeon" && experience > 5 && fields.Length > 5)
                    {
                        int surgeries;

                        if (int.TryParse(fields[5], out surgeries) && surgeries > 1000)
                        {
                            string info = $"Doctor's Specialty:   {doctorSpecialty}\n" +
                                          $"Name: {fields[1]}\n" +
                                          $"Surname: {fields[2]}\n" +
                                          $"Working Experience: {fields[3]} years\n" +
                                          $"Salary In Dollars:  {fields[4]}$\n" +
                                          $"Number Of Performed Operations: {fields[5]}\n";

                            surgeons.Add(info);
                        }
                    }
                    else if (doctorSpecialty == "Pediatrician" && fields.Length > 5)
                    {
                        int declaredPatients;

                        if (int.TryParse(fields[5], out declaredPatients) && declaredPatients > 1000)
                        {
                            string info = $"Doctor's Specialty:   {doctorSpecialty}\n" +
                                 $"Name: {fields[1]}\n" +
                                 $"Surname: {fields[2]}\n" +
                                 $"Working Experience: {fields[3]} years\n" +
                                 $"Salary In Dollars:  {fields[4]}$\n" +
                                 $"Number Of Declared Patients: {fields[5]}\n";

                            pediatricians.Add(info);
                        }
                    }
                }
            }

            File.WriteAllLines("SurgeonsData.txt", surgeons);
            File.WriteAllLines("PediatriciansData.txt", pediatricians);
        }
    }
}

