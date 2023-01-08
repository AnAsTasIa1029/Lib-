using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD = System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Библиотека_БД
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public MySqlConnection mycon;
        public MySqlCommand mycom;
        public string connect = "Server = s2.kts.tu-bryansk.ru; Database =o-20-ist-istd_fomichevaaa; port = 3306; username = O-20-IST-ISTD.FomichevaAA; password = Dru%$onN$#P+@%U|;"; //charset=utf8;";
        public SD.DataSet ds;
        public SD.DataTable dt;

        MySqlDataAdapter da;
        public SD.DataSet dataSet ;

        int selectedRow;

       // private void RefreshDataGrid(DataGridView dgw)
      //  {
        //    dgw.Rows.Clear();
         //   string qString = @"select * from `o-20-ist-istd_fomichevaaa`";
       //      MySqlCommand mycom = new MySqlCommand(qString, mycon);
     //       mycon = new MySqlConnection(connect);
     //       mycon.Open();

          //  MySqlDataReader reader = mycom.ExecuteReader();
            //reader.Close();
     //  }
        private void Form1_Load(object sender, EventArgs e)
        {
       //     RefreshDataGrid(dataGridView1);
        }
        //   private void DataBaseLoad(string script, DataGridView dataView)
        //{
        //try
        //{
        //mycon = new MySqlConnection(connstring);
        //con.Open();
        // MySqlDataAdapter ms_data = new MySqlDataAdapter(script, con);
        //SD.DataTable table = new SD.DataTable();
        // ms_data.Fill(table);
        //  dataView.DataSource = table;
        //   con.Close();
        //}
        //catch (MySqlException ex)
        // {
        //       MessageBox.Show(ex.ToString());
        //     }
        //   }

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

        private void Exit_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void AddReader_Click(object sender, EventArgs e)
        {
            // string script = "SELECT count (*) + 2 FROM 'o-20-ist-istd_fomichevaaa'.читатель;";
            // DataBaseLoad(script, dataCount);
            Readers r = new Readers();
            r.Show();
            //this.Hide();
        }

        private void ListOfReaders_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `o-20-ist-istd_fomichevaaa`.читатель", mycon);
                mycon = new MySqlConnection(connect);
                mycon.Open();


                SD.DataSet ds = new SD.DataSet();
                adapter.Fill(ds, "читатель");
                dataGridView1.DataSource = ds.Tables["читатель"];
                mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateData_Click(object sender, EventArgs e)
        {
            // string updateReader = @"update `o-20-ist-istd_fomichevaaa`.читатель set 'ФИО читателя' = '" + FIO.Text + "', 'Логин' = '" + login.Text + "', '" + Password.Text + "', '" + Telefon.Text + "', '" + textBox2.Text + "', '" + Year.Text + "'
            //  Readers r = new Readers();
            //  r.ShowDialog();
            //  this.FIO.Text = r.Data;
            //  this.log
          //  RefreshDataGrid(dataGridView1);

        }

        private void ReadingRoom_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `o-20-ist-istd_fomichevaaa`.читальный_зал", mycon);
                mycon = new MySqlConnection(connect);
                mycon.Open();


                SD.DataSet ds = new SD.DataSet();
                adapter.Fill(ds, "читальный_зал");
                dataGridView1.DataSource = ds.Tables["читальный_зал"];
                mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Books_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `o-20-ist-istd_fomichevaaa`.книги", mycon);
                mycon = new MySqlConnection(connect);
                mycon.Open();


                SD.DataSet ds = new SD.DataSet();
                adapter.Fill(ds, "книги");
                dataGridView1.DataSource = ds.Tables["книги"];
                mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `o-20-ist-istd_fomichevaaa`.карточка_выдачи_книг", mycon);
                mycon = new MySqlConnection(connect);
                mycon.Open();


                SD.DataSet ds = new SD.DataSet();
                adapter.Fill(ds, "карточка_выдачи_книг");
                dataGridView1.DataSource = ds.Tables["карточка_выдачи_книг"];
                mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                NameBook.Text = row.Cells[1].Value.ToString();
                Author.Text = row.Cells[2].Value.ToString();
                Publisher.Text = row.Cells[3].Value.ToString();
                Room.Text = row.Cells[4].Value.ToString();
                Number.Text = row.Cells[5].Value.ToString();
                PublicationYear.Text = row.Cells[6].Value.ToString();
                ID.Text = row.Cells[0].Value.ToString();

            }
        }
    }
    
}