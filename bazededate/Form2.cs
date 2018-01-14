using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bazededate
{
    public partial class Form2 : Form
    {
       public string variable1;
       public string variable2;
        public string variable3;
        public string variable4;
        public string variable5;
        int type;
        public Form2(int i)
        {
            type = i;
            InitializeComponent();
            panel_vin.Parent = panel_nume_client.Parent;
            panel_add_vanz.Parent= panel_nume_client.Parent;
            panel_idpass.Parent = panel_nume_client.Parent;
            panel_addclient.Parent = panel_nume_client.Parent;
            panel_add_masina.Parent = panel_nume_client.Parent;
            add_piesa.Parent = panel_nume_client.Parent;
            add_furn.Parent = panel_nume_client.Parent;
            add_disp.Parent = panel_nume_client.Parent;
            add_tip_masina.Parent = panel_nume_client.Parent;
            add_vanzare.Parent = panel_nume_client.Parent;
            add_vanzator.Parent = panel_nume_client.Parent;
            add_mecanic.Parent = panel_nume_client.Parent;
            add_client.Parent = panel_nume_client.Parent;
            add_operatie.Parent = panel_nume_client.Parent;
            add_reparatie.Parent = panel_nume_client.Parent;
            add_brevet.Parent= panel_nume_client.Parent;
            stergi_piesa.Parent = panel_nume_client.Parent;
            stergi_client.Parent = panel_nume_client.Parent;
            stergi_client.Visible = false;
                panel_add_masina.Visible = false;
            stergi_piesa.Visible = false;
            panel_add_vanz.Visible = false;
            panel_addclient.Visible = false;
            panel_vin.Visible = false;
            panel_nume_client.Visible = false;
            panel_idpass.Visible = false;
            add_furn.Visible = false;
            add_disp.Visible = false;
            add_tip_masina.Visible = false;
            add_piesa.Visible = false;
            add_vanzare.Visible = false;
            add_vanzator.Visible = false;
            add_mecanic.Visible = false;
            add_client.Visible = false;
            add_operatie.Visible = false;
            add_reparatie.Visible = false;
            add_brevet.Visible = false;
           switch (i)
            {
                case 0:
                    panel_vin.Visible = true;
                    break;
                case 1:
                    panel_nume_client.Visible = true;
                    break;
                case 2:
                    panel_add_vanz.Visible = true;
                    break;
                case 3:
                    panel_idpass.Visible = true;
                    break;
                case 4:
                    panel_addclient.Visible = true;
                    break;
                case 5:
                    panel_add_masina.Visible = true;
                    break;
                case 6:
                    add_furn.Visible = true;
                    break;
                 case 7:
                    add_disp.Visible = true;
                    break;
                case 8:
                    add_tip_masina.Visible = true;
                    break;
                case 9:
                    add_piesa.Visible = true;
                    break;
                case 10:
                    add_vanzare.Visible = true;
                    break;
                case 11:
                    add_vanzator.Visible = true;
                    break;
                case 12:
                    add_mecanic.Visible = true;
                    break;
                case 13:
                    add_client.Visible = true;
                    break;
                case 14:
                    add_operatie.Visible = true;
                    break;
                case 15:
                    add_reparatie.Visible = true;
                    break;
                case 16:
                   add_brevet.Visible = true;
                    break;
                case 17:
                    stergi_piesa.Visible = true;
                    break;
                case 18:
                    stergi_client.Visible = true;
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if(type==1)
            {
                variable1 = text_nume.Text;
                variable2 = text_prenume.Text;
            }
            if(type==0)
            {
                variable1 = textvin.Text;
                

            }
            if(type==3)
            {
                variable1 = name.Text;
                    variable2 = pass.Text;
            }
            if(type==4)
            {
                variable1 = namec.Text;
                variable2 = prenumec.Text;
                variable3 = telefonc.Text;
                variable4 = numarcardc.Text;
            }
            if(type==5)
            {
                variable1 = textBox4.Text;
                variable2 = textBox3.Text;
                variable3 = textBox2.Text;
                variable4 = textBox1.Text;
                variable5 = textBox5.Text;
            }
            if(type==6)
            {
                variable1 = textBox6.Text;
                variable2 = textBox7.Text;
            }
            if (type == 7)
            {
                variable1 = textBox8.Text;
                variable2 = textBox9.Text;

            }
            if (type == 8)
            {
                variable1 = textBox10.Text;
               
            }
            if (type == 9)
            {
                variable1 = textBox11.Text;
                variable2 = textBox12.Text;
                variable3 = textBox13.Text;

            }
            if(type==10)
            {
                variable1 = textBox14.Text;
                variable2 = textBox15.Text;
                variable3 = textBox16.Text;
                variable4 = textBox17.Text;
                
            }
            if (type == 11)
            {
                variable1 = textBox18.Text;
                variable2 = textBox21.Text;
                
                variable4 = textBox19.Text;

            }
            if (type == 12)
            {
                variable1 = textBox22.Text;
                variable2 = textBox23.Text;
                variable3 = textBox24.Text;
                variable4 = textBox25.Text;

            }
            if (type == 13)
            {
                variable1 = textBox26.Text;
                variable2 = textBox27.Text;
                variable3 = textBox28.Text;
                variable4 = textBox29.Text;

            }
            if (type == 14)
            {
                variable1 = textBox30.Text;
               
                variable3 = textBox32.Text;
                variable4 = textBox33.Text;
                variable5 = textBox34.Text;

            }
            if (type == 15)
            {
                variable1 = textBox35.Text;
                variable2 = textBox36.Text;
                

            }
            if (type == 16)
            {
                variable1 = textBox37.Text;
                


            }
            if(type==17)
            {
                variable1 = textBox38.Text;
                variable2 = textBox39.Text;
            }
            if (type == 18)
            {
                variable1 = textBox40.Text;
                variable2 = textBox41.Text;
            }
            this.Close();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void add_vanzator_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }
    }
}
