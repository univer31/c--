using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication32
{
    public partial class 查询 : Form
    {
        int firsttime = 0;
        DataSet ds;
        public 查询()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //// TODO:  这行代码将数据加载到表“assignDataSet3.students”中。您可以根据需要移动或删除它。
            //this.studentsTableAdapter3.Fill(this.assignDataSet3.students);
            //// TODO:  这行代码将数据加载到表“assignDataSet2.students”中。您可以根据需要移动或删除它。
            
            //// TODO:  这行代码将数据加载到表“assignDataSet1.students”中。您可以根据需要移动或删除它。
           
            //// TODO:  这行代码将数据加载到表“assignDataSet.students”中。您可以根据需要移动或删除它。
            //this.studentsTableAdapter1.Fill(this.assignDataSet.students);
            //// TODO:  这行代码将数据加载到表“双选系统DataSet.students”中。您可以根据需要移动或删除它。
           

        }

       

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        //    textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        //    textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        //    textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        //    textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        //   // string data1 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        //   // string data2 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        //   // string data3 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        //   // string data4 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        //   // string data5 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        //   // textBox1.Text = data1;
        //   //textBox2.Text = data2;
        //   //textBox3.Text = data3;
        //   //textBox4.Text = data4; 
        //   //textBox5.Text = data5;
        //}

        private void button7_Click_1(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (firsttime == 0)
            {
                firsttime = 1;
                getData();
            }

            if (textBox6.Text == " ")
            {
                if (ds.Tables[0].DefaultView.Count != 0)
                    dataGridView1.Visible = true;
            }

            ds.Tables[0].DefaultView.RowFilter = "学生小组 like'" + textBox6.Text.Trim() + "%'";

            if (ds.Tables[0].DefaultView.Count != 0)
            {
                dataGridView1.Visible = true;
                dataGridView1.CurrentCell = dataGridView1[0, 0];
            }
            else
                dataGridView1.Visible = false;
        }

        private void getData()
        {
            SqlConnection conn = new SqlConnection(Connect.getconStr());
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select top 100 学生小组 as '学生小组',年级 as '年级',专业 as '专业',学院 as '学院', 课题信息 as '课题信息' from students", conn);
                ds = new DataSet();
                da.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error!" + ex.ToString());
                Application.Exit();
            }
            finally
            {
                conn.Close();
            }
        }
        //private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    this.textBox6.Text = this.dataGridView1.CurrentCell.Value.ToString();
        //    this.dataGridView1.Visible = false;
        //}

        //private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        this.textBox1.Text = this.dataGridView1.CurrentCell.Value.ToString();
        //        this.dataGridView1.Visible = false;
        //    }
        //}

        //private void textBox6_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Down)
        //    {
        //        if (dataGridView1.Rows.Count == 0)
        //            return;

        //        dataGridView1.Focus();
        //        if (dataGridView1.CurrentRow.Index + 1 < dataGridView1.Rows.Count)
        //        {
        //            dataGridView1.CurrentCell = dataGridView1[0, dataGridView1.CurrentRow.Index + 1];
        //        }
        //    }

        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        this.textBox6.Text = this.dataGridView1.CurrentCell.Value.ToString();
        //        this.dataGridView1.Visible = false;
        //    }
        //}

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }



    }
}
