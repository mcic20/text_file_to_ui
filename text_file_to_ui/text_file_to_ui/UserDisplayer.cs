namespace text_file_to_ui
{
    public class UserDisplayer
    {
        public string NameFull(User a)
        {
            string fullName = a.firstName + " " + a.lastName;
            return fullName;
        }
    }
}

