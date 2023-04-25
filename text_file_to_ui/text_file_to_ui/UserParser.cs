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
            if (a != null)
            {
                b.firstName = a.firstNameString.Substring(4);
                b.lastName = a.lastNameString.Substring(8);
                b.yearOfBirth = a.yearOfBirthString.Substring(15);
                b.city = a.cityString.Substring(13);
                b.faculty = a.facultyString.Substring(9);
                b.role = a.roleString.Substring(6);
                if (b.role == "student")
                {
                    b.favoriteCourse = a.favoriteCourseString.Substring(17);
                    b.department = " ";
                }
                else
                {
                    b.department = a.departmentString.Substring(8);
                }
                b.timesRead = a.pristup.Substring(27);
                return b;
            }
            return null;
        }
    }
}
