using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Globalization;
namespace bazededate
{

    public partial class down : Form
    {
        int id = 0;
        string name, pass;
        DataClasses1DataContext dbContext;
        string variable1;
        string variable2;
        string variable3;
        string variable4;
        string variable5;
        Panel a;
        public down()
        {

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            dbContext = new DataClasses1DataContext();



            panel_mecanic.Parent = panel_client.Parent;
            panel_vanz.Parent = panel_client.Parent;
            panel_director.Parent = panel_client.Parent;
            panel_client.Visible = false;
            panel_mecanic.Visible = false;
            panel_vanz.Visible = false;
            panel_director.Visible = false;
            dataGridView4.Visible = false;
        }
    }
}