using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Configuration;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace Base
{
	/*enum RoWState
	{ 
	Existed,
	New,
	Modified,
	ModifiedNew,
	Deleted
	}*/
	public partial class Form1 : Form
	{
		private Connection conn;
		public Form1()
		{
			InitializeComponent();
			conn = new Connection();	
		}
		private void search_button_Click(object sender, EventArgs e)
		{

		}
		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		private void button3_Click(object sender, EventArgs e)
		{
			Form2 form = new Form2();
			form.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form4 form = new Form4();
			form.ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form3 form = new Form3();
			form.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			string str = "select * from dbo.Employers";
			if (conn.GetData(str, guna2DataGridView1) != null)
			{
				MessageBox.Show($"Запрос выполнен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
