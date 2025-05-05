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
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot;

namespace Asset_Management_ni_gad
{
    public partial class Dashboard : Form
    {
        private string connectionString = "Server=localhost;Database=office_asset_manager;Uid=root;Pwd=;"; // No password for root in XAMPP by default

        public Dashboard()
        {
            InitializeComponent();
        }
       
    }
}
