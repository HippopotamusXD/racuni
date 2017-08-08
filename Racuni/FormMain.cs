using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace Racuni
{
    public partial class MainForm : Form
    {
        public static string ImeFirme = "";
        public static string ImeFirme1 = "";
        public static string ImeFirme2 = "";
        public static string Adresa = "";
        public static string Mjesto = "";
        public static string PostanskiBroj = "";
        public static string oib = "";

        private Int32 id;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ConnectLocalDatabase("Mile.mdb");
            string Sql = "SELECT * FROM Klijenti ORDER BY Id;";

            OleDbDataAdapter dataadapter = new OleDbDataAdapter(Sql, MainConnection);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "Klijenti");
            dgvBaza.DataSource = ds;
            dgvBaza.DataMember = "Klijenti";

            this.rvRacun.RefreshReport();
        }


        OleDbConnection MainConnection = new OleDbConnection();

        private bool ConnectLocalDatabase(string ImeBaze)
        {
            string connetionString = "";
            try
            {
                connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ImeBaze + ";" + "Mode=ReadWrite;";
                MainConnection.ConnectionString = connetionString;
                if (!OpenDatabase())
                {
                    connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ImeBaze + ";" + "Mode=ReadWrite;";
                    MainConnection.ConnectionString = connetionString;
                    if (!OpenDatabase())
                    {
                        return false;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }



            //string Sql = "SELECT * FROM Klijenti ORDER BY Id;";

            //OleDbDataAdapter dataadapter = new OleDbDataAdapter(Sql, MainConnection);
            //DataSet ds = new DataSet();
            //dataadapter.Fill(ds, "Klijenti");
            //dgvBaza.DataSource = ds;
            //dgvBaza.DataMember = "Klijenti";

            return true;
        }

        private bool OpenDatabase()
        {
            try
            {
                MainConnection.Open();
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
        }


        private void dgvBaza_SelectionChanged(object sender, EventArgs e)
        {

            id = Convert.ToInt32(dgvBaza.SelectedRows[0].Cells["Id"].Value);
            RefreshrvPonudu(id);
        }

        private void RefreshrvPonudu(Int32 Id)
        {
            string[,] Par = new string[1, 2]
            {
                {"pDatum",""}
            };
            Par[0, 1] = DateTime.Now.ToString();

            UpdatePonudaParameters(rvRacun, Par);

            this.rvRacun.LocalReport.DataSources.Clear();

            DataTable myData = new DataTable();
            string sqlTemp = "";
            sqlTemp = "SELECT Klijenti.* FROM Klijenti WHERE (((Klijenti.Id)=" + Id.ToString() + "))";
            OleDbCommand cmd = new OleDbCommand(sqlTemp, MainConnection);
            myData.Load(cmd.ExecuteReader());

            DataTable myData1 = new DataTable();
            sqlTemp = "";
            sqlTemp = "SELECT Stavke.* FROM Stavke WHERE (((Stavke.Tip)=0))";
            OleDbCommand cmd1 = new OleDbCommand(sqlTemp, MainConnection);
            myData1.Load(cmd1.ExecuteReader());


            this.rvRacun.LocalReport.DataSources.Add(new ReportDataSource("Racun", myData));
            this.rvRacun.LocalReport.DataSources.Add(new ReportDataSource("Stavke", myData1));
            this.rvRacun.RefreshReport();
            cmd.Dispose();
        }

        private void UpdatePonudaParameters(ReportViewer rv, string[,] Parameters)
        {
            //https://social.msdn.microsoft.com/Forums/en-US/693694bc-bfbc-4786-98ee-a99826e78739/difficulty-setting-reportparameter?forum=vsreportcontrols

            ReportParameter[] p = new ReportParameter[(Parameters.Length / 2)];
            for (int i = 0; i < (Parameters.Length / 2); i++)
            {
                p[i] = new ReportParameter(Parameters[i, 0], Parameters[i, 1]);
            }
            rv.LocalReport.SetParameters(p);
        }


        #region Dodaj

        private void tsmDodaj_Click(object sender, EventArgs e)
        {
            FormDodajKorsinika Form2 = new FormDodajKorsinika();
            Form2.Show();
        }

        private void dodajKorisnika()
        {
            if (MainConnection.State != ConnectionState.Open)
            {
                ConnectLocalDatabase("mile.mdb");
            }
            string sqlInsert = "";
            sqlInsert = "INSERT INTO Klijenti (ImeFirme, ImeFirme1, ImeFirme2, Adresa, Mjesto, PostanskiBroj, OIB) VALUES (\"" + ImeFirme.Replace("\"", "'")
                + "\",\"" + ImeFirme1.Replace("\"", "'") + "\",\"" + ImeFirme2.Replace("\"", "'") + "\",\"" + Adresa.Replace("\"", "'") + "\",\"" + Mjesto.Replace("\"", "'") + "\",\"" + PostanskiBroj.Replace("\"", "'") + "\",\"" +
                oib.Replace("\"", "'") + "\")";

            OleDbCommand cmdInsert = new OleDbCommand(sqlInsert, MainConnection);

            try
            {
                if (ImeFirme != "" && Adresa != "" &&
                    Mjesto != "" && PostanskiBroj != "" && oib != "")
                {
                    cmdInsert.ExecuteNonQuery();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            ImeFirme = "";
            ImeFirme1 = "";
            ImeFirme2 = "";
            Adresa = "";
            Mjesto = "";
            PostanskiBroj = "";
            oib = "";


            string Sql = "SELECT * FROM Klijenti ORDER BY Id;";

            OleDbDataAdapter dataadapter = new OleDbDataAdapter(Sql, MainConnection);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "Klijenti");
            dgvBaza.DataSource = ds;
            dgvBaza.DataMember = "Klijenti";

        }

        public void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dodajKorisnika();
        }

        #endregion


        #region Uredi

        #region Prelazak s jednog text boxa na drugi
        private void textBoxImeFirme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxImeFirme1.Focus();
            }
        }

        private void textBoxImeFirme1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxImeFirme2.Focus();
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
                textBoxAdresa.Focus();
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
                textBoxMjesto.Focus();
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
                textBoxPostanskiBroj.Focus();
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
                textBoxOIB.Focus();
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
                MainForm.ImeFirme = textBoxImeFirme.Text;
                MainForm.ImeFirme1 = textBoxImeFirme1.Text;
                MainForm.ImeFirme2 = textBoxImeFirme2.Text;
                MainForm.Adresa = textBoxAdresa.Text;
                MainForm.Mjesto = textBoxMjesto.Text;
                MainForm.PostanskiBroj = textBoxPostanskiBroj.Text;
                MainForm.oib = textBoxOIB.Text;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                textBoxPostanskiBroj.SelectAll();
                textBoxPostanskiBroj.Focus();
            }
        }
        #endregion

        private void tsmUredi_Click(object sender, EventArgs e)
        {
            panelUredi.Visible = true;

            textBoxID.Text = "";
            textBoxImeFirme.Text = "";
            textBoxImeFirme1.Text = "";
            textBoxImeFirme2.Text = "";
            textBoxAdresa.Text = "";
            textBoxMjesto.Text = "";
            textBoxPostanskiBroj.Text = "";
            textBoxOIB.Text = "";

            textBoxID.Text = id.ToString();
        }

        private void buttonZavrsi_Click(object sender, EventArgs e)
        {
            if (MainConnection.State != ConnectionState.Open)
            {
                ConnectLocalDatabase("Mile.mdb");
            }
            string sqlEdit = "";
            sqlEdit = "UPDATE Klijenti SET ImeFirme = " + textBoxImeFirme.Text.Replace("\"", "'")
                                        + "ImeFirme1 = " + textBoxImeFirme1.Text.Replace("\"", "'")
                                        + "ImeFirme2 = " + textBoxImeFirme2.Text.Replace("\"", "'")
                                        + "Adresa = " + textBoxAdresa.Text.Replace("\"", "'")
                                        + "Mjesto = " + textBoxMjesto.Text.Replace("\"", "'")
                                        + "PostanskiBroj = " + textBoxPostanskiBroj.Text.Replace("\"", "'")
                                        + "OIB = " + textBoxOIB.Text.Replace("\"", "'") + " WHERE Klijenti.Id = " + textBoxID.Text.ToString();


            try
            {
                OleDbCommand cmdEdit = new OleDbCommand(sqlEdit, MainConnection);
                cmdEdit.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

            panelUredi.Visible = false;
        }

        private void buttonPonisti_Click(object sender, EventArgs e)
        {
            panelUredi.Visible = false;
        }

        #endregion


        
        private void tsmIzbrisi_Click(object sender, EventArgs e)
        {
            FormIzbrisi formIzbrisi = new FormIzbrisi();
            formIzbrisi.ShowDialog();
        }

        private void izbrisiKorisnika(Int32 Id)
        {
            if (MainConnection.State != ConnectionState.Open)
            {
                ConnectLocalDatabase("mile.mdb");
            }
            string sqlDelete = "";
            sqlDelete = "DELETE FROM Klijenti WHERE Id = " + Id;
            try
            {
                OleDbCommand cmdDelete = new OleDbCommand(sqlDelete, MainConnection);
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.ToString());
            }
        }

        public void izbrisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                izbrisiKorisnika(id);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }



        private void printajSveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 16; i++)
            {
                try
                {
                    RefreshrvPonudu(i);
                    GenerateFile("PDF", rvRacun.LocalReport, Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory) + "\\Račun " + i.ToString() + ".pdf");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            }
        }

        private void GenerateFile(string fileType, LocalReport report, string savePath)
        {
            byte[] bytes = report.Render(fileType);
            FileStream fs = new FileStream(savePath, FileMode.Create);
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();
        }

        private void prinajSelektiraneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvBaza.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvBaza.SelectedRows.Count; i++)
                {
                    try
                    {
                        RefreshrvPonudu(Convert.ToInt32(dgvBaza.SelectedRows[i].Cells["Id"].Value));
                        GenerateFile("PDF", rvRacun.LocalReport, Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory) + "\\Račun " + i.ToString() + ".pdf");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.ToString());
                    }
                }
            }
        }




        //private void btnButton1_Click(string docType, string fileName)
        //{
        //    //https://www.codeproject.com/Questions/1084767/How-to-load-a-rdlc-file-in-report-viewer-passing-p Solution2

        //    //https://blogs.msdn.microsoft.com/brianhartman/2009/02/27/manually-printing-a-report/
        //    //
        //    rViewer.ProcessingMode = ProcessingMode.Local;

        //    switch (docType)
        //    {
        //        case "Preview":
        //            rViewer.RefreshReport();
        //            break;
        //        case "ExporttoPDF":
        //            GenerateFile("PDF", rViewer.LocalReport, fileName + ".pdf");
        //            break;
        //        case "ExporttoExcel":
        //            GenerateFile("Excel", rViewer.LocalReport, fileName + ".xls");
        //            break;
        //        case "Print":
        //            ////////rViewer.RefreshReport();
        //            ////////rViewer.RenderingComplete += new RenderingCompleteEventHandler(printReport);
        //            ////////PrintDialog pd  = new PrintDialog();
        //            ////////pd.PrinterSettings = new PrinterSettings();
        //            //////////RawPrinterHelper.SendFileToPrinter(pd.PrinterSettings.PrinterName, ofd.FileName);
        //            ////////GenerateFile("PDF", rViewer.LocalReport, fileName + ".pdf");

        //            ////////foreach (string printer in PrinterSettings.InstalledPrinters)
        //            ////////{
        //            ////////    //http://csharphelper.com/blog/2016/06/select-and-print-multiple-files-in-c/
        //            ////////    //http://csharphelper.com/blog/2016/06/determine-the-default-printer-in-c/
        //            ////////}

        //            ////////RawPrinterHelper.SendFileToPrinter(pd.PrinterSettings.PrinterName, fileName + ".pdf");
        //            break;
        //        // Add more cases as needed.
        //    }

        //}
        //string Email = "dejan.antolic@st.t-com.hr";
        //string tbEmail = "monitor.split@st.t-com.hr";
        //string tbSMTPserver = "mail.vip.hr";
        //private void SendMail(string fileType, LocalReport report, string fileName, string Email)
        //{
        //    //http://stackoverflow.com/questions/35090407/pdf-creation-and-email-on-clicking-submit

        //    byte[] bytes = report.Render(fileType);

        //    //string fileName = string.Format("OrderConfirmation-{0}.pdf", DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss"));
        //    MailMessage message = new MailMessage(tbEmail, Email);
        //    message.Subject = "" + vpRacBr;
        //    message.Body = "U privitku se nalazi kalkulacija broj " + vpRacBr + " u PDF formatu!" + Environment.NewLine + "Hvala na povjerenju!";

        //    //            MemoryStream stream = new MemoryStream(fileBytes);
        //    MemoryStream stream = new MemoryStream(bytes);
        //    stream.Position = 0;
        //    Attachment attachment = new Attachment(stream, fileName, MediaTypeNames.Application.Octet);
        //    message.Attachments.Add(attachment);

        //    //https://msdn.microsoft.com/en-us/library/system.net.mail.mailmessage(v=vs.110).aspx
        //    //SmtpClient mailServer = new SmtpClient(example.stmphost.com);
        //    //SmtpClient mailServer = new SmtpClient("mail.vip.hr");
        //    SmtpClient mailServer = new SmtpClient(tbSMTPserver);//smtp.gmail.com
        //    //SmtpClient mailServer = new SmtpClient("smtp.gmail.com");
        //    //            mailServer.Send(message);
        //    try
        //    {
        //        mailServer.Send(message);
        //        MessageBox.Show("Poruka poslana...", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        //Console.WriteLine("Exception caught in CreateMessageWithAttachment(): {0}",
        //        //            ex.ToString());
        //        MessageBox.Show("Exception caught in CreateMessageWithAttachment(): " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    message.Dispose();
        //}


    }
}
