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
         public Reader FileOpen() {
            OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text Documents|*.txt";
                ofd.Multiselect = false ;
            Reader a = new Reader();
            if (ofd.ShowDialog() == DialogResult.OK)
                   {
                      using (StreamReader sr = new StreamReader(ofd.FileName))
                       {
                           var lines = sr.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                           foreach (var line in lines)
                           {
                            
                           }
                        }
                    }
            return a;
            }
    }
}
