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
        int id=-1;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Client_Click(object sender, EventArgs e)
        {
            if(a!=null)
            a.Visible = false;
            a = panel_client;
            panel_client.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // System.Windows.Forms.MessageBox.Show("My message here");
            Form2 dialog1 = new Form2(0);///numeclient
            dialog1.ShowDialog();
            variable1=dialog1.variable1;

            //var projection = from emp in dbContext.proprietars
            //                 join dealer in dbContext.mecanics on emp.masinas equals dealer.ID
            //                 select contact;


            //List <bazededate.reparatie> list = projection.ToList();
            //var  projection = from rep in dbContext.reparaties
            //                    select rep;
            var projection = (from rep in dbContext.reparaties
                              join oper in dbContext.operaties on rep.id equals oper.fk_reparatie
                              join mecan in dbContext.mecanics on oper.fk_mecanic equals mecan.id
                              where rep.fk_masina == variable1
                              select new { IdReparatie = rep.id, NumeMecanic = mecan.nume + mecan.prenume ,DescriereReparatie = rep.descriere,DescriereOperatie = oper.descriere }).ToList();
            //  List<bazededate.reparatie> list =
            //var projector = from emp in dbContext.proprietars
            //                select emp;
            //                 join dealer in dbContext.mecanics on emp.masinas equals dealer.ID
            //                 select contact;
            dataGridView4.DataSource = projection;

            //dataGridView4.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
           // dataGridView4.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
           // dataGridView4.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView4.AutoResizeColumns();
            dataGridView4.Visible = true;
      

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 dialog1 = new Form2(1);//vinclient
            dialog1.ShowDialog();
            variable1 = dialog1.variable1;
            variable2 = dialog1.variable2;

            //// Prompt.ShowDialog("stuff", "caption");
            ////var queryLondonCustomers = from cust in
            ////                               // where cust.City == "London"
            ////                           select cust;

            //dataGridView1.DataSource = queryLondonCustomers;
            var projection = (from rep in dbContext.reparaties
                              join oper in dbContext.operaties on rep.id equals oper.fk_reparatie
                              join mecan in dbContext.mecanics on oper.fk_mecanic equals mecan.id
                              join masin in dbContext.masinas on rep.fk_masina equals masin.vin
                              join prop in dbContext.proprietars on masin.fk_proprietar equals prop.id
                              where prop.nume == variable1 && prop.prenume==variable2
                              select new { IdReparatie = rep.id,Idmasina=masin.vin, NumeMecanic = mecan.nume + mecan.prenume, DescriereReparatie = rep.descriere, DescriereOperatie = oper.descriere }).ToList();
            //  List<bazededate.reparatie> list =
            //var projector = from emp in dbContext.proprietars
            //                select emp;
            //                 join dealer in dbContext.mecanics on emp.masinas equals dealer.ID
            //                 select contact;
            dataGridView4.DataSource = projection;

            //dataGridView4.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridView4.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridView4.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridView4.AutoResizeColumns();
            dataGridView4.Visible = true;
        }

        private void mecanic_Click(object sender, EventArgs e)
        {
            Form2 dialog1 = new Form2(3);//vinclient
            dialog1.ShowDialog();
            name = dialog1.variable1;
            pass = dialog1.variable2;
           
           
            var projection = (from rep in dbContext.mecanics
                              where name==rep.nume.Replace(" ",string.Empty)+" "+rep.prenume.Replace(" ", string.Empty)


                              select new {parola = rep.password ,name=rep.nume ,prenume=rep.prenume,id=rep.id}).ToList();
            if(projection.Count()>0)
            if(projection[0].parola==null)
            {
                dbContext.add_password_mecanic(pass, projection[0].name, projection[0].prenume);
                  //  id = projection[0].id;
            }
            else
            {
                if(projection[0].parola.Replace(" ",string.Empty)==pass)
                {
                        id = projection[0].id;
                        label4.Text = "ID:" + id;
                        
                        if (a != null)
                        a.Visible = false;
                    a = panel_mecanic;
                    panel_mecanic.Visible = true;
                }
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 dialog1 = new Form2(3);//vinclient
            dialog1.ShowDialog();
            name = dialog1.variable1;
            pass = dialog1.variable2;


            var projection = (from rep in dbContext.vanzators
                              where name == rep.nume.Replace(" ", string.Empty) + " " + rep.prenume.Replace(" ", string.Empty)


                              select new { parola = rep.parola, name = rep.nume, prenume = rep.prenume,id=rep.id }).ToList();
            if (projection.Count() > 0)
                if (projection[0].parola == null)
                {
                    dbContext.add_password_(pass, projection[0].name, projection[0].prenume);
                }
                else
                {
                    id = projection[0].id;
                    label5.Text = "ID:" + id;
                    if (projection[0].parola.Replace(" ", string.Empty) == pass)
                    {
                        if (a != null)
                            a.Visible = false;
                        a = panel_vanz;
                        panel_vanz.Visible = true;
                    }
                }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 dialog1 = new Form2(3);//vinclient
            dialog1.ShowDialog();
            name = dialog1.variable1;
            pass = dialog1.variable2;


            var projection = (from rep in dbContext.director_tehnics
                              where name == rep.nume.Replace(" ", string.Empty) + " " + rep.prenume.Replace(" ", string.Empty)


                              select new { parola = rep.password, name = rep.nume, prenume = rep.prenume ,id=rep.id}).ToList();
            if (projection.Count() > 0)
                if (projection[0].parola == null)
                {
                    
                    dbContext.add_password_dir_tehnic(pass, projection[0].name, projection[0].prenume);
                }
                else
                {
                    if (projection[0].parola.Replace(" ", string.Empty) == pass)
                    {
                        id = projection[0].id;
                        label6.Text = "ID:" + id;
                        if (a != null)
                            a.Visible = false;
                        a = panel_director;
                        panel_director.Visible = true;
                    }
                }
        }

        private void vezi_dispozitive_Click(object sender, EventArgs e)
        {
            var projection = (from rep in dbContext.dispozitivs
                              join brev in dbContext.tip_brevets on rep.brevet_necesar equals brev.id
                                    
                             
                              select new { DispozitivId=rep.id,DispozitivNume=rep.nume,TipBrevet=brev.tip }).ToList();
            dataGridView1.DataSource = projection;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            var projection = (from rep in dbContext.brevet_dispozitivs
                              join mecs in dbContext.mecanics on rep.fk_mecanic equals mecs.id
                              join brev in dbContext.tip_brevets on rep.tipbrevet equals brev.id
                              where mecs.nume.Replace(" ", "")+" "+mecs.prenume.Replace(" ", "") == name


                              select new { brev.tip,brev.id }).ToList();
            dataGridView1.DataSource = projection;
        }

        private void cauta_dispozitiv_Click(object sender, EventArgs e)
        {
            var projection = (from rep in dbContext.dispozitivs
                              join brev in dbContext.tip_brevets on rep.brevet_necesar equals brev.id
                              where rep.nume == textBox1.Text

                              select new { DispozitivId = rep.id, DispozitivNume = rep.nume, TipBrevet = brev.tip }).ToList();
            dataGridView1.DataSource = projection;
        }

        private void Cauta_masina_Click(object sender, EventArgs e)
        {
            var projection = (from rep in dbContext.masinas 
                              join proprietarul in dbContext.proprietars on rep.fk_proprietar equals proprietarul.id
                              join tipul in dbContext.tips on rep.fk_tip equals tipul.id
                              join fabric in dbContext.fabricants on rep.fk_brand equals fabric.id
                              where rep.vin == textBox1.Text

                              select new { NumeProprietar=proprietarul.nume+proprietarul.prenume,TelefonProprietar=proprietarul.telefon,NumeFabricant=fabric.nume,NumarTelefonFabricant=fabric.nr_telefon,TipulMasinii=tipul.nume }).ToList();
            dataGridView1.DataSource = projection;
        }

        private void button13_Click(object sender, EventArgs e)
        {

            var projection = (from rep in dbContext.masinas
                              join repas in dbContext.reparaties on rep.vin equals repas.fk_masina
                              join oper in dbContext.operaties on repas.id equals oper.fk_reparatie
                              join mecan in dbContext.mecanics on oper.fk_mecanic equals mecan.id
                              where rep.vin == textBox1.Text

                              select new { IdReparatie = repas.id, NumeMecanic = mecan.nume + mecan.prenume, DescriereReparatie = repas.descriere, DescriereOperatie = oper.descriere }).ToList();
            dataGridView1.DataSource = projection;
        }

        private void descrierea_reparatiei_Click(object sender, EventArgs e)
        {
            var projection = (from repas in dbContext.reparaties
                              
                              join oper in dbContext.operaties on repas.id equals oper.fk_reparatie
                              join mecan in dbContext.mecanics on oper.fk_mecanic equals mecan.id
                              where repas.id == Int32.Parse(textBox1.Text)

                              select new { IdReparatie = repas.id, NumeMecanic = mecan.nume + mecan.prenume, DescriereReparatie = repas.descriere, DescriereOperatie = oper.descriere }).ToList();
            dataGridView1.DataSource = projection;
        }

        private void display_repairs_Click(object sender, EventArgs e)
        {
            var projection = (from rep in dbContext.masinas
                              join repas in dbContext.reparaties on rep.vin equals repas.fk_masina
                             
                            

                              select new { IdReparatie = repas.id, DescriereReparatie = repas.descriere,VinMasina = repas.fk_masina }).ToList();
            dataGridView1.DataSource = projection;
        }

        private void add_client_Click(object sender, EventArgs e)
        {
            Form2 dialog1 = new Form2(4);//vinclient
            dialog1.ShowDialog();
            variable1= dialog1.variable1;
            variable2 = dialog1.variable2;
            variable3 = dialog1.variable3;
            variable4 = dialog1.variable4;
            proprietar nou = new proprietar();
            nou.telefon = variable3;
             nou.nume = variable1;
            nou.prenume = variable2;
            nou.nrcard = variable4;
            dbContext.proprietars.InsertOnSubmit(nou);
            dbContext.SubmitChanges();
            var projection = (from pro in dbContext.proprietars
                              select pro).ToList();




             dataGridView1.DataSource = projection;

        }

        private void add_masina_Click(object sender, EventArgs e)
        {
            Form2 dialog1 = new Form2(5);//vinclient
            dialog1.ShowDialog();
            variable1 = dialog1.variable1;
            variable2 = dialog1.variable2;
            variable3 = dialog1.variable3;
            variable4 = dialog1.variable4;
            variable5 = dialog1.variable5;
           
            string a, b, c;
            var projection5 = (from rep in dbContext.masinas //verific tipul
                              where rep.vin == variable1
                              select rep.vin).ToList();
            
            if (projection5.Count() != 0)
            {
                MessageBox.Show("Insert right stuff for this to work1.");
                return;
            }
            var projection = (from rep in dbContext.tips //verific tipul
                              where rep.nume == variable3
                              select rep.id).ToList();
            if(projection.Count()==0)
            {
                MessageBox.Show("Insert right stuff for this to work3.");
                return;
            }
            var projection2 = (from rep in dbContext.fabricants//verific fabricantul
                              where rep.nume == variable4
                              select rep.id).ToList();
            if (projection2.Count() == 0)
            {
                MessageBox.Show("Insert right stuff for this to work4.");
                return;
            }
            var projection4 = (from rep in dbContext.proprietars//verific proprietarul
                               where Int32.Parse(variable5)==rep.id
                                 select rep.nume).ToList();
            if (projection4.Count() == 0)
            {
                MessageBox.Show("Insert right stuff for this to work5.");
                return;
            }
            masina nou = new masina();
            nou.vin = variable1;
            nou.culoare = variable2;
            nou.fk_tip = projection[0];
            nou.fk_brand = projection2[0];
            nou.fk_proprietar = Int32.Parse(variable5);
            dbContext.masinas.InsertOnSubmit(nou);
            dbContext.SubmitChanges();
            var projection3 = (from pro in dbContext.masinas
                              select pro).ToList();




            dataGridView1.DataSource = projection3;
        }

        private void cauta_vin_Click(object sender, EventArgs e)
        {
            var projection = (from rep in dbContext.masinas
                              join repas in dbContext.reparaties on rep.vin equals repas.fk_masina



                              select new { IdReparatie = repas.id, DescriereReparatie = repas.descriere, VinMasina = repas.fk_masina }).ToList();
            dataGridView1.DataSource = projection;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=dbContext.toate_masinile().ToList();
        }

        private void piese_disponibile_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbContext.search_piese_disponibile().ToList();
        }

        private void piese_dupa_nume_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbContext.search_piese_nume(textBox1.Text).ToList();
        }

        private void operatii_masina_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbContext.toate_operatiile_masinii(textBox1.Text).ToList();
        }

        private void adauga_client_Click(object sender, EventArgs e)
        {

            Form2 dialog1 = new Form2(1);//vinclient
            dialog1.ShowDialog();
            variable1 = dialog1.variable1;
            variable2 = dialog1.variable2;//something
            dataGridView1.DataSource = dbContext.cauta_dupa_nume(variable1, variable2).ToList();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Form2 dialog1 = new Form2(15);//====================================add reparatie
            dialog1.ShowDialog();
            variable1 = dialog1.variable1;//id masina
            variable2 = dialog1.variable2;//something//descriere
            dbContext.add_reparatie(variable1, variable2);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Form2 dialog1 = new Form2(14);//====================================add operatie
            dialog1.ShowDialog();
            variable1 = dialog1.variable1;//reparatie
            
            variable3 = dialog1.variable3;//descriere
        
            variable4 = dialog1.variable4;//piesa
            variable5 = dialog1.variable5;//supplier
            if (variable4 =="" || variable5 == "")
                dbContext.add_operatie_withoutp(Int32.Parse(variable1), id, variable3);
            else
            dbContext.add_operatie_withp(Int32.Parse(variable1),id, variable3, variable4, Int32.Parse(variable5));
            
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Form2 dialog1 = new Form2(6);//vinclient
            dialog1.ShowDialog();
            variable1 = dialog1.variable1;//codsa adauge furnizor -----------------------------------------------------------------//something
            variable2 = dialog1.variable2;
            dbContext.add_supplier(variable1, variable2);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Form2 dialog1 = new Form2(6);//vinclient
            dialog1.ShowDialog();
            variable1 = dialog1.variable1;//codsa adauge fabricant -----------------------------------------------------------------//something
            variable2 = dialog1.variable2;
            dbContext.Add_fabricant(variable1, variable2);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form2 dialog1 = new Form2(18);//vinclient
            dialog1.ShowDialog();
            variable1 = dialog1.variable1;
            variable2 = dialog1.variable2;


            dataGridView2.DataSource = dbContext.cauta_piese_dupa_clienti(variable1,variable2);
            //-------------------------------------------------------------------cauta piese dupa clienti
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form2 dialog1 = new Form2(7);//vinclient
            dialog1.ShowDialog();
            variable1 = dialog1.variable1;//codsa adauge fabricant ----
            variable2 = dialog1.variable2;
            dbContext.Add_fabricant(variable1, variable2);
            //---7
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form2 dialog1 = new Form2(8);//vinclient
            dialog1.ShowDialog();
            variable1 = dialog1.variable1;
            dbContext.Add_tipmasina(variable1);
            //addtipuri....masini----------------------------------
        }

        private void button17_Click(object sender, EventArgs e)
        {

            variable1 = textBox2.Text;
           dataGridView2.DataSource= dbContext.cauta_piese_dupa_nume(variable1).ToList();
            //cauta piese dupa nume

        }

        private void button18_Click(object sender, EventArgs e)
        {
            variable1 = textBox2.Text;
            dataGridView2.DataSource = dbContext.cauta_piese_dupa_furnizor(variable1).ToList();
            //cauta piese dupa furnizor  -----------------------------------------
        }

        private void button19_Click(object sender, EventArgs e)
        {


            var projection = dbContext.toate_piesele_vandute().ToList();
            dataGridView2.DataSource = projection;

            //toate piesele vandute---------------------------------------------------
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 dialog1 = new Form2(4);//vinclient
            dialog1.ShowDialog();
            variable1 = dialog1.variable1;
            variable2 = dialog1.variable2;
            variable3 = dialog1.variable3;
            variable4 = dialog1.variable4;
            proprietar nou = new proprietar();
            nou.telefon = variable3;
            nou.nume = variable1;
            nou.prenume = variable2;
            nou.nrcard = variable4;
            dbContext.proprietars.InsertOnSubmit(nou);
            dbContext.SubmitChanges();
            var projection = (from pro in dbContext.proprietars
                              select pro).ToList();




            dataGridView1.DataSource = projection;
            //add client---------------------------------------------------
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 dialog1 = new Form2(9);//vinclient
            dialog1.ShowDialog();
            variable1 = dialog1.variable1;
            variable2 = dialog1.variable2;
            variable3 = dialog1.variable3;
            dbContext.add_piese(variable1, Int32.Parse(variable2), Int32.Parse(variable3));
            //add piese--------------------------------------------------------
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = dbContext.vezi_vanzare().ToList();
            //----------------------------------------vezi vanzari
        }

        private void button11_Click(object sender, EventArgs e)
        {

            var projection = (from rep in dbContext.proprietars

                              select rep).ToList();
            dataGridView2.DataSource = projection;
            //-----------------------------toti clientii
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form2 dialog1 = new Form2(18);//vinclient
            dialog1.ShowDialog();
            variable1 = dialog1.variable1;
            variable2 = dialog1.variable2;
            dataGridView2.DataSource =dbContext.cauta_client(variable1,variable2);
            //--------cauta client dupa nume
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var projection = (from rep in dbContext.piesas

                              select rep).ToList();
            dataGridView2.DataSource = projection;
            //---------------------------toate piesele
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            Form2 dialog1 = new Form2(10);//vinclient
            dialog1.ShowDialog();
            variable1 = dialog1.variable1;
            variable2 = dialog1.variable2;
            variable3 = dialog1.variable3;
            variable4 = dialog1.variable4;
            dbContext.Add_Vanzare(id, Int32.Parse(variable1), variable2, Int32.Parse(variable3), Int32.Parse(variable4));
            //vanzare vnz = new vanzare
            //{
            //    fk_angajat = id,
            //    fk_proprietar = Int32.Parse(variable1),
            //    fk_nume_piesa = variable2,
            //    amount = Int32.Parse(variable3),
            //    fk_supplier_piesa= Int32.Parse(variable4)
            //    // …
            //};

            //// Add the new object to the Orders collection.
            //dbContext.vanzares.InsertOnSubmit(vnz);
            //dbContext.SubmitChanges();
            //// Submit the change to the database.
            ////  try
            ////   {
            ////     dbContext.SubmitChanges();
            ////  }
            //// catch (exception a)
            ////  {
            //// }/*Exception e)
            //// {
            ////  Console.WriteLine(e);
            //// Make some adjustments.
            //// ...
            //// Try again.
            ////  db.SubmitChanges();
            ////  }*/
            ////addvanzare--------------------------------------------------------
        }

        private void adauga_vanzator_Click(object sender, EventArgs e)
        {
            Form2 dialog1 = new Form2(11);//vinclient
            dialog1.ShowDialog();
            variable1 = dialog1.variable1;
            variable2 = dialog1.variable2;
            
            variable4 = dialog1.variable4;
            DateTime localDate = DateTime.Now;
            dbContext.adauga_vanzator(variable1, variable2, localDate,decimal.Parse(variable4), id);
            //add vanzator-------------------------------------------------------
        }

        private void adauga_mecanic_Click(object sender, EventArgs e)
        {
            int id = 0;
            Form2 dialog1 = new Form2(12);//vinclient
            dialog1.ShowDialog();
            variable1 = dialog1.variable1;
            variable2 = dialog1.variable2;
            variable3 = dialog1.variable3;
            variable4 = dialog1.variable4;
            dbContext.adauga_mecanic(variable1, variable2, variable3, DateTime.ParseExact(variable4, "mm dd yyyy", CultureInfo.InvariantCulture), id);
            //add_mecnic------------------------------------------
        }

        private void ads_client_Click(object sender, EventArgs e)
        {

            Form2 dialog1 = new Form2(13);//vinclient
            dialog1.ShowDialog();
            variable1 = dialog1.variable1;
            variable2 = dialog1.variable2;
            variable3 = dialog1.variable3;
            variable4 = dialog1.variable4;
            dbContext.Add_Client(variable1, variable2, variable3, variable4);
            //---------------------------------------------------add client
        }

        private void monitorizare_vanzatori_Click(object sender, EventArgs e)
        {
            var projection = (from rep in dbContext.vanzares

                                  // join des in dbContext.piesas
                                  // on new { repas.fk_nume_piesa,repas.fk_supplier_piesa } equals new { des.nume,des.fk_supplier } 



                              select rep).ToList();
            dataGridView3.DataSource = projection;
            //------------------------afisare vanzari
        }

        private void cauta_Vanzare_Click(object sender, EventArgs e)
        {
            variable1=textBox3.Text;//vanzari dupa vanzatori
            int v = Int32.Parse(textBox3.Text);
          
        }

        private void stocul_pieselor_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = dbContext.Stocul_pieselor().ToList(); 

            //stocul pieselor
        }

        private void vizualizare_Reparatie_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = dbContext.Stocul_pieselor().ToList();
            //---------------------------viazualizare reparatii
        }

        private void stergi_supplier_Click(object sender, EventArgs e)
        {
            variable1 = textBox3.Text;
            dbContext.stergi_supplier(variable1);
            //-------------------------------stergi supplier
        }

        private void cauta_clienti_Click(object sender, EventArgs e)
        {
            Form2 dialog1 = new Form2(18);//vinclient
            dialog1.ShowDialog();
            variable1 = dialog1.variable1;
            variable2 = dialog1.variable2;
            dbContext.cauta_client(variable1,variable2);
            //--------------------------------------cauta client
        }

        private void stergi_mecanic_Click(object sender, EventArgs e)
        {
            variable1 = textBox3.Text;
            dbContext.stergi_mecanic(Int32.Parse(variable1));
            //--------------------------stergi mecanic
        }

        private void stergi_client_Click(object sender, EventArgs e)
        {
            Form2 dialog1 = new Form2(18);//vinclient
            dialog1.ShowDialog();
            variable1 = dialog1.variable1;
            variable2 = dialog1.variable2;
            dbContext.stergi_proprietar(variable1,variable2);
            //--------------------------stergi client
        }

        private void stergi_dispozitiv_Click(object sender, EventArgs e)
        {
            variable1 = textBox3.Text;
            dbContext.stergi_dispozitiv(Int32.Parse(variable1));
            //--------------------------stergi dispozitiv
        }

        private void stergi_piesa_Click(object sender, EventArgs e)
        {
            Form2 dialog1 = new Form2(17);//vinclient
            dialog1.ShowDialog();
            variable1 = dialog1.variable1;
            variable2 = dialog1.variable2;
            dbContext.stergi_piesa(variable1,Int32.Parse(variable2));
            //--------------------------stergi piesa
        }

        private void stergi_fabricant_Click(object sender, EventArgs e)
        {
            variable1 = textBox3.Text;
            dbContext.stergi_fabricant(variable1);
            //--------------------------stergi fabricant
        }

        private void Adaugare_brevet_Click(object sender, EventArgs e)
        {
            int idmec;
            Form2 dialog1 = new Form2(16);//vinclient
            dialog1.ShowDialog();
            variable1 = dialog1.variable1;
            dbContext.addtipbrevet(variable1);
                                                ////////////// -add brevet
        }

        private void button29_Click(object sender, EventArgs e)
        {
            variable1 = textBox1.Text;//text                    piesa dupa supplier
           
            var projection = (from rep in dbContext.piesas
                              join repas in dbContext.suppliers on rep.fk_supplier equals repas.id
                              // join des in dbContext.piesas
                              // on new { repas.fk_nume_piesa,repas.fk_supplier_piesa } equals new { des.nume,des.fk_supplier } 


                              where repas.nume.Replace(" ", string.Empty) == variable1
                              select new { rep.nume,rep.cantitate,supplier=repas.nume,supplier_id=repas.id }).ToList();
            dataGridView1.DataSource = projection;
        }

        private void button30_Click(object sender, EventArgs e)
        {

            var projection = (from rep in dbContext.piesas
                              join repas in dbContext.suppliers on rep.fk_supplier equals repas.id
                              // join des in dbContext.piesas
                              // on new { repas.fk_nume_piesa,repas.fk_supplier_piesa } equals new { des.nume,des.fk_supplier } 


                              
                              select new { rep.nume, rep.cantitate, supplier = repas.nume, supplier_id = repas.id }).ToList();
            dataGridView1.DataSource = projection;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var projection = (from rep in dbContext.piesas
                             
                              // join des in dbContext.piesas
                              // on new { repas.fk_nume_piesa,repas.fk_supplier_piesa } equals new { des.nume,des.fk_supplier } 



                              select new { rep.nume,rep.fk_supplier,rep.cantitate }).ToList();
            dataGridView1.DataSource = projection;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var projection = (from rep in dbContext.mecanics

                                  // join des in dbContext.piesas
                                  // on new { repas.fk_nume_piesa,repas.fk_supplier_piesa } equals new { des.nume,des.fk_supplier } 



                              select  rep).ToList();
            dataGridView1.DataSource = projection;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //-------------------------------------------vazi masini nereparate

           dataGridView1.DataSource= dbContext.Masini_Nereparate().ToList();

            // var projection = (db

            // /
            //                 select rep).ToList();
            //
            // dataGridView1.DataSource = projection;
        }
    }

}
