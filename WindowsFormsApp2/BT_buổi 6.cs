using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("new col 0", "Tên món nước");
            dataGridView1.Columns.Add("new col 1", "Số lượng");
            dataGridView1.Columns.Add("new col 2", "Đơn giá");
            dataGridView1.Columns.Add("new col 3", "Thành Tiền");
           // dataGridView1.Columns[1].CellType
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 120;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox4.Visible = !groupBox3.Visible;
            groupBox5.Visible = !groupBox3.Visible;
            groupBox6.Visible = !groupBox3.Visible;
            groupBox7.Visible = !groupBox3.Visible;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            groupBox3.Visible = !groupBox4.Visible;
            groupBox5.Visible = !groupBox4.Visible;
            groupBox6.Visible = !groupBox4.Visible;
            groupBox7.Visible = !groupBox4.Visible;
            // groupBox4.Visible = false;
        }

        private void groupBox4_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            makebill(button17.Text.ToString(), 35000);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            groupBox3.Visible = !groupBox5.Visible;
            groupBox4.Visible = !groupBox5.Visible;
            groupBox6.Visible = !groupBox5.Visible;
            groupBox7.Visible = !groupBox5.Visible;
            //textBox1.Text = "khoa pham";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // textBox1.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void makebill(string name, int cost)
        {
            int temp = 1;
            int row_index = -1;
            if (dataGridView1.Rows.Count > 1)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Index == dataGridView1.Rows.Count - 1)
                    {
                        break;
                    }
                    else
                    {
                        if (row.Cells[0].Value.ToString().Equals(name))
                        {
                            row_index = row.Index;
                            temp = Int32.Parse(row.Cells[1].Value.ToString()) + temp;
                            break;
                        }
                    }
                }

            }
            //Console.WriteLine(dataGridView1.Rows.Count);
           
            if (row_index >= 0)
            {
                dataGridView1.Rows[row_index].Cells[1].Value = temp;
                dataGridView1.Rows[row_index].Cells[3].Value = cost * temp;
            }
            else
            {
                dataGridView1.Rows.Add(name, 1, cost, cost);
            }
        }
        private void button22_Click(object sender, EventArgs e)
        {
            makebill(button22.Text.ToString(),39000);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            makebill(button23.Text.ToString(),39000);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            makebill(button24.Text.ToString(),39000);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            makebill(button25.Text.ToString(),39000);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            makebill(button26.Text.ToString(), 39000);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            makebill(button27.Text.ToString(), 39000);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            float cost = float.Parse(textBox1.Text.ToString());
            float discount = float.Parse(textBox2.Text.ToString());
            cost = cost * (100 - discount) / 100;
            textBox3.Text = cost.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            makebill(button16.Text.ToString(), 35000);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            makebill(button18.Text.ToString(), 35000);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            makebill(button19.Text.ToString(), 35000);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            makebill(button20.Text.ToString(), 35000);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            makebill(button21.Text.ToString(), 35000);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            makebill(button6.Text.ToString(), 30000);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            makebill(button7.Text.ToString(), 30000);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            makebill(button8.Text.ToString(), 30000);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            makebill(button9.Text.ToString(), 30000);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            makebill(button10.Text.ToString(), 30000);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            makebill(button11.Text.ToString(), 30000);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            makebill(button12.Text.ToString(), 30000);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            makebill(button13.Text.ToString(), 30000);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            makebill(button14.Text.ToString(), 30000);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            makebill(button15.Text.ToString(), 30000);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox6.Visible = true;
            groupBox3.Visible = !groupBox6.Visible;
            groupBox4.Visible = !groupBox6.Visible;
            groupBox5.Visible = !groupBox6.Visible;
            groupBox7.Visible = !groupBox6.Visible;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            makebill(button28.Text.ToString(), 25000);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            makebill(button29.Text.ToString(), 25000);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            makebill(button30.Text.ToString(), 25000);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            makebill(button31.Text.ToString(), 25000);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox7.Visible = true;
            groupBox3.Visible = !groupBox7.Visible;
            groupBox4.Visible = !groupBox7.Visible;
            groupBox5.Visible = !groupBox7.Visible;
            groupBox6.Visible = !groupBox7.Visible;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            makebill(button32.Text.ToString(), 5000);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            makebill(button33.Text.ToString(), 5000);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            makebill(button34.Text.ToString(), 5000);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            makebill(button35.Text.ToString(), 5000);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            makebill(button36.Text.ToString(), 5000);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            makebill(button37.Text.ToString(), 5000);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }

            textBox1.Text = sum.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
