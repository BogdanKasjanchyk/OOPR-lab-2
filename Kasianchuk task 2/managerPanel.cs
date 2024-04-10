using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasianchuk_task_2
{
    public partial class managerPanel : Form
    {
        public managerPanel()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("RegisteredVisitors.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
            }
        }
    }
}
