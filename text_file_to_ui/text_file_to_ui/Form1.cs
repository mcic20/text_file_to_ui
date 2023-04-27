using System;
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
            UserParser userParser = new UserParser();
            UserDisplayer userDisplayer = new UserDisplayer();
            _ = new User();
            Reader reader = new Reader();
            User a = new User();
            try
            {
                a = userParser.UserParse(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsupported file format.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                a = null;
            }
            if (a != null)
            {
                txtFullName.Text = userDisplayer.NameFull(a);
                txtYearOfBirth.Text = a.YearOfBirth.ToString();
                txtCity.Text = a.City.ToString();
                txtFaculty.Text = a.Faculty.ToString();
                txtRole.Text = a.Role.ToString();
                lblTimesOpenedNum.Text = a.TimesRead.ToString();
                if (a.Role == "student")
                {
                    txtRoleDep.Text = a.FavoriteCourse.ToString();
                    lblRoleDep.Text = "Favorite course:";
                }
                else
                {
                    txtRoleDep.Text = a.Department.ToString();
                    lblRoleDep.Text = "Katedra:";
                }
            }
        }

    }
}
