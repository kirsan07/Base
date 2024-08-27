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
	public partial class Form2 : Form
	{
		private Connection conn2;
		public Form2()
		{
			InitializeComponent();
			conn2 = new Connection();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			var ch = $"update Employers set Surname = '{textBox2.Text}' where id = {textBox1}";
			var ch1 = $"update Employers set Name = '{textBox3.Text}' where id = {textBox1}";
			var ch2 = $"update Employers set Salary = '{textBox4.Text}' where id = {textBox1}";
			var ch3 = $"update Employers set position = '{textBox5.Text}' where id = {textBox1}";
			conn2.Adapter(ch);
			conn2.Adapter(ch1);
			conn2.Adapter(ch2);
			conn2.Adapter(ch3);
		}
	}
}
