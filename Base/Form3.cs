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
	public partial class Form3 : Form
	{
		private Connection conn;
		public Form3()
		{
			conn = new Connection();
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var a = $"insert into Employers (Surname, Name, Salary, position) values('{textBox1}','{textBox2}','{textBox3}','{textBox4}')";
			conn.Adapter(a);
		}
	}
}
