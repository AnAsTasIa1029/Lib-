
namespace Библиотека_БД
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Подключение = new System.Windows.Forms.Button();
            this.AddReader = new System.Windows.Forms.Button();
            this.DeleteReader = new System.Windows.Forms.Button();
            this.AddBook = new System.Windows.Forms.Button();
            this.DeleteBook = new System.Windows.Forms.Button();
            this.InformReaders = new System.Windows.Forms.Button();
            this.InformBook = new System.Windows.Forms.Button();
            this.Card = new System.Windows.Forms.Button();
            this.Books = new System.Windows.Forms.Button();
            this.ReadingRoom = new System.Windows.Forms.Button();
            this.ListOfReaders = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.UpdateData = new System.Windows.Forms.Button();
            this.NameBook = new System.Windows.Forms.TextBox();
            this.Room = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.TextBox();
            this.Publisher = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.TextBox();
            this.PublicationYear = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(515, 247);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // Подключение
            // 
            this.Подключение.Location = new System.Drawing.Point(96, 415);
            this.Подключение.Name = "Подключение";
            this.Подключение.Size = new System.Drawing.Size(75, 23);
            this.Подключение.TabIndex = 1;
            this.Подключение.Text = "Подключение";
            this.Подключение.UseVisualStyleBackColor = true;
            this.Подключение.Click += new System.EventHandler(this.Подключение_Click);
            // 
            // AddReader
            // 
            this.AddReader.Location = new System.Drawing.Point(771, 20);
            this.AddReader.Name = "AddReader";
            this.AddReader.Size = new System.Drawing.Size(123, 23);
            this.AddReader.TabIndex = 2;
            this.AddReader.Text = "Добавить чиателя";
            this.AddReader.UseVisualStyleBackColor = true;
            this.AddReader.Click += new System.EventHandler(this.AddReader_Click);
            // 
            // DeleteReader
            // 
            this.DeleteReader.Location = new System.Drawing.Point(642, 20);
            this.DeleteReader.Name = "DeleteReader";
            this.DeleteReader.Size = new System.Drawing.Size(123, 23);
            this.DeleteReader.TabIndex = 3;
            this.DeleteReader.Text = "Удалить читателя";
            this.DeleteReader.UseVisualStyleBackColor = true;
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(771, 49);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(123, 23);
            this.AddBook.TabIndex = 4;
            this.AddBook.Text = "Добавить книгу";
            this.AddBook.UseVisualStyleBackColor = true;
            // 
            // DeleteBook
            // 
            this.DeleteBook.Location = new System.Drawing.Point(643, 49);
            this.DeleteBook.Name = "DeleteBook";
            this.DeleteBook.Size = new System.Drawing.Size(122, 23);
            this.DeleteBook.TabIndex = 5;
            this.DeleteBook.Text = "Убрать книгу";
            this.DeleteBook.UseVisualStyleBackColor = true;
            // 
            // InformReaders
            // 
            this.InformReaders.Location = new System.Drawing.Point(771, 78);
            this.InformReaders.Name = "InformReaders";
            this.InformReaders.Size = new System.Drawing.Size(123, 36);
            this.InformReaders.TabIndex = 6;
            this.InformReaders.Text = "Изменить данные о читателе ";
            this.InformReaders.UseVisualStyleBackColor = true;
            // 
            // InformBook
            // 
            this.InformBook.Location = new System.Drawing.Point(644, 79);
            this.InformBook.Name = "InformBook";
            this.InformBook.Size = new System.Drawing.Size(121, 35);
            this.InformBook.TabIndex = 7;
            this.InformBook.Text = "Изменить данные о книге";
            this.InformBook.UseVisualStyleBackColor = true;
            // 
            // Card
            // 
            this.Card.Location = new System.Drawing.Point(771, 129);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(123, 35);
            this.Card.TabIndex = 8;
            this.Card.Text = "Посмотреть карты выдачи книг";
            this.Card.UseVisualStyleBackColor = true;
            this.Card.Click += new System.EventHandler(this.Card_Click);
            // 
            // Books
            // 
            this.Books.Location = new System.Drawing.Point(644, 135);
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(123, 23);
            this.Books.TabIndex = 9;
            this.Books.Text = "Просмотреть книги";
            this.Books.UseVisualStyleBackColor = true;
            this.Books.Click += new System.EventHandler(this.Books_Click);
            // 
            // ReadingRoom
            // 
            this.ReadingRoom.Location = new System.Drawing.Point(773, 170);
            this.ReadingRoom.Name = "ReadingRoom";
            this.ReadingRoom.Size = new System.Drawing.Size(121, 23);
            this.ReadingRoom.TabIndex = 10;
            this.ReadingRoom.Text = "Читальный зал ";
            this.ReadingRoom.UseVisualStyleBackColor = true;
            this.ReadingRoom.Click += new System.EventHandler(this.ReadingRoom_Click);
            // 
            // ListOfReaders
            // 
            this.ListOfReaders.Location = new System.Drawing.Point(644, 170);
            this.ListOfReaders.Name = "ListOfReaders";
            this.ListOfReaders.Size = new System.Drawing.Size(121, 23);
            this.ListOfReaders.TabIndex = 12;
            this.ListOfReaders.Text = "Список читателей";
            this.ListOfReaders.UseVisualStyleBackColor = true;
            this.ListOfReaders.Click += new System.EventHandler(this.ListOfReaders_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(13, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // UpdateData
            // 
            this.UpdateData.Location = new System.Drawing.Point(200, 415);
            this.UpdateData.Name = "UpdateData";
            this.UpdateData.Size = new System.Drawing.Size(117, 23);
            this.UpdateData.TabIndex = 14;
            this.UpdateData.Text = "Обновить данные";
            this.UpdateData.UseVisualStyleBackColor = true;
            this.UpdateData.Click += new System.EventHandler(this.UpdateData_Click);
            // 
            // NameBook
            // 
            this.NameBook.Location = new System.Drawing.Point(72, 283);
            this.NameBook.Multiline = true;
            this.NameBook.Name = "NameBook";
            this.NameBook.Size = new System.Drawing.Size(150, 24);
            this.NameBook.TabIndex = 15;
            // 
            // Room
            // 
            this.Room.Location = new System.Drawing.Point(72, 326);
            this.Room.Multiline = true;
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(150, 20);
            this.Room.TabIndex = 16;
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(215, 362);
            this.Number.Multiline = true;
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(61, 20);
            this.Number.TabIndex = 17;
            // 
            // Publisher
            // 
            this.Publisher.Location = new System.Drawing.Point(312, 326);
            this.Publisher.Multiline = true;
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(142, 20);
            this.Publisher.TabIndex = 18;
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(293, 283);
            this.Author.Multiline = true;
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(142, 24);
            this.Author.TabIndex = 19;
            // 
            // PublicationYear
            // 
            this.PublicationYear.Location = new System.Drawing.Point(377, 365);
            this.PublicationYear.Name = "PublicationYear";
            this.PublicationYear.Size = new System.Drawing.Size(58, 20);
            this.PublicationYear.TabIndex = 20;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(72, 362);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(56, 20);
            this.ID.TabIndex = 21;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(740, 352);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(154, 20);
            this.textBox8.TabIndex = 28;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(740, 326);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(154, 20);
            this.textBox9.TabIndex = 27;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(740, 289);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(154, 20);
            this.textBox10.TabIndex = 26;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(509, 378);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(183, 20);
            this.textBox11.TabIndex = 25;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(509, 352);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(183, 20);
            this.textBox12.TabIndex = 24;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(509, 326);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(183, 20);
            this.textBox13.TabIndex = 23;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(509, 289);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(183, 20);
            this.textBox14.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 40);
            this.label1.TabIndex = 29;
            this.label1.Text = "Название книги";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Издательство";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Автор";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(312, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 26);
            this.label4.TabIndex = 32;
            this.label4.Text = "Год издания";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Количество";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(-1, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 26);
            this.label6.TabIndex = 34;
            this.label6.Text = "Читальный зал";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.PublicationYear);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Publisher);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Room);
            this.Controls.Add(this.NameBook);
            this.Controls.Add(this.UpdateData);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ListOfReaders);
            this.Controls.Add(this.ReadingRoom);
            this.Controls.Add(this.Books);
            this.Controls.Add(this.Card);
            this.Controls.Add(this.InformBook);
            this.Controls.Add(this.InformReaders);
            this.Controls.Add(this.DeleteBook);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.DeleteReader);
            this.Controls.Add(this.AddReader);
            this.Controls.Add(this.Подключение);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Подключение;
        private System.Windows.Forms.Button AddReader;
        private System.Windows.Forms.Button DeleteReader;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Button DeleteBook;
        private System.Windows.Forms.Button InformReaders;
        private System.Windows.Forms.Button InformBook;
        private System.Windows.Forms.Button Card;
        private System.Windows.Forms.Button Books;
        private System.Windows.Forms.Button ReadingRoom;
        private System.Windows.Forms.Button ListOfReaders;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button UpdateData;
        private System.Windows.Forms.TextBox NameBook;
        private System.Windows.Forms.TextBox Room;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.TextBox Publisher;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.TextBox PublicationYear;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

