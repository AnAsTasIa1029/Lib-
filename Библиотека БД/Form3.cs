using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Библиотека_БД
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public MySqlConnection mycon;
        public MySqlCommand mycom;
        public string connect = "Server = s2.kts.tu-bryansk.ru; Database =o-20-ist-istd_fomichevaaa; port = 3306; username = O-20-IST-ISTD.FomichevaAA; password = Dru%$onN$#P+@%U|;";
        public DataSet ds;

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        } 
        
        private void Подключение_Click(object sender, EventArgs e)
        {
            try
            {
                mycon = new MySqlConnection(connect);
                mycon.Open();
                MessageBox.Show("Подключенo!");
                mycon.Close();

            }
            catch
            {
                MessageBox.Show("Нет соединения");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `o-20-ist-istd_fomichevaaa`.читальный_зал", mycon);
                mycon = new MySqlConnection(connect);
                mycon.Open();


                DataSet ds = new DataSet();
                adapter.Fill(ds, "читальный_зал");
                dataGridView1.DataSource = ds.Tables["читальный_зал"];
                mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `o-20-ist-istd_fomichevaaa`.книги", mycon);
                mycon = new MySqlConnection(connect);
                mycon.Open();


                DataSet ds = new DataSet();
                adapter.Fill(ds, "книги");
                dataGridView1.DataSource = ds.Tables["книги"];
                mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `o-20-ist-istd_fomichevaaa`.карточка_выдачи_книг", mycon);
                mycon = new MySqlConnection(connect);
                mycon.Open();


                DataSet ds = new DataSet();
                adapter.Fill(ds, "карточка_выдачи_книг");
                dataGridView1.DataSource = ds.Tables["карточка_выдачи_книг"];
              
                mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
