
namespace Библиотека_БД
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reader = new System.Windows.Forms.Button();
            this.librarian = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(402, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Читатель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(68, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сотрудник";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(68, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(447, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Добро пожаловать в библиотеку !";
            // 
            // reader
            // 
            this.reader.BackgroundImage = global::Библиотека_БД.Properties.Resources.free_icon_reader_2374041;
            this.reader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reader.Location = new System.Drawing.Point(342, 102);
            this.reader.Name = "reader";
            this.reader.Size = new System.Drawing.Size(211, 259);
            this.reader.TabIndex = 1;
            this.reader.UseVisualStyleBackColor = true;
            this.reader.Click += new System.EventHandler(this.reader_Click);
            // 
            // librarian
            // 
            this.librarian.BackColor = System.Drawing.SystemColors.Control;
            this.librarian.BackgroundImage = global::Библиотека_БД.Properties.Resources.librarian;
            this.librarian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.librarian.Location = new System.Drawing.Point(23, 102);
            this.librarian.Name = "librarian";
            this.librarian.Size = new System.Drawing.Size(211, 259);
            this.librarian.TabIndex = 0;
            this.librarian.UseVisualStyleBackColor = false;
            this.librarian.Click += new System.EventHandler(this.librarian_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 401);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reader);
            this.Controls.Add(this.librarian);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button librarian;
        private System.Windows.Forms.Button reader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}