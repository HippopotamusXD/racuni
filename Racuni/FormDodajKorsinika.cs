using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Racuni
{
    public partial class FormDodajKorsinika : Form
    {
        public FormDodajKorsinika()
        {
            InitializeComponent();
        }

        private void FormDodajKorsinika_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.ImeFirme = textBoxImeFirme.Text;
            MainForm.ImeFirme1 = textBoxImeFirme1.Text;
            MainForm.ImeFirme2 = textBoxImeFirme2.Text;
            MainForm.Adresa = textBoxAdresa.Text;
            MainForm.Mjesto = textBoxMjesto.Text;
            MainForm.PostanskiBroj = textBoxPoštanskiBroj.Text;
            MainForm.oib = textBoxOIB.Text;

            MainForm f = new MainForm();
            f.dodajToolStripMenuItem_Click(null, null);
        }

        private void textBoxImeFirme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxImeFirme.Text != "")
                {
                    textBoxImeFirme1.SelectAll();
                    textBoxImeFirme1.Focus();
                }
            }
        }

        private void textBoxImeFirme1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxImeFirme1.Text != "")
                {
                    textBoxImeFirme2.Focus();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                textBoxImeFirme.SelectAll();
                textBoxImeFirme.Focus();
            }
        }

        private void textBoxImeFirme2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxImeFirme2.Text != "")
                {
                    textBoxAdresa.Focus();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                textBoxImeFirme1.SelectAll();
                textBoxImeFirme1.Focus();
            }
        }

        private void textBoxAdresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxAdresa.Text != "")
                {
                    textBoxMjesto.Focus();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                textBoxImeFirme2.SelectAll();
                textBoxImeFirme2.Focus();
            }
        }

        private void textBoxMjesto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxMjesto.Text != "")
                {
                    textBoxPoštanskiBroj.Focus();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                textBoxAdresa.SelectAll();
                textBoxAdresa.Focus();
            }
        }

        private void textBoxPostanskiBroj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxMjesto.Text != "")
                {
                    textBoxOIB.Focus();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                textBoxMjesto.SelectAll();
                textBoxMjesto.Focus();
            }
        }

        private void textBoxOIB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Escape)
            {
                textBoxPoštanskiBroj.SelectAll();
                textBoxPoštanskiBroj.Focus();
            }
        }
    }
}
