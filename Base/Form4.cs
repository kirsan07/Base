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
	public partial class Form4 : Form
	{
		private Connection conn2;
		public Form4()
		{
			InitializeComponent();
			conn2 = new Connection();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var ch = $"delete Employers where id = {textBox1}";
			conn2.Adapter(ch);
		}
	}
}
