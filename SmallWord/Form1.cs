using SmallWord.controllers;
using SmallWord.interfaces;
using SmallWord.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallWord
{
    public partial class Form1 : Form
    {
        AnimalControllers animalController = new AnimalControllers();
        List<IAnimals> animals = new List<IAnimals>(); 
        public Form1()
        {
            InitializeComponent();
            panelFood.Visible = false;
            panelAnimal.Visible = false;


        }

        void add_animals(IAnimals animal)
        {
            animals.Add(animal);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (cmbAnimalFood.Text == "Animal")
            {
                panelAnimal.Visible = true;
                panelFood.Visible = false;
                cmbTypeDiet.Items.Add(new Type_Carnivore());
                cmbTypeDiet.Items.Add(new Type_Hervivorous());
                cmbTypeDiet.Items.Add(new Type_Omnivorous());

                btnSave_Click(sender, e);

            }
            else
            {
                panelAnimal.Visible = false;
                panelFood.Visible = true;

            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbTypeSpecie.Text == "Acuatico")
            {
                Acuatic acuatic = animalController.CreateAmimalsAcuatic(0, txtSpecie.Text,
                Convert.ToInt32(txtAge.Text),
                Convert.ToDecimal(txtWeigth.Text),
                (ItypeFood)cmbTypeDiet.SelectedItem,
                100, 0, 0);
                animals.Add(acuatic);     
                lblCreate.Text = acuatic.ToString();

            }
            if (cmbTypeSpecie.Text == "Terrestre")
            {
                Terrestrial terrestrial = animalController.CreateAmimalsTerrestrial(0, txtSpecie.Text,
                Convert.ToInt32(txtAge.Text),
                Convert.ToDecimal(txtWeigth.Text),
                (ItypeFood)cmbTypeDiet.SelectedItem,
                100, 0, 0);
                animals.Add(terrestrial);
                lblCreate.Text = terrestrial.ToString();
            }
            if (cmbTypeSpecie.Text == "Aeroterrestre")
            {
                AeroTerrestrial aeroterrestrial = animalController.CreateAmimalsAeroTerrestrial(0, txtSpecie.Text,
                Convert.ToInt32(txtAge.Text),
                Convert.ToDecimal(txtWeigth.Text),
                (ItypeFood)cmbTypeDiet.SelectedItem,
                100, 0, 0);
                animals.Add(aeroterrestrial);
                lblCreate.Text = aeroterrestrial.ToString();
            }

        }

        private void showList()
        {
            foreach (var animal in animals)
            {
               animal.ToString();
            }
        }

        private void btnSaveFood_Click(object sender, EventArgs e)
        {
            comb
        }

        private void InitializeComponent()
        {
            this.panelAnimal = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWeigth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpecie = new System.Windows.Forms.TextBox();
            this.lblSpecie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTypeDiet = new System.Windows.Forms.ComboBox();
            this.cmbTypeSpecie = new System.Windows.Forms.ComboBox();
            this.groupBoxCrud = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cmbAnimalFood = new System.Windows.Forms.ComboBox();
            this.panelFood = new System.Windows.Forms.Panel();
            this.btnSaveFood = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCreate = new System.Windows.Forms.Label();
            this.panelAnimal.SuspendLayout();
            this.groupBoxCrud.SuspendLayout();
            this.panelFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAnimal
            // 
            this.panelAnimal.Controls.Add(this.btnSave);
            this.panelAnimal.Controls.Add(this.label4);
            this.panelAnimal.Controls.Add(this.txtWeigth);
            this.panelAnimal.Controls.Add(this.label3);
            this.panelAnimal.Controls.Add(this.txtAge);
            this.panelAnimal.Controls.Add(this.label2);
            this.panelAnimal.Controls.Add(this.txtSpecie);
            this.panelAnimal.Controls.Add(this.lblSpecie);
            this.panelAnimal.Controls.Add(this.label1);
            this.panelAnimal.Controls.Add(this.cmbTypeDiet);
            this.panelAnimal.Controls.Add(this.cmbTypeSpecie);
            this.panelAnimal.Location = new System.Drawing.Point(299, 12);
            this.panelAnimal.Name = "panelAnimal";
            this.panelAnimal.Size = new System.Drawing.Size(471, 133);
            this.panelAnimal.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(382, 107);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo de Dieta:";
            // 
            // txtWeigth
            // 
            this.txtWeigth.Location = new System.Drawing.Point(48, 62);
            this.txtWeigth.Name = "txtWeigth";
            this.txtWeigth.Size = new System.Drawing.Size(43, 22);
            this.txtWeigth.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Altura:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(144, 62);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(50, 22);
            this.txtAge.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Años:";
            // 
            // txtSpecie
            // 
            this.txtSpecie.Location = new System.Drawing.Point(340, 18);
            this.txtSpecie.Name = "txtSpecie";
            this.txtSpecie.Size = new System.Drawing.Size(100, 22);
            this.txtSpecie.TabIndex = 4;
            // 
            // lblSpecie
            // 
            this.lblSpecie.AutoSize = true;
            this.lblSpecie.Location = new System.Drawing.Point(265, 21);
            this.lblSpecie.Name = "lblSpecie";
            this.lblSpecie.Size = new System.Drawing.Size(60, 16);
            this.lblSpecie.TabIndex = 3;
            this.lblSpecie.Text = "Especie:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de especie:";
            // 
            // cmbTypeDiet
            // 
            this.cmbTypeDiet.FormattingEnabled = true;
            this.cmbTypeDiet.Location = new System.Drawing.Point(319, 60);
            this.cmbTypeDiet.Name = "cmbTypeDiet";
            this.cmbTypeDiet.Size = new System.Drawing.Size(121, 24);
            this.cmbTypeDiet.TabIndex = 1;
            // 
            // cmbTypeSpecie
            // 
            this.cmbTypeSpecie.FormattingEnabled = true;
            this.cmbTypeSpecie.Items.AddRange(new object[] {
            "Acuatico",
            "Terrestre",
            "Aeroterrestre"});
            this.cmbTypeSpecie.Location = new System.Drawing.Point(118, 18);
            this.cmbTypeSpecie.Name = "cmbTypeSpecie";
            this.cmbTypeSpecie.Size = new System.Drawing.Size(121, 24);
            this.cmbTypeSpecie.TabIndex = 0;
            // 
            // groupBoxCrud
            // 
            this.groupBoxCrud.Controls.Add(this.btnCreate);
            this.groupBoxCrud.Controls.Add(this.cmbAnimalFood);
            this.groupBoxCrud.Location = new System.Drawing.Point(13, 5);
            this.groupBoxCrud.Name = "groupBoxCrud";
            this.groupBoxCrud.Size = new System.Drawing.Size(280, 140);
            this.groupBoxCrud.TabIndex = 1;
            this.groupBoxCrud.TabStop = false;
            this.groupBoxCrud.Text = "CRUD";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(186, 21);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cmbAnimalFood
            // 
            this.cmbAnimalFood.FormattingEnabled = true;
            this.cmbAnimalFood.Items.AddRange(new object[] {
            "Animal",
            "Alimento"});
            this.cmbAnimalFood.Location = new System.Drawing.Point(19, 62);
            this.cmbAnimalFood.Name = "cmbAnimalFood";
            this.cmbAnimalFood.Size = new System.Drawing.Size(121, 24);
            this.cmbAnimalFood.TabIndex = 0;
            // 
            // panelFood
            // 
            this.panelFood.Controls.Add(this.btnSaveFood);
            this.panelFood.Controls.Add(this.label5);
            this.panelFood.Controls.Add(this.textBox1);
            this.panelFood.Controls.Add(this.label6);
            this.panelFood.Controls.Add(this.textBox2);
            this.panelFood.Controls.Add(this.label7);
            this.panelFood.Controls.Add(this.comboBox1);
            this.panelFood.Location = new System.Drawing.Point(299, 151);
            this.panelFood.Name = "panelFood";
            this.panelFood.Size = new System.Drawing.Size(471, 133);
            this.panelFood.TabIndex = 2;
            // 
            // btnSaveFood
            // 
            this.btnSaveFood.Location = new System.Drawing.Point(376, 93);
            this.btnSaveFood.Name = "btnSaveFood";
            this.btnSaveFood.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFood.TabIndex = 2;
            this.btnSaveFood.Text = "Guardar";
            this.btnSaveFood.UseVisualStyleBackColor = true;
            this.btnSaveFood.Click += new System.EventHandler(this.btnSaveFood_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo de alimento:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nombre:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(343, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 22);
            this.textBox2.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Calorias:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(197, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Location = new System.Drawing.Point(12, 172);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(19, 16);
            this.lblCreate.TabIndex = 3;
            this.lblCreate.Text = "....";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(782, 495);
            this.Controls.Add(this.lblCreate);
            this.Controls.Add(this.panelFood);
            this.Controls.Add(this.groupBoxCrud);
            this.Controls.Add(this.panelAnimal);
            this.Name = "Form1";
            this.panelAnimal.ResumeLayout(false);
            this.panelAnimal.PerformLayout();
            this.groupBoxCrud.ResumeLayout(false);
            this.panelFood.ResumeLayout(false);
            this.panelFood.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
    } 
                
}

