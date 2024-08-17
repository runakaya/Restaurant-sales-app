using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_2023
{
    internal class Siparis : Form
    {
        public void ActivateListBox()
        {

            ListBox listBox1 = new ListBox();
           
            Form form = new Form();
            form.Controls.Add(listBox1);

            form.ShowDialog();


        }

        
        


    }
}
