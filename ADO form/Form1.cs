using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ADO_form
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            con =new SqlConnection(@"Server=DESKTOP-HSLC884\SQLEXPRESS;Database=SqlDemoDB;Integrated Security=True");
        }

    }
}
