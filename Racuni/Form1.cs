using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racuni
{
    public partial class Form1 : Form
    {

        OleDbConnection MainConnection = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
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
                return false;
            }
            return true;
        }
        private bool OpenDatabase()
        {
            try
            {
                MainConnection.Open();
                //LocalDatabaseConnected = true;
                return true;
            }
            catch (Exception err)
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ConnectLocalDatabase("Mile.mdb"))
            {
                button1.Text = "Baza otvorena";

                string Sql = "SELECT * FROM Klijenti ORDER BY Id;";

                OleDbDataAdapter dataadapter = new OleDbDataAdapter(Sql, MainConnection);
                DataSet ds = new DataSet();
                dataadapter.Fill(ds, "Klijenti");
                dgvKlijenti.DataSource = ds;
                dgvKlijenti.DataMember = "Klijenti";

            }
            else
                button1.Text = "Baza NIJE otvorena";
        }

    }
}
