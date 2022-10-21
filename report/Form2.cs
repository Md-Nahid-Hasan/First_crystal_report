using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace report
{
    public partial class Form2 : Form
    {
        private static Form2 frm;
        public static Form2 getform2
        {
            get
            {
                if(frm==null)
                {
                    frm = new Form2();
                }
                return frm;
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
