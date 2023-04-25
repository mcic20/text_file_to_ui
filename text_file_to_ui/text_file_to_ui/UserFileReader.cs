using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text_file_to_ui
{
    public class UserFileReader
    {
        public void FileOpen() {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Text Files|*.txt",
                Multiselect = false
            };
            ofd.ShowDialog();
        }
    }
}
