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
                        a.FirstNameString = line;
                    }
                    if (line.Contains("Prezime"))
                    {
                        a.LastNameString = line;
                    }
                    if (line.Contains("Godina"))
                    {
                        a.YearOfBirthString = line;
                    }
                    if (line.Contains("Grad"))
                    {
                        a.CityString = line;
                    }
                    if (line.Contains("Fakultet"))
                    {
                        a.FacultyString = line;
                    }
                    if (line.Contains("Uloga"))
                    {
                        a.RoleString = line;
                    }
                    if (line.Contains("kolegij"))
                    {
                        a.FavoriteCourseString = line;
                    }
                    if (line.Contains("Katedra"))
                    {
                        a.DepartmentString = line;
                    }
                    if (line.Contains("Datoteci"))
                    {
                        a.TimesRead = line;
                        sr.Close();
                        string str = File.ReadAllText(ofd.FileName);
                        int broj = int.Parse(a.TimesRead.Substring(27));
                        string str2 = "Datoteci pristupljeno puta="+(broj+1);
                        str = str.Replace(a.TimesRead, str2);
                        File.WriteAllText(ofd.FileName, str);
                    }
                }
                return a;
            }
        }
    }
}
