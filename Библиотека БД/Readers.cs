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
    public partial class Readers : Form
    {
        MySqlConnection mycon = new MySqlConnection("Server = s2.kts.tu-bryansk.ru; Database =o-20-ist-istd_fomichevaaa; port = 3306; username = O-20-IST-ISTD.FomichevaAA; password = Dru%$onN$#P+@%U|;");
        // public MySqlConnection mycon;
        // public string connect = "Server = s2.kts.tu-bryansk.ru; Database =o-20-ist-istd_fomichevaaa; port = 3306; username = O-20-IST-ISTD.FomichevaAA; password = Dru%$onN$#P+@%U|;"; //charset=utf8;";
        private String connectionString = null;
       private DataTable dt;


        FormStartPosition formStart = FormStartPosition.CenterScreen;
        public Readers()
        {
            InitializeComponent();
        }
        private void DataBaseLoad(string script, DataGridView dataView)
        {
            try
            {
                mycon = new MySqlConnection();
                mycon.Open();
                MySqlDataAdapter ms_data = new MySqlDataAdapter("select * from 'o-20-ist-istd_fomichevaaa'", mycon);
                DataTable dt = new DataTable();
                ms_data.Fill(dt);
                dataView.DataSource = dt;
                mycon.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void AddReader_Click(object sender, EventArgs e)

        {  
            if (Id.Text != "" && FIO.Text != "" && login.Text != "" && Password.Text != "" && Telefon.Text != "" && textBox2.Text != "" && Year.Text != "")
            {
              MySqlCommand  cmd = new MySqlCommand ("insert into 'o-20-ist-istd_fomichevaaa'.читатель (ФИО читателя , Логин, Пароль, Номер телефона, Год рождения, Адрес)Values ( @Id, @FIO, @login, @Password, @Telefon, @textBox2, @Year)", mycon) ;
                mycon.Open();
                cmd.Parameters.AddWithValue("@Id", Id.Text);
                cmd.Parameters.AddWithValue("@FIO", FIO.Text);
                cmd.Parameters.AddWithValue("@login", login.Text);
                cmd.Parameters.AddWithValue("@Password", Password.Text);
                cmd.Parameters.AddWithValue("@Telefon", Telefon.Text);
                cmd.Parameters.AddWithValue("@textBox2", textBox2.Text);
                cmd.Parameters.AddWithValue("@Year", Year.Text);
               // cmd.ExecuteNonQuery();
                mycon.Close();
                MessageBox.Show("Читатель добавлен !");
                DataBaseLoad(AddReader, );
              //  PopulateData();
               
                // mycon.Open(); 
            }
            else
            {
                MessageBox.Show("Gвторите попытку");
            }
            // string script = "SELECT count(*)+2 FROM 'o-20-ist-istd_fomichevaaa'.читатель;";
            //    DataBaseLoad(script, dataCount);

            //  string codeTransportation = dataCount.Rows[0].Cel1s[0].Value.Tostring();

            // codeTransportation = codeTransportation.Insert(@, "1")3
            // string scriptAddReader = @"insert into 'o-20-ist-istd_fomichevaaa'.читатель(ФИО читателя , Логин, Пароль, Номер телефона, Год рождения, Адрес)
            //Values ('" + FIO.Text.ToString() + "','" + login.Text.ToString() + "', '" + Password.Text.ToString() + "', '" + Telefon.Text.ToString() + "', '" + textBox2.Text.ToString() + "', '" + Year.Text.ToString() + "')", mycon;

            //  DataBaseLoad(scriptAddReader);

            //   HideltensForAdd();
            // MySqlCommand mycom = new MySqlCommand(@"insert into 'o-20-ist-istd_fomichevaaa'.читатель(ФИО читателя , Логин, Пароль, Номер телефона, Год рождения, Адрес)
            //Values ('"+ FIO.Text.ToString() + "','" + login.Text.ToString ()+ "', '" + Password.Text.ToString() + "', '" + Telefon.Text.ToString() + "', '" + textBox2.Text.ToString() + "', '" + Year.Text.ToString() + "')", mycon) ;
            // mycon = new MySqlConnection(connect);
            //  mycon.Open();
            //  mycom.ExecuteNonQuery();
            // MessageBox.Show("Читатель добавлен !");

            //  mycon.Close();
            //  this.Hide();
        }

        private void DataBaseLoad()
        {
           // throw new NotImplementedException();
        }

        private void PopulateData( )
        {
            //throw new NotImplementedException();
            mycon.Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter ms_data = new MySqlDataAdapter("select * from 'o-20-ist-istd_fomichevaaa'", mycon);
            ms_data.Fill(dt);
            //dataView.DataSource = dt;
            mycon.Close();
        }

        private void PopulateData(DataGridView dataView)
        {
            mycon.Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter ms_data = new MySqlDataAdapter("select * from 'o-20-ist-istd_fomichevaaa'", mycon);
            ms_data.Fill(dt);
            dataView.DataSource = dt;
            mycon.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
           
            this.Hide();
        }
        public string Data
        {
            get
            {
                
                return FIO.Text;
                return login.Text; return Password.Text; return Telefon.Text; return textBox2.Text; return Year.Text;
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (FIO.Text !="" && login.Text != "" && Password.Text !=  "" && Telefon.Text != "" && textBox2.Text != "" && Year.Text!="")
            {
                MySqlCommand cmd = new MySqlCommand ("update  'o-20-ist-istd_fomichevaaa'.читатель set  'ФИО читателя' =@FIO, 'Логнин' = @login,'Пароль'= @Password,'Телефон'= @Telefon, 'Адрес'=@textBox2, 'Год рождения'=@Year were Id = @Id", mycon);

                mycon.Open();
                cmd.Parameters.AddWithValue("@Id", Id.Text);
                cmd.Parameters.AddWithValue("@FIO", FIO.Text);
                cmd.Parameters.AddWithValue("@login", login.Text);
                cmd.Parameters.AddWithValue("@Password", Password.Text);
                cmd.Parameters.AddWithValue("@Telefon", Telefon.Text);
                cmd.Parameters.AddWithValue("@textBox2", textBox2.Text);
                cmd.Parameters.AddWithValue("@Year", Year.Text);


                mycon.Close();
                MessageBox.Show("Список читателей обновился !");
                  DataBaseLoad();
                //PopulateData();
            }
            else
            { 
                MessageBox.Show("Попробуйте снова!");

            }
           
        }
    }
}
