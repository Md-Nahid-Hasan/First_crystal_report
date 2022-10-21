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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Name", Type.GetType("System.String"));
            dt.Columns.Add("Address", Type.GetType("System.String"));
            dt.Columns.Add("Mobile", Type.GetType("System.String"));
            dt.Columns.Add("Telephone", Type.GetType("System.String"));
            dt.Columns.Add("E_mail", Type.GetType("System.String"));
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();

            dt2.Columns.Add("Name", Type.GetType("System.String"));
            dt2.Columns.Add("Address", Type.GetType("System.String"));
            dt2.Columns.Add("Mobile", Type.GetType("System.String"));
            dt2.Columns.Add("Telephone", Type.GetType("System.String"));
            dt2.Columns.Add("E_mail", Type.GetType("System.String"));

            foreach (DataGridViewRow row in dataGridView1.Rows)
                dt2.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value);
            CrystalReport1 report = new CrystalReport1();
            report.SetDataSource(dt2);
            Form2.getform2.Show();
            Form2.getform2.crystalReportViewer1.ReportSource = report;
        }
    }
}
