using System;
using System.IO;
using System.Windows.Forms;

namespace text_file_to_ui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void btnLoadFile_Click_1(object sender, EventArgs e)
        {   
            UserFileReader userFileReader = new UserFileReader();
            UserParser userParser = new UserParser();
            UserDisplayer userDisplayer = new UserDisplayer();
            User a = new User();
            a=userParser.UserParse(userFileReader.FileOpen());
            txtFullName.Text = userDisplayer.NameFull(a);
            txtYearOfBirth.Text = a.yearOfBirth.ToString();
            txtCity.Text = a.city.ToString();
            txtFaculty.Text = a.faculty.ToString();
            txtRole.Text = a.role.ToString();
            if (a.role == "Student")
            {
                txtRoleDep.Text = a.favoriteCourse.ToString();
                lblRoleDep.Text = "Favorite course:";
            }
            else
            {
                txtRoleDep.Text=a.department.ToString();
                lblRoleDep.Text = "Katedra:";
            }
        }
    }
}
