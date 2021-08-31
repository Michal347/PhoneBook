using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static AppData db;
        protected static AppData App
        {
            get
            {
                if (db == null)
                    db = new AppData();
                return db;

            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                App.PhoneBook.AddPhoneBookRow(App.PhoneBook.NewPhoneBookRow());
                phoneBookBindingSource.MoveLast();
                textNumer.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                App.PhoneBook.RejectChanges();

            }
        }

        private void Anuluj_Click(object sender, EventArgs e)
        {
            phoneBookBindingSource.ResetBindings(false);
            panel1.Enabled = false;
        }

        private void Edytuj_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            textNumer.Focus();
        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            try
            {
                phoneBookBindingSource.EndEdit();
                App.PhoneBook.AcceptChanges();
                App.PhoneBook.WriteXml(string.Format("{0}//data.dat", Application.StartupPath));
                panel1.Enabled = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                App.PhoneBook.RejectChanges();

            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!string.IsNullOrEmpty(textSzukaj.Text))
                {
                    var query = from o in App.PhoneBook
                                where o.Imię_Nazwisko.Contains(textSzukaj.Text) || o.Email == textSzukaj.Text
                                select o;
                    dataGridView1.DataSource = query.ToList();

                }
                else
                    dataGridView1.DataSource = phoneBookBindingSource;
            }
        }

        private void dataGridView1_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string filename = string.Format("{0}//data.dat", Application.StartupPath);
            if (File.Exists(filename))
                App.PhoneBook.ReadXml(filename);
            phoneBookBindingSource.DataSource = App.PhoneBook;
            panel1.Enabled = false;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }
    }
}
