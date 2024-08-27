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
using System.IO;

namespace Base
{
	class Connection
	{
		/*SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-40I15OP\SQLEXPRESS;Initial Catalog=Base; Integrated Security=True");
		public void openConnection()
		{
			if (connection.State == System.Data.ConnectionState.Closed)
			{ 
				connection.Open();
			}
		}
		public void closeConnection() 
		{
			if (connection.State == System.Data.ConnectionState.Open)
			{
				connection.Close();
			}
		}
		public SqlConnection getConnection() 
		{
		return connection;
		}*/
		/*Form1 mainForm;
		private string connectionString;
		SqlConnection connection;
		SqlDataAdapter adapter;     //Вытягивает результаты запросов из Базы, и сохраняет их в DataSet
		DataSet set;
		SqlCommandBuilder builder;
		public System.Windows.Forms.ComboBox CBDirection { get => cbDirection; }
		public System.Windows.Forms.ComboBox CBLearningForm { get => cbLearningForm; }
		public System.Windows.Forms.ComboBox CBLearningTime { get => cbTime; }
		string[] week = new string[] { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
		CheckBox[] cbWeek;*/
		public string connection = @"Data Source=DESKTOP-40I15OP\SQLEXPRESS;Initial Catalog=Base; Integrated Security=True";
		public DataTable GetData(string str, DataGridView grid)
		{
			try
			{
				using (SqlConnection mycon = new SqlConnection(connection))
				{
					mycon.Open();
					if(mycon.State != ConnectionState.Open)
					{
						MessageBox.Show($"Не удалось подключиться к серверу!:", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return null;
					}
					using (SqlDataAdapter mydata = new SqlDataAdapter(str, mycon))
					{ 
					DataTable dt = new DataTable();
						mydata.Fill(dt);
						grid.DataSource = dt;
						return dt;
					}
				}
			}
			catch (SqlException exception)
			{
				MessageBox.Show($"Ошибка при выполнении запроса: {exception.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}
		public SqlDataAdapter Adapter(string str)
		{
			try
			{
				SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-40I15OP\SQLEXPRESS;Initial Catalog=Base; Integrated Security=True");
				con.Open();
				SqlDataAdapter adapt = new SqlDataAdapter(str, con);
				adapt.SelectCommand.ExecuteNonQuery();
				MessageBox.Show("Действие выполнено,", "успех.");
				return adapt;
			}
			catch
			{
				MessageBox.Show("Ошибка при выполнении запроса.","Ошибка.");
				return null;
			}
		}

	}
}
