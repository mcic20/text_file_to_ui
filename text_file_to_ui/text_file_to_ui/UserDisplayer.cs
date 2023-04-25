namespace text_file_to_ui
{
    public class UserDisplayer
    {
        public string NameFull(User a)
        {
            if (a != null)
            {
                string fullName = a.firstName + " " + a.lastName;
                return fullName;
            }
            else return null;
        }
    }
}

