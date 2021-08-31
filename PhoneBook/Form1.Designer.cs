
namespace PhoneBook
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Numer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Szukaj = new System.Windows.Forms.Label();
            this.textNumer = new System.Windows.Forms.TextBox();
            this.textImięNaz = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textSzukaj = new System.Windows.Forms.TextBox();
            this.textAdres = new System.Windows.Forms.TextBox();
            this.Dodaj = new System.Windows.Forms.Button();
            this.Anuluj = new System.Windows.Forms.Button();
            this.Edytuj = new System.Windows.Forms.Button();
            this.Zapisz = new System.Windows.Forms.Button();
            this.phoneBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new PhoneBook.AppData();
            this.numerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imięNazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numerDataGridViewTextBoxColumn,
            this.imięNazwiskoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.phoneBookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(62, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.AllowUserToAddRowsChanged += new System.EventHandler(this.dataGridView1_AllowUserToAddRowsChanged);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textAdres);
            this.panel1.Controls.Add(this.textEmail);
            this.panel1.Controls.Add(this.textImięNaz);
            this.panel1.Controls.Add(this.textNumer);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Numer);
            this.panel1.Location = new System.Drawing.Point(62, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 161);
            this.panel1.TabIndex = 1;
            // 
            // Numer
            // 
            this.Numer.AutoSize = true;
            this.Numer.Location = new System.Drawing.Point(45, 17);
            this.Numer.Name = "Numer";
            this.Numer.Size = new System.Drawing.Size(38, 13);
            this.Numer.TabIndex = 0;
            this.Numer.Text = "Numer";
            this.Numer.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Imię i Nazwisko";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres";
            // 
            // Szukaj
            // 
            this.Szukaj.AutoSize = true;
            this.Szukaj.Location = new System.Drawing.Point(186, 207);
            this.Szukaj.Name = "Szukaj";
            this.Szukaj.Size = new System.Drawing.Size(39, 13);
            this.Szukaj.TabIndex = 4;
            this.Szukaj.Text = "Szukaj";
            // 
            // textNumer
            // 
            this.textNumer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookBindingSource, "Numer", true));
            this.textNumer.Location = new System.Drawing.Point(172, 14);
            this.textNumer.Name = "textNumer";
            this.textNumer.Size = new System.Drawing.Size(131, 20);
            this.textNumer.TabIndex = 4;
            // 
            // textImięNaz
            // 
            this.textImięNaz.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookBindingSource, "Imię_Nazwisko", true));
            this.textImięNaz.Location = new System.Drawing.Point(172, 43);
            this.textImięNaz.Name = "textImięNaz";
            this.textImięNaz.Size = new System.Drawing.Size(152, 20);
            this.textImięNaz.TabIndex = 5;
            // 
            // textEmail
            // 
            this.textEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookBindingSource, "Email", true));
            this.textEmail.Location = new System.Drawing.Point(172, 69);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(251, 20);
            this.textEmail.TabIndex = 6;
            // 
            // textSzukaj
            // 
            this.textSzukaj.Location = new System.Drawing.Point(271, 204);
            this.textSzukaj.Name = "textSzukaj";
            this.textSzukaj.Size = new System.Drawing.Size(317, 20);
            this.textSzukaj.TabIndex = 7;
            this.textSzukaj.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textSzukaj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textAdres
            // 
            this.textAdres.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookBindingSource, "Adres", true));
            this.textAdres.Location = new System.Drawing.Point(172, 97);
            this.textAdres.Multiline = true;
            this.textAdres.Name = "textAdres";
            this.textAdres.Size = new System.Drawing.Size(350, 53);
            this.textAdres.TabIndex = 7;
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(100, 415);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(75, 23);
            this.Dodaj.TabIndex = 8;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // Anuluj
            // 
            this.Anuluj.Location = new System.Drawing.Point(271, 415);
            this.Anuluj.Name = "Anuluj";
            this.Anuluj.Size = new System.Drawing.Size(75, 23);
            this.Anuluj.TabIndex = 9;
            this.Anuluj.Text = "Anuluj";
            this.Anuluj.UseVisualStyleBackColor = true;
            this.Anuluj.Click += new System.EventHandler(this.Anuluj_Click);
            // 
            // Edytuj
            // 
            this.Edytuj.Location = new System.Drawing.Point(449, 415);
            this.Edytuj.Name = "Edytuj";
            this.Edytuj.Size = new System.Drawing.Size(75, 23);
            this.Edytuj.TabIndex = 10;
            this.Edytuj.Text = "Edytuj";
            this.Edytuj.UseVisualStyleBackColor = true;
            this.Edytuj.Click += new System.EventHandler(this.Edytuj_Click);
            // 
            // Zapisz
            // 
            this.Zapisz.Location = new System.Drawing.Point(613, 415);
            this.Zapisz.Name = "Zapisz";
            this.Zapisz.Size = new System.Drawing.Size(75, 23);
            this.Zapisz.TabIndex = 11;
            this.Zapisz.Text = "Zapisz";
            this.Zapisz.UseVisualStyleBackColor = true;
            this.Zapisz.Click += new System.EventHandler(this.Zapisz_Click);
            // 
            // phoneBookBindingSource
            // 
            this.phoneBookBindingSource.DataMember = "PhoneBook";
            this.phoneBookBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numerDataGridViewTextBoxColumn
            // 
            this.numerDataGridViewTextBoxColumn.DataPropertyName = "Numer";
            this.numerDataGridViewTextBoxColumn.HeaderText = "Numer";
            this.numerDataGridViewTextBoxColumn.Name = "numerDataGridViewTextBoxColumn";
            this.numerDataGridViewTextBoxColumn.Width = 120;
            // 
            // imięNazwiskoDataGridViewTextBoxColumn
            // 
            this.imięNazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Imię_Nazwisko";
            this.imięNazwiskoDataGridViewTextBoxColumn.HeaderText = "Imię_Nazwisko";
            this.imięNazwiskoDataGridViewTextBoxColumn.Name = "imięNazwiskoDataGridViewTextBoxColumn";
            this.imięNazwiskoDataGridViewTextBoxColumn.Width = 155;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 197;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Zapisz);
            this.Controls.Add(this.Edytuj);
            this.Controls.Add(this.Anuluj);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.textSzukaj);
            this.Controls.Add(this.Szukaj);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "PhoneBook";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Numer;
        private System.Windows.Forms.TextBox textAdres;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textImięNaz;
        private System.Windows.Forms.TextBox textNumer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Szukaj;
        private System.Windows.Forms.TextBox textSzukaj;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button Anuluj;
        private System.Windows.Forms.Button Edytuj;
        private System.Windows.Forms.Button Zapisz;
        private System.Windows.Forms.BindingSource phoneBookBindingSource;
        private AppData appData;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imięNazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}

