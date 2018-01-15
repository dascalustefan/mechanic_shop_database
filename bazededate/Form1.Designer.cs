
using System.Windows.Forms;
namespace bazededate
{
    public static class Prompt
    {
        public static int ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 500;
            prompt.Height = 300;
            prompt.Text = caption;
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            NumericUpDown inputBox = new NumericUpDown() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.ShowDialog();
            return (int)inputBox.Value;
        }
    }
    partial class down
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(down));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Client = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mecanic = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Vanzator = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel_vanz = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel_director = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.stergi_piesa = new System.Windows.Forms.Button();
            this.stergi_fabricant = new System.Windows.Forms.Button();
            this.stergi_mecanic = new System.Windows.Forms.Button();
            this.stergi_supplier = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stergi_dispozitiv = new System.Windows.Forms.Button();
            this.stergi_client = new System.Windows.Forms.Button();
            this.cauta_clienti = new System.Windows.Forms.Button();
            this.vizualizare_Reparatie = new System.Windows.Forms.Button();
            this.stocul_pieselor = new System.Windows.Forms.Button();
            this.cauta_Vanzare = new System.Windows.Forms.Button();
            this.monitorizare_vanzatori = new System.Windows.Forms.Button();
            this.monitorizare_mecanici = new System.Windows.Forms.Button();
            this.ads_client = new System.Windows.Forms.Button();
            this.adauga_mecanic = new System.Windows.Forms.Button();
            this.adauga_vanzator = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_mecanic = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button30 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button28 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.add_client = new System.Windows.Forms.Button();
            this.Adaugare_brevet = new System.Windows.Forms.Button();
            this.add_masina = new System.Windows.Forms.Button();
            this.operatii_masina = new System.Windows.Forms.Button();
            this.vezi_dispozitive = new System.Windows.Forms.Button();
            this.piese_dupa_nume = new System.Windows.Forms.Button();
            this.cauta_dispozitiv = new System.Windows.Forms.Button();
            this.piese_disponibile = new System.Windows.Forms.Button();
            this.Cauta_masina = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.adauga_client = new System.Windows.Forms.Button();
            this.descrierea_reparatiei = new System.Windows.Forms.Button();
            this.cauta_vin = new System.Windows.Forms.Button();
            this.display_repairs = new System.Windows.Forms.Button();
            this.panel_client = new System.Windows.Forms.Panel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_vanz.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel_director.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_mecanic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel_client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Client
            // 
            this.Client.BackColor = System.Drawing.Color.Transparent;
            this.Client.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Client.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Client.FlatAppearance.BorderSize = 0;
            this.Client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Client.Image = ((System.Drawing.Image)(resources.GetObject("Client.Image")));
            this.Client.Location = new System.Drawing.Point(368, 65);
            this.Client.Margin = new System.Windows.Forms.Padding(4);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(71, 62);
            this.Client.TabIndex = 1;
            this.Client.UseVisualStyleBackColor = false;
            this.Client.Click += new System.EventHandler(this.Client_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mecanic
            // 
            this.mecanic.BackColor = System.Drawing.Color.Transparent;
            this.mecanic.FlatAppearance.BorderSize = 0;
            this.mecanic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mecanic.ForeColor = System.Drawing.Color.Cornsilk;
            this.mecanic.Image = ((System.Drawing.Image)(resources.GetObject("mecanic.Image")));
            this.mecanic.Location = new System.Drawing.Point(593, 65);
            this.mecanic.Margin = new System.Windows.Forms.Padding(4);
            this.mecanic.Name = "mecanic";
            this.mecanic.Size = new System.Drawing.Size(95, 62);
            this.mecanic.TabIndex = 3;
            this.mecanic.UseVisualStyleBackColor = false;
            this.mecanic.Click += new System.EventHandler(this.mecanic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(587, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mecanic";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.AliceBlue;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(848, 65);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 62);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Vanzator
            // 
            this.Vanzator.AutoSize = true;
            this.Vanzator.BackColor = System.Drawing.Color.Transparent;
            this.Vanzator.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vanzator.Location = new System.Drawing.Point(828, 135);
            this.Vanzator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Vanzator.Name = "Vanzator";
            this.Vanzator.Size = new System.Drawing.Size(117, 32);
            this.Vanzator.TabIndex = 6;
            this.Vanzator.Text = "Vanzator";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1056, 69);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 58);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1112, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Director";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Client);
            this.panel1.Controls.Add(this.Vanzator);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.mecanic);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1942, 183);
            this.panel1.TabIndex = 9;
            // 
            // minimize
            // 
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(1747, 81);
            this.minimize.Margin = new System.Windows.Forms.Padding(4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(88, 52);
            this.minimize.TabIndex = 10;
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1747, 13);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 60);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel_vanz
            // 
            this.panel_vanz.AutoSize = true;
            this.panel_vanz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_vanz.BackgroundImage")));
            this.panel_vanz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_vanz.Controls.Add(this.panel3);
            this.panel_vanz.Controls.Add(this.dataGridView2);
            this.panel_vanz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_vanz.Location = new System.Drawing.Point(0, 0);
            this.panel_vanz.Margin = new System.Windows.Forms.Padding(4);
            this.panel_vanz.Name = "panel_vanz";
            this.panel_vanz.Size = new System.Drawing.Size(1942, 677);
            this.panel_vanz.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button24);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button23);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button22);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button21);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.button20);
            this.panel3.Controls.Add(this.button19);
            this.panel3.Controls.Add(this.button15);
            this.panel3.Controls.Add(this.button18);
            this.panel3.Controls.Add(this.button16);
            this.panel3.Controls.Add(this.button17);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 380);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1942, 297);
            this.panel3.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "ID:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(34, 69);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(357, 148);
            this.textBox2.TabIndex = 37;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Orange;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Cornsilk;
            this.button7.Location = new System.Drawing.Point(1331, 1);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(248, 80);
            this.button7.TabIndex = 20;
            this.button7.Text = "adauga client";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Orange;
            this.button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.ForeColor = System.Drawing.Color.Cornsilk;
            this.button24.Location = new System.Drawing.Point(563, 89);
            this.button24.Margin = new System.Windows.Forms.Padding(4);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(248, 80);
            this.button24.TabIndex = 36;
            this.button24.Text = "adauga fabricanti de masini";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Orange;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Cornsilk;
            this.button8.Location = new System.Drawing.Point(1331, 89);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(248, 80);
            this.button8.TabIndex = 21;
            this.button8.Text = "adauga piese";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Orange;
            this.button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.ForeColor = System.Drawing.Color.Cornsilk;
            this.button23.Location = new System.Drawing.Point(563, 1);
            this.button23.Margin = new System.Windows.Forms.Padding(4);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(248, 80);
            this.button23.TabIndex = 35;
            this.button23.Text = "adauga furnizori";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Orange;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Cornsilk;
            this.button9.Location = new System.Drawing.Point(1075, 181);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(248, 80);
            this.button9.TabIndex = 22;
            this.button9.Text = "vanzare noua";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Orange;
            this.button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.ForeColor = System.Drawing.Color.Cornsilk;
            this.button22.Location = new System.Drawing.Point(563, 177);
            this.button22.Margin = new System.Windows.Forms.Padding(4);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(248, 80);
            this.button22.TabIndex = 34;
            this.button22.Text = "adauga tipuri de masini";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Orange;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Cornsilk;
            this.button10.Location = new System.Drawing.Point(1331, 181);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(248, 80);
            this.button10.TabIndex = 23;
            this.button10.Text = "vezi vanzari";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Orange;
            this.button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.Color.Cornsilk;
            this.button21.Location = new System.Drawing.Point(819, 181);
            this.button21.Margin = new System.Windows.Forms.Padding(4);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(248, 80);
            this.button21.TabIndex = 33;
            this.button21.Text = "adauga dispozitiv";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Orange;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Cornsilk;
            this.button11.Location = new System.Drawing.Point(1587, 89);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(248, 80);
            this.button11.TabIndex = 24;
            this.button11.Text = "toti clientii";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Orange;
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.ForeColor = System.Drawing.Color.Cornsilk;
            this.button20.Location = new System.Drawing.Point(819, 1);
            this.button20.Margin = new System.Windows.Forms.Padding(4);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(248, 80);
            this.button20.TabIndex = 32;
            this.button20.Text = "cauta piese dupa clienti";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Orange;
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.Cornsilk;
            this.button19.Location = new System.Drawing.Point(1587, 181);
            this.button19.Margin = new System.Windows.Forms.Padding(4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(248, 80);
            this.button19.TabIndex = 31;
            this.button19.Text = "toate piesele vandute";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Orange;
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.Cornsilk;
            this.button15.Location = new System.Drawing.Point(819, 89);
            this.button15.Margin = new System.Windows.Forms.Padding(4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(248, 80);
            this.button15.TabIndex = 27;
            this.button15.Text = "cauta client dupa nume";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Orange;
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.Color.Cornsilk;
            this.button18.Location = new System.Drawing.Point(1075, 89);
            this.button18.Margin = new System.Windows.Forms.Padding(4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(248, 80);
            this.button18.TabIndex = 30;
            this.button18.Text = "cauta piese dupa furnizor ";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Orange;
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.Cornsilk;
            this.button16.Location = new System.Drawing.Point(1587, -2);
            this.button16.Margin = new System.Windows.Forms.Padding(4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(248, 80);
            this.button16.TabIndex = 28;
            this.button16.Text = "toate piesele";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Orange;
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.Cornsilk;
            this.button17.Location = new System.Drawing.Point(1075, 1);
            this.button17.Margin = new System.Windows.Forms.Padding(4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(248, 80);
            this.button17.TabIndex = 29;
            this.button17.Text = "cauta piese dupa nume";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Orange;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1942, 677);
            this.dataGridView2.TabIndex = 0;
            // 
            // panel_director
            // 
            this.panel_director.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_director.BackgroundImage")));
            this.panel_director.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_director.Controls.Add(this.panel5);
            this.panel_director.Controls.Add(this.panel4);
            this.panel_director.Controls.Add(this.dataGridView3);
            this.panel_director.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_director.Location = new System.Drawing.Point(0, 0);
            this.panel_director.Margin = new System.Windows.Forms.Padding(4);
            this.panel_director.Name = "panel_director";
            this.panel_director.Size = new System.Drawing.Size(1942, 677);
            this.panel_director.TabIndex = 39;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Controls.Add(this.button33);
            this.panel5.Controls.Add(this.button32);
            this.panel5.Controls.Add(this.button31);
            this.panel5.Controls.Add(this.stergi_piesa);
            this.panel5.Controls.Add(this.stergi_fabricant);
            this.panel5.Controls.Add(this.stergi_mecanic);
            this.panel5.Controls.Add(this.stergi_supplier);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 575);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1427, 102);
            this.panel5.TabIndex = 46;
            // 
            // stergi_piesa
            // 
            this.stergi_piesa.BackColor = System.Drawing.Color.Orange;
            this.stergi_piesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stergi_piesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stergi_piesa.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergi_piesa.ForeColor = System.Drawing.Color.Cornsilk;
            this.stergi_piesa.Location = new System.Drawing.Point(528, 7);
            this.stergi_piesa.Margin = new System.Windows.Forms.Padding(4);
            this.stergi_piesa.Name = "stergi_piesa";
            this.stergi_piesa.Size = new System.Drawing.Size(248, 80);
            this.stergi_piesa.TabIndex = 43;
            this.stergi_piesa.Text = "stergi piesa";
            this.stergi_piesa.UseVisualStyleBackColor = false;
            this.stergi_piesa.Click += new System.EventHandler(this.stergi_piesa_Click);
            // 
            // stergi_fabricant
            // 
            this.stergi_fabricant.BackColor = System.Drawing.Color.Orange;
            this.stergi_fabricant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stergi_fabricant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stergi_fabricant.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergi_fabricant.ForeColor = System.Drawing.Color.Cornsilk;
            this.stergi_fabricant.Location = new System.Drawing.Point(272, 7);
            this.stergi_fabricant.Margin = new System.Windows.Forms.Padding(4);
            this.stergi_fabricant.Name = "stergi_fabricant";
            this.stergi_fabricant.Size = new System.Drawing.Size(248, 80);
            this.stergi_fabricant.TabIndex = 42;
            this.stergi_fabricant.Text = "stergi fabricant";
            this.stergi_fabricant.UseVisualStyleBackColor = false;
            this.stergi_fabricant.Click += new System.EventHandler(this.stergi_fabricant_Click);
            // 
            // stergi_mecanic
            // 
            this.stergi_mecanic.BackColor = System.Drawing.Color.Orange;
            this.stergi_mecanic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stergi_mecanic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stergi_mecanic.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergi_mecanic.ForeColor = System.Drawing.Color.Cornsilk;
            this.stergi_mecanic.Location = new System.Drawing.Point(784, 7);
            this.stergi_mecanic.Margin = new System.Windows.Forms.Padding(4);
            this.stergi_mecanic.Name = "stergi_mecanic";
            this.stergi_mecanic.Size = new System.Drawing.Size(248, 80);
            this.stergi_mecanic.TabIndex = 38;
            this.stergi_mecanic.Text = "stergi mecanic";
            this.stergi_mecanic.UseVisualStyleBackColor = false;
            this.stergi_mecanic.Click += new System.EventHandler(this.stergi_mecanic_Click);
            // 
            // stergi_supplier
            // 
            this.stergi_supplier.BackColor = System.Drawing.Color.Orange;
            this.stergi_supplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stergi_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stergi_supplier.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergi_supplier.ForeColor = System.Drawing.Color.Cornsilk;
            this.stergi_supplier.Location = new System.Drawing.Point(16, 7);
            this.stergi_supplier.Margin = new System.Windows.Forms.Padding(4);
            this.stergi_supplier.Name = "stergi_supplier";
            this.stergi_supplier.Size = new System.Drawing.Size(248, 80);
            this.stergi_supplier.TabIndex = 41;
            this.stergi_supplier.Text = "stergi supplier";
            this.stergi_supplier.UseVisualStyleBackColor = false;
            this.stergi_supplier.Click += new System.EventHandler(this.stergi_supplier_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.stergi_dispozitiv);
            this.panel4.Controls.Add(this.stergi_client);
            this.panel4.Controls.Add(this.cauta_clienti);
            this.panel4.Controls.Add(this.vizualizare_Reparatie);
            this.panel4.Controls.Add(this.stocul_pieselor);
            this.panel4.Controls.Add(this.cauta_Vanzare);
            this.panel4.Controls.Add(this.monitorizare_vanzatori);
            this.panel4.Controls.Add(this.monitorizare_mecanici);
            this.panel4.Controls.Add(this.ads_client);
            this.panel4.Controls.Add(this.adauga_mecanic);
            this.panel4.Controls.Add(this.adauga_vanzator);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1427, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(515, 677);
            this.panel4.TabIndex = 37;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(274, 371);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(237, 252);
            this.textBox3.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 630);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "ID:";
            // 
            // stergi_dispozitiv
            // 
            this.stergi_dispozitiv.BackColor = System.Drawing.Color.Orange;
            this.stergi_dispozitiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stergi_dispozitiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stergi_dispozitiv.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergi_dispozitiv.ForeColor = System.Drawing.Color.Cornsilk;
            this.stergi_dispozitiv.Location = new System.Drawing.Point(11, 455);
            this.stergi_dispozitiv.Margin = new System.Windows.Forms.Padding(4);
            this.stergi_dispozitiv.Name = "stergi_dispozitiv";
            this.stergi_dispozitiv.Size = new System.Drawing.Size(248, 80);
            this.stergi_dispozitiv.TabIndex = 40;
            this.stergi_dispozitiv.Text = "stergi dispozitiv";
            this.stergi_dispozitiv.UseVisualStyleBackColor = false;
            this.stergi_dispozitiv.Click += new System.EventHandler(this.stergi_dispozitiv_Click);
            // 
            // stergi_client
            // 
            this.stergi_client.BackColor = System.Drawing.Color.Orange;
            this.stergi_client.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stergi_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stergi_client.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergi_client.ForeColor = System.Drawing.Color.Cornsilk;
            this.stergi_client.Location = new System.Drawing.Point(11, 543);
            this.stergi_client.Margin = new System.Windows.Forms.Padding(4);
            this.stergi_client.Name = "stergi_client";
            this.stergi_client.Size = new System.Drawing.Size(248, 80);
            this.stergi_client.TabIndex = 39;
            this.stergi_client.Text = "stergi client";
            this.stergi_client.UseVisualStyleBackColor = false;
            this.stergi_client.Click += new System.EventHandler(this.stergi_client_Click);
            // 
            // cauta_clienti
            // 
            this.cauta_clienti.BackColor = System.Drawing.Color.Orange;
            this.cauta_clienti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cauta_clienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cauta_clienti.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cauta_clienti.ForeColor = System.Drawing.Color.Cornsilk;
            this.cauta_clienti.Location = new System.Drawing.Point(267, 190);
            this.cauta_clienti.Margin = new System.Windows.Forms.Padding(4);
            this.cauta_clienti.Name = "cauta_clienti";
            this.cauta_clienti.Size = new System.Drawing.Size(248, 80);
            this.cauta_clienti.TabIndex = 37;
            this.cauta_clienti.Text = "cauta client";
            this.cauta_clienti.UseVisualStyleBackColor = false;
            this.cauta_clienti.Click += new System.EventHandler(this.cauta_clienti_Click);
            // 
            // vizualizare_Reparatie
            // 
            this.vizualizare_Reparatie.BackColor = System.Drawing.Color.Orange;
            this.vizualizare_Reparatie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.vizualizare_Reparatie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vizualizare_Reparatie.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vizualizare_Reparatie.ForeColor = System.Drawing.Color.Cornsilk;
            this.vizualizare_Reparatie.Location = new System.Drawing.Point(11, 367);
            this.vizualizare_Reparatie.Margin = new System.Windows.Forms.Padding(4);
            this.vizualizare_Reparatie.Name = "vizualizare_Reparatie";
            this.vizualizare_Reparatie.Size = new System.Drawing.Size(248, 80);
            this.vizualizare_Reparatie.TabIndex = 36;
            this.vizualizare_Reparatie.Text = "vizualizare reparatii";
            this.vizualizare_Reparatie.UseVisualStyleBackColor = false;
            this.vizualizare_Reparatie.Click += new System.EventHandler(this.vizualizare_Reparatie_Click);
            // 
            // stocul_pieselor
            // 
            this.stocul_pieselor.BackColor = System.Drawing.Color.Orange;
            this.stocul_pieselor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stocul_pieselor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stocul_pieselor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocul_pieselor.ForeColor = System.Drawing.Color.Cornsilk;
            this.stocul_pieselor.Location = new System.Drawing.Point(267, 283);
            this.stocul_pieselor.Margin = new System.Windows.Forms.Padding(4);
            this.stocul_pieselor.Name = "stocul_pieselor";
            this.stocul_pieselor.Size = new System.Drawing.Size(248, 80);
            this.stocul_pieselor.TabIndex = 34;
            this.stocul_pieselor.Text = "verifica stocul pieselor";
            this.stocul_pieselor.UseVisualStyleBackColor = false;
            this.stocul_pieselor.Click += new System.EventHandler(this.stocul_pieselor_Click);
            // 
            // cauta_Vanzare
            // 
            this.cauta_Vanzare.BackColor = System.Drawing.Color.Orange;
            this.cauta_Vanzare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cauta_Vanzare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cauta_Vanzare.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cauta_Vanzare.ForeColor = System.Drawing.Color.Cornsilk;
            this.cauta_Vanzare.Location = new System.Drawing.Point(11, 283);
            this.cauta_Vanzare.Margin = new System.Windows.Forms.Padding(4);
            this.cauta_Vanzare.Name = "cauta_Vanzare";
            this.cauta_Vanzare.Size = new System.Drawing.Size(248, 80);
            this.cauta_Vanzare.TabIndex = 33;
            this.cauta_Vanzare.Text = "cauta vanzare dupa vanzatori";
            this.cauta_Vanzare.UseVisualStyleBackColor = false;
            this.cauta_Vanzare.Click += new System.EventHandler(this.cauta_Vanzare_Click);
            // 
            // monitorizare_vanzatori
            // 
            this.monitorizare_vanzatori.BackColor = System.Drawing.Color.Orange;
            this.monitorizare_vanzatori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.monitorizare_vanzatori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monitorizare_vanzatori.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitorizare_vanzatori.ForeColor = System.Drawing.Color.Cornsilk;
            this.monitorizare_vanzatori.Location = new System.Drawing.Point(11, 190);
            this.monitorizare_vanzatori.Margin = new System.Windows.Forms.Padding(4);
            this.monitorizare_vanzatori.Name = "monitorizare_vanzatori";
            this.monitorizare_vanzatori.Size = new System.Drawing.Size(248, 80);
            this.monitorizare_vanzatori.TabIndex = 31;
            this.monitorizare_vanzatori.Text = "monitorizare vanzatori";
            this.monitorizare_vanzatori.UseVisualStyleBackColor = false;
            this.monitorizare_vanzatori.Click += new System.EventHandler(this.monitorizare_vanzatori_Click);
            // 
            // monitorizare_mecanici
            // 
            this.monitorizare_mecanici.BackColor = System.Drawing.Color.Orange;
            this.monitorizare_mecanici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.monitorizare_mecanici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monitorizare_mecanici.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitorizare_mecanici.ForeColor = System.Drawing.Color.Cornsilk;
            this.monitorizare_mecanici.Location = new System.Drawing.Point(267, 101);
            this.monitorizare_mecanici.Margin = new System.Windows.Forms.Padding(4);
            this.monitorizare_mecanici.Name = "monitorizare_mecanici";
            this.monitorizare_mecanici.Size = new System.Drawing.Size(248, 80);
            this.monitorizare_mecanici.TabIndex = 30;
            this.monitorizare_mecanici.Text = "monitorizare mecanici";
            this.monitorizare_mecanici.UseVisualStyleBackColor = false;
            this.monitorizare_mecanici.Click += new System.EventHandler(this.monitorizare_mecanici_Click);
            // 
            // ads_client
            // 
            this.ads_client.BackColor = System.Drawing.Color.Orange;
            this.ads_client.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ads_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ads_client.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ads_client.ForeColor = System.Drawing.Color.Cornsilk;
            this.ads_client.Location = new System.Drawing.Point(11, 101);
            this.ads_client.Margin = new System.Windows.Forms.Padding(4);
            this.ads_client.Name = "ads_client";
            this.ads_client.Size = new System.Drawing.Size(248, 80);
            this.ads_client.TabIndex = 29;
            this.ads_client.Text = "adauga client";
            this.ads_client.UseVisualStyleBackColor = false;
            this.ads_client.Click += new System.EventHandler(this.ads_client_Click);
            // 
            // adauga_mecanic
            // 
            this.adauga_mecanic.BackColor = System.Drawing.Color.Orange;
            this.adauga_mecanic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.adauga_mecanic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adauga_mecanic.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adauga_mecanic.ForeColor = System.Drawing.Color.Cornsilk;
            this.adauga_mecanic.Location = new System.Drawing.Point(267, 7);
            this.adauga_mecanic.Margin = new System.Windows.Forms.Padding(4);
            this.adauga_mecanic.Name = "adauga_mecanic";
            this.adauga_mecanic.Size = new System.Drawing.Size(248, 80);
            this.adauga_mecanic.TabIndex = 28;
            this.adauga_mecanic.Text = "adauga mecanic";
            this.adauga_mecanic.UseVisualStyleBackColor = false;
            this.adauga_mecanic.Click += new System.EventHandler(this.adauga_mecanic_Click);
            // 
            // adauga_vanzator
            // 
            this.adauga_vanzator.BackColor = System.Drawing.Color.Orange;
            this.adauga_vanzator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.adauga_vanzator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adauga_vanzator.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adauga_vanzator.ForeColor = System.Drawing.Color.Cornsilk;
            this.adauga_vanzator.Location = new System.Drawing.Point(11, 7);
            this.adauga_vanzator.Margin = new System.Windows.Forms.Padding(4);
            this.adauga_vanzator.Name = "adauga_vanzator";
            this.adauga_vanzator.Size = new System.Drawing.Size(248, 80);
            this.adauga_vanzator.TabIndex = 27;
            this.adauga_vanzator.Text = "adauga vanzator";
            this.adauga_vanzator.UseVisualStyleBackColor = false;
            this.adauga_vanzator.Click += new System.EventHandler(this.adauga_vanzator_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1942, 677);
            this.dataGridView3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel_director);
            this.panel2.Controls.Add(this.panel_mecanic);
            this.panel2.Controls.Add(this.panel_vanz);
            this.panel2.Controls.Add(this.panel_client);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 183);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1942, 677);
            this.panel2.TabIndex = 10;
            // 
            // panel_mecanic
            // 
            this.panel_mecanic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_mecanic.BackgroundImage")));
            this.panel_mecanic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_mecanic.Controls.Add(this.dataGridView1);
            this.panel_mecanic.Controls.Add(this.panel7);
            this.panel_mecanic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_mecanic.Location = new System.Drawing.Point(0, 0);
            this.panel_mecanic.Margin = new System.Windows.Forms.Padding(4);
            this.panel_mecanic.Name = "panel_mecanic";
            this.panel_mecanic.Size = new System.Drawing.Size(1942, 677);
            this.panel_mecanic.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1942, 399);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.Controls.Add(this.button30);
            this.panel7.Controls.Add(this.button29);
            this.panel7.Controls.Add(this.button14);
            this.panel7.Controls.Add(this.button12);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.button28);
            this.panel7.Controls.Add(this.button27);
            this.panel7.Controls.Add(this.button26);
            this.panel7.Controls.Add(this.button25);
            this.panel7.Controls.Add(this.add_client);
            this.panel7.Controls.Add(this.Adaugare_brevet);
            this.panel7.Controls.Add(this.add_masina);
            this.panel7.Controls.Add(this.operatii_masina);
            this.panel7.Controls.Add(this.vezi_dispozitive);
            this.panel7.Controls.Add(this.piese_dupa_nume);
            this.panel7.Controls.Add(this.cauta_dispozitiv);
            this.panel7.Controls.Add(this.piese_disponibile);
            this.panel7.Controls.Add(this.Cauta_masina);
            this.panel7.Controls.Add(this.button6);
            this.panel7.Controls.Add(this.button13);
            this.panel7.Controls.Add(this.textBox1);
            this.panel7.Controls.Add(this.adauga_client);
            this.panel7.Controls.Add(this.descrierea_reparatiei);
            this.panel7.Controls.Add(this.cauta_vin);
            this.panel7.Controls.Add(this.display_repairs);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 399);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1942, 278);
            this.panel7.TabIndex = 23;
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.Orange;
            this.button30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button30.ForeColor = System.Drawing.Color.Cornsilk;
            this.button30.Location = new System.Drawing.Point(175, 10);
            this.button30.Margin = new System.Windows.Forms.Padding(4);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(354, 52);
            this.button30.TabIndex = 31;
            this.button30.Text = "toate piesele dupa supplier";
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.Orange;
            this.button29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button29.ForeColor = System.Drawing.Color.Cornsilk;
            this.button29.Location = new System.Drawing.Point(13, 66);
            this.button29.Margin = new System.Windows.Forms.Padding(4);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(155, 144);
            this.button29.TabIndex = 30;
            this.button29.Text = "cauta piesa dupa supplier";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Orange;
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.Cornsilk;
            this.button14.Location = new System.Drawing.Point(943, 66);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(248, 52);
            this.button14.TabIndex = 29;
            this.button14.Text = "toate piesele";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Orange;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.Cornsilk;
            this.button12.Location = new System.Drawing.Point(1203, 66);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(248, 52);
            this.button12.TabIndex = 28;
            this.button12.Text = "arata mecanicii";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "ID:";
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.Orange;
            this.button28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.ForeColor = System.Drawing.Color.Cornsilk;
            this.button28.Location = new System.Drawing.Point(175, 126);
            this.button28.Margin = new System.Windows.Forms.Padding(4);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(248, 54);
            this.button28.TabIndex = 26;
            this.button28.Text = "adauga reparatie";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.Orange;
            this.button27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.ForeColor = System.Drawing.Color.Cornsilk;
            this.button27.Location = new System.Drawing.Point(175, 66);
            this.button27.Margin = new System.Windows.Forms.Padding(4);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(248, 55);
            this.button27.TabIndex = 25;
            this.button27.Text = "adauga operatie";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Orange;
            this.button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.ForeColor = System.Drawing.Color.Cornsilk;
            this.button26.Location = new System.Drawing.Point(175, 188);
            this.button26.Margin = new System.Windows.Forms.Padding(4);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(248, 76);
            this.button26.TabIndex = 24;
            this.button26.Text = "brevete disponibile";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Orange;
            this.button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.ForeColor = System.Drawing.Color.Cornsilk;
            this.button25.Location = new System.Drawing.Point(431, 188);
            this.button25.Margin = new System.Windows.Forms.Padding(4);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(248, 75);
            this.button25.TabIndex = 23;
            this.button25.Text = "vezi masini nereparate";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // add_client
            // 
            this.add_client.BackColor = System.Drawing.Color.Orange;
            this.add_client.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.add_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_client.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_client.ForeColor = System.Drawing.Color.Cornsilk;
            this.add_client.Location = new System.Drawing.Point(943, 126);
            this.add_client.Margin = new System.Windows.Forms.Padding(4);
            this.add_client.Name = "add_client";
            this.add_client.Size = new System.Drawing.Size(248, 54);
            this.add_client.TabIndex = 22;
            this.add_client.Text = "adauga client";
            this.add_client.UseVisualStyleBackColor = false;
            this.add_client.Click += new System.EventHandler(this.add_client_Click);
            // 
            // Adaugare_brevet
            // 
            this.Adaugare_brevet.BackColor = System.Drawing.Color.Orange;
            this.Adaugare_brevet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Adaugare_brevet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adaugare_brevet.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adaugare_brevet.ForeColor = System.Drawing.Color.Cornsilk;
            this.Adaugare_brevet.Location = new System.Drawing.Point(687, 66);
            this.Adaugare_brevet.Margin = new System.Windows.Forms.Padding(4);
            this.Adaugare_brevet.Name = "Adaugare_brevet";
            this.Adaugare_brevet.Size = new System.Drawing.Size(248, 55);
            this.Adaugare_brevet.TabIndex = 6;
            this.Adaugare_brevet.Text = "Adaugare brevet";
            this.Adaugare_brevet.UseVisualStyleBackColor = false;
            this.Adaugare_brevet.Click += new System.EventHandler(this.Adaugare_brevet_Click);
            // 
            // add_masina
            // 
            this.add_masina.BackColor = System.Drawing.Color.Orange;
            this.add_masina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.add_masina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_masina.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_masina.ForeColor = System.Drawing.Color.Cornsilk;
            this.add_masina.Location = new System.Drawing.Point(1459, 126);
            this.add_masina.Margin = new System.Windows.Forms.Padding(4);
            this.add_masina.Name = "add_masina";
            this.add_masina.Size = new System.Drawing.Size(248, 54);
            this.add_masina.TabIndex = 20;
            this.add_masina.Text = "adauga masina";
            this.add_masina.UseVisualStyleBackColor = false;
            this.add_masina.Click += new System.EventHandler(this.add_masina_Click);
            // 
            // operatii_masina
            // 
            this.operatii_masina.BackColor = System.Drawing.Color.Orange;
            this.operatii_masina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.operatii_masina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatii_masina.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatii_masina.ForeColor = System.Drawing.Color.Cornsilk;
            this.operatii_masina.Location = new System.Drawing.Point(1459, 188);
            this.operatii_masina.Margin = new System.Windows.Forms.Padding(4);
            this.operatii_masina.Name = "operatii_masina";
            this.operatii_masina.Size = new System.Drawing.Size(248, 74);
            this.operatii_masina.TabIndex = 15;
            this.operatii_masina.Text = "toate operatiile masinii";
            this.operatii_masina.UseVisualStyleBackColor = false;
            this.operatii_masina.Click += new System.EventHandler(this.operatii_masina_Click);
            // 
            // vezi_dispozitive
            // 
            this.vezi_dispozitive.BackColor = System.Drawing.Color.Orange;
            this.vezi_dispozitive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.vezi_dispozitive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vezi_dispozitive.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vezi_dispozitive.ForeColor = System.Drawing.Color.Cornsilk;
            this.vezi_dispozitive.Location = new System.Drawing.Point(431, 126);
            this.vezi_dispozitive.Margin = new System.Windows.Forms.Padding(4);
            this.vezi_dispozitive.Name = "vezi_dispozitive";
            this.vezi_dispozitive.Size = new System.Drawing.Size(248, 55);
            this.vezi_dispozitive.TabIndex = 7;
            this.vezi_dispozitive.Text = "Vezi dispozitive";
            this.vezi_dispozitive.UseVisualStyleBackColor = false;
            this.vezi_dispozitive.Click += new System.EventHandler(this.vezi_dispozitive_Click);
            // 
            // piese_dupa_nume
            // 
            this.piese_dupa_nume.BackColor = System.Drawing.Color.Orange;
            this.piese_dupa_nume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.piese_dupa_nume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.piese_dupa_nume.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piese_dupa_nume.ForeColor = System.Drawing.Color.Cornsilk;
            this.piese_dupa_nume.Location = new System.Drawing.Point(537, 10);
            this.piese_dupa_nume.Margin = new System.Windows.Forms.Padding(4);
            this.piese_dupa_nume.Name = "piese_dupa_nume";
            this.piese_dupa_nume.Size = new System.Drawing.Size(333, 52);
            this.piese_dupa_nume.TabIndex = 14;
            this.piese_dupa_nume.Text = "cauta piese dupa nume";
            this.piese_dupa_nume.UseVisualStyleBackColor = false;
            this.piese_dupa_nume.Click += new System.EventHandler(this.piese_dupa_nume_Click);
            // 
            // cauta_dispozitiv
            // 
            this.cauta_dispozitiv.BackColor = System.Drawing.Color.Orange;
            this.cauta_dispozitiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cauta_dispozitiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cauta_dispozitiv.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cauta_dispozitiv.ForeColor = System.Drawing.Color.Cornsilk;
            this.cauta_dispozitiv.Location = new System.Drawing.Point(431, 66);
            this.cauta_dispozitiv.Margin = new System.Windows.Forms.Padding(4);
            this.cauta_dispozitiv.Name = "cauta_dispozitiv";
            this.cauta_dispozitiv.Size = new System.Drawing.Size(248, 55);
            this.cauta_dispozitiv.TabIndex = 8;
            this.cauta_dispozitiv.Text = "Cauta dispozitiv";
            this.cauta_dispozitiv.UseVisualStyleBackColor = false;
            this.cauta_dispozitiv.Click += new System.EventHandler(this.cauta_dispozitiv_Click);
            // 
            // piese_disponibile
            // 
            this.piese_disponibile.BackColor = System.Drawing.Color.Orange;
            this.piese_disponibile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.piese_disponibile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.piese_disponibile.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piese_disponibile.ForeColor = System.Drawing.Color.Cornsilk;
            this.piese_disponibile.Location = new System.Drawing.Point(878, 10);
            this.piese_disponibile.Margin = new System.Windows.Forms.Padding(4);
            this.piese_disponibile.Name = "piese_disponibile";
            this.piese_disponibile.Size = new System.Drawing.Size(404, 52);
            this.piese_disponibile.TabIndex = 13;
            this.piese_disponibile.Text = "arata piesele disponibile";
            this.piese_disponibile.UseVisualStyleBackColor = false;
            this.piese_disponibile.Click += new System.EventHandler(this.piese_disponibile_Click);
            // 
            // Cauta_masina
            // 
            this.Cauta_masina.BackColor = System.Drawing.Color.Orange;
            this.Cauta_masina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Cauta_masina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cauta_masina.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cauta_masina.ForeColor = System.Drawing.Color.Cornsilk;
            this.Cauta_masina.Location = new System.Drawing.Point(687, 126);
            this.Cauta_masina.Margin = new System.Windows.Forms.Padding(4);
            this.Cauta_masina.Name = "Cauta_masina";
            this.Cauta_masina.Size = new System.Drawing.Size(248, 55);
            this.Cauta_masina.TabIndex = 9;
            this.Cauta_masina.Text = "Cauta masina";
            this.Cauta_masina.UseVisualStyleBackColor = false;
            this.Cauta_masina.Click += new System.EventHandler(this.Cauta_masina_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Orange;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Cornsilk;
            this.button6.Location = new System.Drawing.Point(1459, 66);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(248, 52);
            this.button6.TabIndex = 12;
            this.button6.Text = "arata masinile";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Orange;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.Cornsilk;
            this.button13.Location = new System.Drawing.Point(687, 188);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(248, 74);
            this.button13.TabIndex = 10;
            this.button13.Text = "cauta reparatia dupa masina";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1715, 103);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 77);
            this.textBox1.TabIndex = 4;
            // 
            // adauga_client
            // 
            this.adauga_client.BackColor = System.Drawing.Color.Orange;
            this.adauga_client.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.adauga_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adauga_client.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adauga_client.ForeColor = System.Drawing.Color.Cornsilk;
            this.adauga_client.Location = new System.Drawing.Point(1290, 10);
            this.adauga_client.Margin = new System.Windows.Forms.Padding(4);
            this.adauga_client.Name = "adauga_client";
            this.adauga_client.Size = new System.Drawing.Size(417, 52);
            this.adauga_client.TabIndex = 3;
            this.adauga_client.Text = "cauta proprietar dupa nume";
            this.adauga_client.UseVisualStyleBackColor = false;
            this.adauga_client.Click += new System.EventHandler(this.adauga_client_Click);
            // 
            // descrierea_reparatiei
            // 
            this.descrierea_reparatiei.BackColor = System.Drawing.Color.Orange;
            this.descrierea_reparatiei.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.descrierea_reparatiei.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.descrierea_reparatiei.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrierea_reparatiei.ForeColor = System.Drawing.Color.Cornsilk;
            this.descrierea_reparatiei.Location = new System.Drawing.Point(1203, 188);
            this.descrierea_reparatiei.Margin = new System.Windows.Forms.Padding(4);
            this.descrierea_reparatiei.Name = "descrierea_reparatiei";
            this.descrierea_reparatiei.Size = new System.Drawing.Size(248, 74);
            this.descrierea_reparatiei.TabIndex = 5;
            this.descrierea_reparatiei.Text = "descrierea reparatiei";
            this.descrierea_reparatiei.UseVisualStyleBackColor = false;
            this.descrierea_reparatiei.Click += new System.EventHandler(this.descrierea_reparatiei_Click);
            // 
            // cauta_vin
            // 
            this.cauta_vin.BackColor = System.Drawing.Color.Orange;
            this.cauta_vin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cauta_vin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cauta_vin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cauta_vin.ForeColor = System.Drawing.Color.Cornsilk;
            this.cauta_vin.Location = new System.Drawing.Point(1203, 126);
            this.cauta_vin.Margin = new System.Windows.Forms.Padding(4);
            this.cauta_vin.Name = "cauta_vin";
            this.cauta_vin.Size = new System.Drawing.Size(248, 55);
            this.cauta_vin.TabIndex = 1;
            this.cauta_vin.Text = "Cauta dupa vin";
            this.cauta_vin.UseVisualStyleBackColor = false;
            this.cauta_vin.Click += new System.EventHandler(this.cauta_vin_Click);
            // 
            // display_repairs
            // 
            this.display_repairs.BackColor = System.Drawing.Color.Orange;
            this.display_repairs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.display_repairs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.display_repairs.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_repairs.ForeColor = System.Drawing.Color.Cornsilk;
            this.display_repairs.Location = new System.Drawing.Point(943, 188);
            this.display_repairs.Margin = new System.Windows.Forms.Padding(4);
            this.display_repairs.Name = "display_repairs";
            this.display_repairs.Size = new System.Drawing.Size(248, 75);
            this.display_repairs.TabIndex = 2;
            this.display_repairs.Text = "arata toate reparatiile";
            this.display_repairs.UseVisualStyleBackColor = false;
            this.display_repairs.Click += new System.EventHandler(this.display_repairs_Click);
            // 
            // panel_client
            // 
            this.panel_client.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_client.BackgroundImage")));
            this.panel_client.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_client.Controls.Add(this.dataGridView4);
            this.panel_client.Controls.Add(this.panel6);
            this.panel_client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_client.Location = new System.Drawing.Point(0, 0);
            this.panel_client.Margin = new System.Windows.Forms.Padding(4);
            this.panel_client.Name = "panel_client";
            this.panel_client.Size = new System.Drawing.Size(1942, 677);
            this.panel_client.TabIndex = 0;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(0, 212);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView4.Size = new System.Drawing.Size(1942, 465);
            this.dataGridView4.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.button5);
            this.panel6.Controls.Add(this.button4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1942, 212);
            this.panel6.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Orange;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Cornsilk;
            this.button5.Location = new System.Drawing.Point(1363, 113);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(263, 55);
            this.button5.TabIndex = 1;
            this.button5.Text = "Search by name";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Orange;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Cornsilk;
            this.button4.Location = new System.Drawing.Point(856, 113);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(248, 55);
            this.button4.TabIndex = 0;
            this.button4.Text = "Search by vin";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.Orange;
            this.button31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button31.ForeColor = System.Drawing.Color.Cornsilk;
            this.button31.Location = new System.Drawing.Point(1056, 37);
            this.button31.Margin = new System.Windows.Forms.Padding(4);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(248, 30);
            this.button31.TabIndex = 44;
            this.button31.Text = "Raport Stoc";
            this.button31.UseVisualStyleBackColor = false;
            this.button31.Click += new System.EventHandler(this.button31_Click_1);
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.Orange;
            this.button32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button32.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button32.ForeColor = System.Drawing.Color.Cornsilk;
            this.button32.Location = new System.Drawing.Point(1056, 71);
            this.button32.Margin = new System.Windows.Forms.Padding(4);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(248, 31);
            this.button32.TabIndex = 45;
            this.button32.Text = "Raport Supplier";
            this.button32.UseVisualStyleBackColor = false;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.Orange;
            this.button33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button33.ForeColor = System.Drawing.Color.Cornsilk;
            this.button33.Location = new System.Drawing.Point(1056, 3);
            this.button33.Margin = new System.Windows.Forms.Padding(4);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(248, 31);
            this.button33.TabIndex = 46;
            this.button33.Text = "Raport Clienti";
            this.button33.UseVisualStyleBackColor = false;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // down
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1942, 860);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "down";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redballs Garage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_vanz.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel_director.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_mecanic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel_client.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Client;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mecanic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Vanzator;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel_client;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private Panel panel_mecanic;
        private DataGridView dataGridView1;
        private Button button13;
        private Button Cauta_masina;
        private Button cauta_dispozitiv;
        private Button vezi_dispozitive;
        private Button Adaugare_brevet;
        private Button descrierea_reparatiei;
        private TextBox textBox1;
        private Button adauga_client;
        private Button display_repairs;
        private Button cauta_vin;
        private Button operatii_masina;
        private Button piese_dupa_nume;
        private Button piese_disponibile;
        private Button button6;
        private Button add_masina;
        private Button add_client;
        private Panel panel_vanz;
        private TextBox textBox2;
        private Button button24;
        private Button button23;
        private Button button22;
        private Button button21;
        private Button button20;
        private Button button19;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private DataGridView dataGridView2;
        private Panel panel3;
        private Panel panel_director;
        private Panel panel4;
        private Button vizualizare_Reparatie;
        private Button stocul_pieselor;
        private Button cauta_Vanzare;
        private Button monitorizare_vanzatori;
        private Button monitorizare_mecanici;
        private Button ads_client;
        private Button adauga_mecanic;
        private Button adauga_vanzator;
        private DataGridView dataGridView3;
        private Button cauta_clienti;
        private TextBox textBox3;
        private Button stergi_piesa;
        private Button stergi_fabricant;
        private Button stergi_supplier;
        private Button stergi_dispozitiv;
        private Button stergi_client;
        private Button stergi_mecanic;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Button button25;
        private Button button26;
        private Button button28;
        private Button button27;
        private DataGridView dataGridView4;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button29;
        private Button button14;
        private Button button12;
        private Button button30;
        private Button button33;
        private Button button32;
        private Button button31;
    }
}

