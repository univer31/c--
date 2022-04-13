using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using Pages;
namespace WindowsFormsApplication32
{
    public partial class 结果显示 : Form
    {
        public 结果显示()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "server=DESKTOP-CHKORO1\\SQLEXPRESS;uid=sa;pwd=14778522508g;database=assign";
                conn.Open();
                using (SqlCommand command = conn.CreateCommand())
                {
                    command.CommandText = "select * from gog";
                    SqlDataAdapter da = new SqlDataAdapter(command);

                    try
                    {
                        da.Fill(ds);
                    }
                    catch
                    { }
                }
            }

            DataTable dt = new DataTable();
            dt = ds.Tables[0].Copy();

            this.dataGridView1.DataSource = dt;  //绑定到datagridview中显示
        }
        //调用GridPrinter
        private void 结果显示_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridView[] dg = { dataGridView1 };
            DataGridViewPrint dgp = new DataGridViewPrint(dg);
            dgp.Print();
            //Form1 f = new Form1();
            //f.Show();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

    }
}