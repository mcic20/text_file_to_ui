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
        string Text;
         public string FileOpen() {
            OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text Documents|*.txt";
                ofd.Multiselect = false ;
                 if (ofd.ShowDialog() == DialogResult.OK)
                   {
                      using (StreamReader sr = new StreamReader(ofd.FileName))
                       {
                        Text = sr.ReadToEnd();
                        return Text;
                        }
                    }
                return Text;
            }
    }
}
