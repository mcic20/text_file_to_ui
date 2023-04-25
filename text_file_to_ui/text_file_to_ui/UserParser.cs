using System.Linq;

namespace text_file_to_ui
{
    public class UserParser
    {
        public User UserParse(Reader a)
        {
            UserFileReader userFileReader = new UserFileReader();
            User b = new User();
            a = userFileReader.FileOpen();
            b.firstName = a.firstNameString.Skip(4).ToString();
            b.lastName = a.lastNameString.Skip(8).ToString();
            b.yearOfBirth = a.yearOfBirthString.Skip(15).ToString();
            b.city = a.cityString.Skip(13).ToString();
            b.faculty = a.facultyString.Skip(9).ToString();
            b.role = a.roleString.Skip(6).ToString();
           if (a.roleString == "Uloga=student")
            {
                b.favoriteCourse = a.favoriteCourseString.Skip(17).ToString();
                b.department = " ";
            }
            else
            {
                b.department = a.departmentString.Skip(8).ToString();
            }
            b.timesRead = a.pristup.Skip(27).ToString();
            return b;
        }
    }
}
