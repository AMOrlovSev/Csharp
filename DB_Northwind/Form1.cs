using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace DB_Northwind
{
    public partial class Form1 : Form
    {
        //Классы для переключения доступности элементов win form
        private void notAvailable()
        {
            tbLogin.ReadOnly = false;
            tbPassword.ReadOnly = false;
            bConnect.Enabled = true;
            bDisconnect.Enabled = false;
            rbCategories.Enabled = false;
            rbCustomers.Enabled = false;
            rbEmployees.Enabled = false;
            bTableView.Enabled = false;
            bTableUpdate.Enabled = false;
        }
        private void Available()
        {
            tbLogin.ReadOnly = true;
            tbPassword.ReadOnly = true;
            bConnect.Enabled = false;
            bDisconnect.Enabled = true;
            rbCategories.Enabled = true;
            rbCustomers.Enabled = true;
            rbEmployees.Enabled = true;
            bTableView.Enabled = true;
            bTableUpdate.Enabled = true;
        }

        public Form1()
        {
            InitializeComponent();
            rbCategories.Checked = true;

            notAvailable();
        }

        // подключение

        SqlConnection cnNorthwind = new SqlConnection();

        private void bConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (cnNorthwind.State != ConnectionState.Open)
                {
                    string connectionString = string.Format($"Server = (local); Database=Northwind;User Id = {tbLogin.Text}; Password={tbPassword.Text}");
                    cnNorthwind.ConnectionString = connectionString;
                    cnNorthwind.Open();
                    MessageBox.Show("Соединение с базой данных выполнено успешно");

                    Available();
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с базой данных");
            }
        }

        private void bDisconnect_Click(object sender, EventArgs e)
        {
            if (cnNorthwind.State == ConnectionState.Open)
            {
                cnNorthwind.Close();
                MessageBox.Show("Соединение с базой данных закрыто");
                notAvailable();
                dataGridView1.DataSource = null;
            }
            else
                MessageBox.Show("Соединение с базой данных уже закрыто");
        }

        // заполнение DataTable в зависимости от указанного radiobutton

        DataTable dtCategories = new DataTable();
        DataTable dtCustomers = new DataTable();
        DataTable dtEmployees = new DataTable();
        private void bTableView_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            if (rbCategories.Checked)
            {
                dtCategories.Rows.Clear();
                daCategories.Fill(dtCategories);
                dataGridView1.DataSource = dtCategories;
            }
            else if (rbCustomers.Checked)
            {
                dtCustomers.Rows.Clear();
                daCustomers.Fill(dtCustomers);
                dataGridView1.DataSource = dtCustomers;
            }
            else if (rbEmployees.Checked)
            {
                dtEmployees.Rows.Clear();
                daEmployees.Fill(dtEmployees);
                dataGridView1.DataSource = dtEmployees;
            }
        }

        // отображение и редактирование в DataGrid

        private void bTableUpdate_Click(object sender, EventArgs e)
        {
            if (rbCategories.Checked)
            {
                daCategories.Update(dtCategories);
            }
            else if (rbCustomers.Checked)
            {
                daCustomers.Update(dtCustomers);
            }
            else if (rbEmployees.Checked)
            {
                daEmployees.Update(dtEmployees);
            }
            dataGridView1.Refresh();
        }
    }
}
