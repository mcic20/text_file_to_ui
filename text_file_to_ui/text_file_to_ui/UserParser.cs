using System.Windows.Forms;

namespace text_file_to_ui
{
    public class UserParser
    {
        public User UserParse(Reader a)
        {
            UserFileReader userFileReader = new UserFileReader();
            User b = new User();
            a = userFileReader.FileOpen();
            if (a != null)
            {
#if DEBUG
                try
#endif
                {
                    b.FirstName = a.FirstNameString.Substring(4);
                    b.LastName = a.LastNameString.Substring(8);
                    b.YearOfBirth = a.YearOfBirthString.Substring(15);
                    b.City = a.CityString.Substring(13);
                    b.Faculty = a.FacultyString.Substring(9);
                    b.Role = a.RoleString.Substring(6);
                    if (b.Role == "student")
                    {
                        b.FavoriteCourse = a.FavoriteCourseString.Substring(17);
                        b.Department = " ";
                    }
                    else
                    {
                        b.Department = a.DepartmentString.Substring(8);
                    }
                    b.TimesRead = a.TimesRead.Substring(27);
                    return b;
                }
#if DEBUG
                catch
#endif
                {
                    MessageBox.Show("Unsupported file format.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

            }
            else
                return null;
        }
    }
}
