using System;
using System.IO;
using System.Windows.Forms;

namespace text_file_to_ui
{

    public class UserFileReader
    {
        public Reader FileOpen()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Documents|*.txt";
            ofd.Multiselect = false;
            Reader a = new Reader();
            ofd.ShowDialog();
            if (ofd.FileName == "")
            {
                return null;
            }
            else
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                var lines = sr.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                foreach (var line in lines)
                {
                    if (line.Contains("Ime"))
                    {
                        a.firstNameString = line;
                    }
                    if (line.Contains("Prezime"))
                    {
                        a.lastNameString = line;
                    }
                    if (line.Contains("Godina"))
                    {
                        a.yearOfBirthString = line;
                    }
                    if (line.Contains("Grad"))
                    {
                        a.cityString = line;
                    }
                    if (line.Contains("Fakultet"))
                    {
                        a.facultyString = line;
                    }
                    if (line.Contains("Uloga"))
                    {
                        a.roleString = line;
                    }
                    if (line.Contains("kolegij"))
                    {
                        a.favoriteCourseString = line;
                    }
                    if (line.Contains("Katedra"))
                    {
                        a.departmentString = line;
                    }
                    if (line.Contains("Datoteci"))
                    {
                        a.pristup = line;
                    }
                }
                return a;
            }
        }
    }
}
