using Affärslager.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_WinForm
{
    public partial class LoggIn : Form
    {
        int anställningsnummer;
        string password;

        Bibliotek Bibliotek { get; set; } = new Bibliotek();

        public LoggIn()
        {
            InitializeComponent();
        }

        private void buttonLoggIn_Click(object sender, EventArgs e)
        {
            if (Bibliotek.LoggIn(anställningsnummer, password))
            {
                BokninngsApp ba = new BokninngsApp(Bibliotek);
                this.Hide();
                ba.Show();
            }
            else
            {
                MessageBox.Show("Inloggningsuppgifter är felaktiga");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            anställningsnummer = int.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }
    }
}
