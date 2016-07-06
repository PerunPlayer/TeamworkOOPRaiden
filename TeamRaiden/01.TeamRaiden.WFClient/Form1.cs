using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamRaiden.Core.Infrastructure.Classes;
using TeamRaiden.Core.Infrastructure.Enumerations;
using TeamRaiden.Core.Infrastructure.Structs;

namespace _01.TeamRaiden.WFClient
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        //Adding Teams Info

        private void MainForm(object sender, EventArgs e)
        {
            
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
                       
            //Add All Team in each DropDown
            foreach (var dropdown in AllDropDowns())
            {
                foreach (var team in AllTeams())
                {
                    dropdown.Items.Add(team);
                }
            }

            Image image = Image.FromFile(@"..\..\Images\info-button.jpg");            
            pictureBox1.Image = image;

        }


        public List<ComboBox> AllDropDowns()
        {

            return new List<ComboBox>()
            {
               groupATeam1, groupATeam2, groupATeam3, groupATeam4,
               groupBTeam1, groupBTeam2, groupBTeam3, groupBTeam4,
               groupCTeam1, groupCTeam2, groupCTeam3, groupCTeam4,
               groupDTeam1, groupDTeam2, groupDTeam3, groupDTeam4,
            };
        }

        public List<string> AllTeams()
        {
            return new List<string>()
            {
               "NotSet","Albania","Andorra","Armenia","Austria","Azerbaijan","Belarus","Belgium","BosniaAndHerzegovina",
               "Bulgaria","Croatia","Cyprus","CzechRepublic","Denmark","England","Estonia","FaroeIslands","Finland",
               "France","Gerogia","Germany","Bibraltar","Greece","Hungary","Iceland","Ireland","Israel","Italy",
               "Kazakhstan","Kosovo","Latvia","Leichtenstein","Lithuania","Luxemburg","Macedonia","Malta","Moldova",
               "Montenegro","Netherlands","NorthernIreland","Norway","Poland","Portugal","Romania","Russia","SanMarino",
               "Scotland","Serbia","Slovakia","Slovenia","Spain","Sweden","Switzerland","Turkey","Ukraine","Wales"
            };
        }

        private void DropDown_Change(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            var index = box.SelectedIndex;

            
            foreach (var dropdown in AllDropDowns())
            {
                if (box != dropdown)
                {
                    if (box.SelectedIndex == dropdown.SelectedIndex)
                    {
                        dropdown.SelectedIndex = -1;
                    }
                }
            }
        }

        private void teamInfoClick(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            teamInfoLabel.Text = box.AccessibleName;
            teamInfoLabel.Show();
            List<ComboBox> allDropDowns = AllDropDowns();
            var a = allDropDowns[int.Parse(box.AccessibleName)].SelectedIndex;
        }
        //IMPORTANT !!!
        //DO NOT DELETE OR EDIT THE BELOW METHOD AND REGION
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelA = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupATeam4 = new System.Windows.Forms.ComboBox();
            this.groupATeam3 = new System.Windows.Forms.ComboBox();
            this.groupATeam2 = new System.Windows.Forms.ComboBox();
            this.groupATeam1 = new System.Windows.Forms.ComboBox();
            this.panelB = new System.Windows.Forms.Panel();
            this.groupBTeam4 = new System.Windows.Forms.ComboBox();
            this.groupBTeam3 = new System.Windows.Forms.ComboBox();
            this.groupBTeam2 = new System.Windows.Forms.ComboBox();
            this.groupBTeam1 = new System.Windows.Forms.ComboBox();
            this.panelC = new System.Windows.Forms.Panel();
            this.groupCTeam4 = new System.Windows.Forms.ComboBox();
            this.groupCTeam3 = new System.Windows.Forms.ComboBox();
            this.groupCTeam2 = new System.Windows.Forms.ComboBox();
            this.groupCTeam1 = new System.Windows.Forms.ComboBox();
            this.panelD = new System.Windows.Forms.Panel();
            this.groupDTeam4 = new System.Windows.Forms.ComboBox();
            this.groupDTeam3 = new System.Windows.Forms.ComboBox();
            this.groupDTeam2 = new System.Windows.Forms.ComboBox();
            this.groupDTeam1 = new System.Windows.Forms.ComboBox();
            this.panelE = new System.Windows.Forms.Panel();
            this.groupETeam4 = new System.Windows.Forms.ComboBox();
            this.groupETeam3 = new System.Windows.Forms.ComboBox();
            this.groupETeam2 = new System.Windows.Forms.ComboBox();
            this.groupETeam1 = new System.Windows.Forms.ComboBox();
            this.panelF = new System.Windows.Forms.Panel();
            this.groupFTeam4 = new System.Windows.Forms.ComboBox();
            this.groupFTeam3 = new System.Windows.Forms.ComboBox();
            this.groupFTeam2 = new System.Windows.Forms.ComboBox();
            this.groupFTeam1 = new System.Windows.Forms.ComboBox();
            this.LabelGroupA = new System.Windows.Forms.Label();
            this.LabelGroupB = new System.Windows.Forms.Label();
            this.LabelGroupC = new System.Windows.Forms.Label();
            this.LabelGroupD = new System.Windows.Forms.Label();
            this.LabelGroupE = new System.Windows.Forms.Label();
            this.LabelGroupF = new System.Windows.Forms.Label();
            this.teamInfoLabel = new System.Windows.Forms.Label();
            this.panelA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelB.SuspendLayout();
            this.panelC.SuspendLayout();
            this.panelD.SuspendLayout();
            this.panelE.SuspendLayout();
            this.panelF.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelA
            // 
            this.panelA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelA.Controls.Add(this.pictureBox1);
            this.panelA.Controls.Add(this.groupATeam4);
            this.panelA.Controls.Add(this.groupATeam3);
            this.panelA.Controls.Add(this.groupATeam2);
            this.panelA.Controls.Add(this.groupATeam1);
            this.panelA.Location = new System.Drawing.Point(12, 19);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(201, 95);
            this.panelA.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleName = "1";
            this.pictureBox1.Location = new System.Drawing.Point(110, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 18);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.teamInfoClick);
            // 
            // groupATeam4
            // 
            this.groupATeam4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupATeam4.FormattingEnabled = true;
            this.groupATeam4.Location = new System.Drawing.Point(3, 69);
            this.groupATeam4.Name = "groupATeam4";
            this.groupATeam4.Size = new System.Drawing.Size(104, 21);
            this.groupATeam4.TabIndex = 5;
            this.groupATeam4.SelectedIndexChanged += new System.EventHandler(this.DropDown_Change);
            // 
            // groupATeam3
            // 
            this.groupATeam3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupATeam3.FormattingEnabled = true;
            this.groupATeam3.Location = new System.Drawing.Point(3, 47);
            this.groupATeam3.Name = "groupATeam3";
            this.groupATeam3.Size = new System.Drawing.Size(104, 21);
            this.groupATeam3.TabIndex = 4;
            this.groupATeam3.SelectedIndexChanged += new System.EventHandler(this.DropDown_Change);
            // 
            // groupATeam2
            // 
            this.groupATeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupATeam2.FormattingEnabled = true;
            this.groupATeam2.Location = new System.Drawing.Point(3, 25);
            this.groupATeam2.Name = "groupATeam2";
            this.groupATeam2.Size = new System.Drawing.Size(104, 21);
            this.groupATeam2.TabIndex = 3;
            this.groupATeam2.SelectedIndexChanged += new System.EventHandler(this.DropDown_Change);
            // 
            // groupATeam1
            // 
            this.groupATeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupATeam1.FormattingEnabled = true;
            this.groupATeam1.Location = new System.Drawing.Point(3, 3);
            this.groupATeam1.Name = "groupATeam1";
            this.groupATeam1.Size = new System.Drawing.Size(104, 21);
            this.groupATeam1.TabIndex = 2;
            this.groupATeam1.SelectedIndexChanged += new System.EventHandler(this.DropDown_Change);
            // 
            // panelB
            // 
            this.panelB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelB.Controls.Add(this.groupBTeam4);
            this.panelB.Controls.Add(this.groupBTeam3);
            this.panelB.Controls.Add(this.groupBTeam2);
            this.panelB.Controls.Add(this.groupBTeam1);
            this.panelB.Location = new System.Drawing.Point(12, 135);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(201, 95);
            this.panelB.TabIndex = 6;
            // 
            // groupBTeam4
            // 
            this.groupBTeam4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupBTeam4.FormattingEnabled = true;
            this.groupBTeam4.Location = new System.Drawing.Point(3, 69);
            this.groupBTeam4.Name = "groupBTeam4";
            this.groupBTeam4.Size = new System.Drawing.Size(104, 21);
            this.groupBTeam4.TabIndex = 5;
            this.groupBTeam4.SelectedIndexChanged += new System.EventHandler(this.DropDown_Change);
            // 
            // groupBTeam3
            // 
            this.groupBTeam3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupBTeam3.FormattingEnabled = true;
            this.groupBTeam3.Location = new System.Drawing.Point(3, 47);
            this.groupBTeam3.Name = "groupBTeam3";
            this.groupBTeam3.Size = new System.Drawing.Size(104, 21);
            this.groupBTeam3.TabIndex = 4;
            this.groupBTeam3.SelectedIndexChanged += new System.EventHandler(this.DropDown_Change);
            // 
            // groupBTeam2
            // 
            this.groupBTeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupBTeam2.FormattingEnabled = true;
            this.groupBTeam2.Location = new System.Drawing.Point(3, 25);
            this.groupBTeam2.Name = "groupBTeam2";
            this.groupBTeam2.Size = new System.Drawing.Size(104, 21);
            this.groupBTeam2.TabIndex = 3;
            this.groupBTeam2.SelectedIndexChanged += new System.EventHandler(this.DropDown_Change);
            // 
            // groupBTeam1
            // 
            this.groupBTeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupBTeam1.FormattingEnabled = true;
            this.groupBTeam1.Location = new System.Drawing.Point(3, 3);
            this.groupBTeam1.Name = "groupBTeam1";
            this.groupBTeam1.Size = new System.Drawing.Size(104, 21);
            this.groupBTeam1.TabIndex = 2;
            this.groupBTeam1.SelectedIndexChanged += new System.EventHandler(this.DropDown_Change);
            // 
            // panelC
            // 
            this.panelC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelC.Controls.Add(this.groupCTeam4);
            this.panelC.Controls.Add(this.groupCTeam3);
            this.panelC.Controls.Add(this.groupCTeam2);
            this.panelC.Controls.Add(this.groupCTeam1);
            this.panelC.Location = new System.Drawing.Point(12, 251);
            this.panelC.Name = "panelC";
            this.panelC.Size = new System.Drawing.Size(201, 95);
            this.panelC.TabIndex = 7;
            // 
            // groupCTeam4
            // 
            this.groupCTeam4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupCTeam4.FormattingEnabled = true;
            this.groupCTeam4.Location = new System.Drawing.Point(3, 69);
            this.groupCTeam4.Name = "groupCTeam4";
            this.groupCTeam4.Size = new System.Drawing.Size(104, 21);
            this.groupCTeam4.TabIndex = 5;
            this.groupCTeam4.SelectedIndexChanged += new System.EventHandler(this.DropDown_Change);
            // 
            // groupCTeam3
            // 
            this.groupCTeam3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupCTeam3.FormattingEnabled = true;
            this.groupCTeam3.Location = new System.Drawing.Point(3, 47);
            this.groupCTeam3.Name = "groupCTeam3";
            this.groupCTeam3.Size = new System.Drawing.Size(104, 21);
            this.groupCTeam3.TabIndex = 4;
            this.groupCTeam3.SelectedIndexChanged += new System.EventHandler(this.DropDown_Change);
            // 
            // groupCTeam2
            // 
            this.groupCTeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupCTeam2.FormattingEnabled = true;
            this.groupCTeam2.Location = new System.Drawing.Point(3, 25);
            this.groupCTeam2.Name = "groupCTeam2";
            this.groupCTeam2.Size = new System.Drawing.Size(104, 21);
            this.groupCTeam2.TabIndex = 3;
            this.groupCTeam2.SelectedIndexChanged += new System.EventHandler(this.DropDown_Change);
            // 
            // groupCTeam1
            // 
            this.groupCTeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupCTeam1.FormattingEnabled = true;
            this.groupCTeam1.Location = new System.Drawing.Point(3, 3);
            this.groupCTeam1.Name = "groupCTeam1";
            this.groupCTeam1.Size = new System.Drawing.Size(104, 21);
            this.groupCTeam1.TabIndex = 2;
            this.groupCTeam1.SelectedIndexChanged += new System.EventHandler(this.DropDown_Change);
            // 
            // panelD
            // 
            this.panelD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelD.Controls.Add(this.groupDTeam4);
            this.panelD.Controls.Add(this.groupDTeam3);
            this.panelD.Controls.Add(this.groupDTeam2);
            this.panelD.Controls.Add(this.groupDTeam1);
            this.panelD.Location = new System.Drawing.Point(12, 366);
            this.panelD.Name = "panelD";
            this.panelD.Size = new System.Drawing.Size(201, 95);
            this.panelD.TabIndex = 8;
            // 
            // groupDTeam4
            // 
            this.groupDTeam4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupDTeam4.FormattingEnabled = true;
            this.groupDTeam4.Location = new System.Drawing.Point(3, 69);
            this.groupDTeam4.Name = "groupDTeam4";
            this.groupDTeam4.Size = new System.Drawing.Size(104, 21);
            this.groupDTeam4.TabIndex = 5;
            this.groupDTeam4.SelectedIndexChanged += new System.EventHandler(this.DropDown_Change);
            // 
            // groupDTeam3
            // 
            this.groupDTeam3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupDTeam3.FormattingEnabled = true;
            this.groupDTeam3.Location = new System.Drawing.Point(3, 47);
            this.groupDTeam3.Name = "groupDTeam3";
            this.groupDTeam3.Size = new System.Drawing.Size(104, 21);
            this.groupDTeam3.TabIndex = 4;
            this.groupDTeam3.SelectedIndexChanged += new System.EventHandler(this.DropDown_Change);
            // 
            // groupDTeam2
            // 
            this.groupDTeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupDTeam2.FormattingEnabled = true;
            this.groupDTeam2.Location = new System.Drawing.Point(3, 25);
            this.groupDTeam2.Name = "groupDTeam2";
            this.groupDTeam2.Size = new System.Drawing.Size(104, 21);
            this.groupDTeam2.TabIndex = 3;
            this.groupDTeam2.SelectedIndexChanged += new System.EventHandler(this.DropDown_Change);
            // 
            // groupDTeam1
            // 
            this.groupDTeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupDTeam1.FormattingEnabled = true;
            this.groupDTeam1.Location = new System.Drawing.Point(3, 3);
            this.groupDTeam1.Name = "groupDTeam1";
            this.groupDTeam1.Size = new System.Drawing.Size(104, 21);
            this.groupDTeam1.TabIndex = 2;
            this.groupDTeam1.SelectedIndexChanged += new System.EventHandler(this.DropDown_Change);
            // 
            // panelE
            // 
            this.panelE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelE.Controls.Add(this.groupETeam4);
            this.panelE.Controls.Add(this.groupETeam3);
            this.panelE.Controls.Add(this.groupETeam2);
            this.panelE.Controls.Add(this.groupETeam1);
            this.panelE.Location = new System.Drawing.Point(12, 481);
            this.panelE.Name = "panelE";
            this.panelE.Size = new System.Drawing.Size(201, 95);
            this.panelE.TabIndex = 9;
            // 
            // groupETeam4
            // 
            this.groupETeam4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupETeam4.FormattingEnabled = true;
            this.groupETeam4.Location = new System.Drawing.Point(3, 69);
            this.groupETeam4.Name = "groupETeam4";
            this.groupETeam4.Size = new System.Drawing.Size(104, 21);
            this.groupETeam4.TabIndex = 5;
            this.groupETeam4.SelectedIndexChanged += new System.EventHandler(this.DropDown_Change);
            // 
            // groupETeam3
            // 
            this.groupETeam3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupETeam3.FormattingEnabled = true;
            this.groupETeam3.Location = new System.Drawing.Point(3, 47);
            this.groupETeam3.Name = "groupETeam3";
            this.groupETeam3.Size = new System.Drawing.Size(104, 21);
            this.groupETeam3.TabIndex = 4;
            this.groupETeam3.SelectedIndexChanged += new System.EventHandler(this.DropDown_Change);
            // 
            // groupETeam2
            // 
            this.groupETeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupETeam2.FormattingEnabled = true;
            this.groupETeam2.Location = new System.Drawing.Point(3, 25);
            this.groupETeam2.Name = "groupETeam2";
            this.groupETeam2.Size = new System.Drawing.Size(104, 21);
            this.groupETeam2.TabIndex = 3;
            this.groupETeam2.SelectedIndexChanged += new System.EventHandler(this.DropDown_Change);
            // 
            // groupETeam1
            // 
            this.groupETeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupETeam1.FormattingEnabled = true;
            this.groupETeam1.Location = new System.Drawing.Point(3, 3);
            this.groupETeam1.Name = "groupETeam1";
            this.groupETeam1.Size = new System.Drawing.Size(104, 21);
            this.groupETeam1.TabIndex = 2;
            this.groupETeam1.SelectedIndexChanged += new System.EventHandler(this.DropDown_Change);
            // 
            // panelF
            // 
            this.panelF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelF.Controls.Add(this.groupFTeam4);
            this.panelF.Controls.Add(this.groupFTeam3);
            this.panelF.Controls.Add(this.groupFTeam2);
            this.panelF.Controls.Add(this.groupFTeam1);
            this.panelF.Location = new System.Drawing.Point(12, 596);
            this.panelF.Name = "panelF";
            this.panelF.Size = new System.Drawing.Size(201, 95);
            this.panelF.TabIndex = 10;
            // 
            // groupFTeam4
            // 
            this.groupFTeam4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupFTeam4.FormattingEnabled = true;
            this.groupFTeam4.Location = new System.Drawing.Point(3, 69);
            this.groupFTeam4.Name = "groupFTeam4";
            this.groupFTeam4.Size = new System.Drawing.Size(104, 21);
            this.groupFTeam4.TabIndex = 5;
            this.groupFTeam4.SelectedIndexChanged += new System.EventHandler(this.DropDown_Change);
            // 
            // groupFTeam3
            // 
            this.groupFTeam3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupFTeam3.FormattingEnabled = true;
            this.groupFTeam3.Location = new System.Drawing.Point(3, 47);
            this.groupFTeam3.Name = "groupFTeam3";
            this.groupFTeam3.Size = new System.Drawing.Size(104, 21);
            this.groupFTeam3.TabIndex = 4;
            this.groupFTeam3.SelectedIndexChanged += new System.EventHandler(this.DropDown_Change);
            // 
            // groupFTeam2
            // 
            this.groupFTeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupFTeam2.FormattingEnabled = true;
            this.groupFTeam2.Location = new System.Drawing.Point(3, 25);
            this.groupFTeam2.Name = "groupFTeam2";
            this.groupFTeam2.Size = new System.Drawing.Size(104, 21);
            this.groupFTeam2.TabIndex = 3;
            this.groupFTeam2.SelectedIndexChanged += new System.EventHandler(this.DropDown_Change);
            // 
            // groupFTeam1
            // 
            this.groupFTeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupFTeam1.FormattingEnabled = true;
            this.groupFTeam1.Location = new System.Drawing.Point(3, 3);
            this.groupFTeam1.Name = "groupFTeam1";
            this.groupFTeam1.Size = new System.Drawing.Size(104, 21);
            this.groupFTeam1.TabIndex = 2;
            this.groupFTeam1.SelectedIndexChanged += new System.EventHandler(this.DropDown_Change);
            // 
            // LabelGroupA
            // 
            this.LabelGroupA.AutoSize = true;
            this.LabelGroupA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelGroupA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGroupA.Location = new System.Drawing.Point(154, 2);
            this.LabelGroupA.Name = "LabelGroupA";
            this.LabelGroupA.Size = new System.Drawing.Size(59, 18);
            this.LabelGroupA.TabIndex = 11;
            this.LabelGroupA.Text = "Group A";
            // 
            // LabelGroupB
            // 
            this.LabelGroupB.AutoSize = true;
            this.LabelGroupB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelGroupB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGroupB.Location = new System.Drawing.Point(154, 118);
            this.LabelGroupB.Name = "LabelGroupB";
            this.LabelGroupB.Size = new System.Drawing.Size(59, 18);
            this.LabelGroupB.TabIndex = 12;
            this.LabelGroupB.Text = "Group B";
            // 
            // LabelGroupC
            // 
            this.LabelGroupC.AutoSize = true;
            this.LabelGroupC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelGroupC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGroupC.Location = new System.Drawing.Point(154, 234);
            this.LabelGroupC.Name = "LabelGroupC";
            this.LabelGroupC.Size = new System.Drawing.Size(59, 18);
            this.LabelGroupC.TabIndex = 13;
            this.LabelGroupC.Text = "Group C";
            // 
            // LabelGroupD
            // 
            this.LabelGroupD.AutoSize = true;
            this.LabelGroupD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelGroupD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGroupD.Location = new System.Drawing.Point(153, 349);
            this.LabelGroupD.Name = "LabelGroupD";
            this.LabelGroupD.Size = new System.Drawing.Size(60, 18);
            this.LabelGroupD.TabIndex = 14;
            this.LabelGroupD.Text = "Group D";
            // 
            // LabelGroupE
            // 
            this.LabelGroupE.AutoSize = true;
            this.LabelGroupE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelGroupE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGroupE.Location = new System.Drawing.Point(154, 464);
            this.LabelGroupE.Name = "LabelGroupE";
            this.LabelGroupE.Size = new System.Drawing.Size(59, 18);
            this.LabelGroupE.TabIndex = 15;
            this.LabelGroupE.Text = "Group E";
            // 
            // LabelGroupF
            // 
            this.LabelGroupF.AutoSize = true;
            this.LabelGroupF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelGroupF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGroupF.Location = new System.Drawing.Point(155, 579);
            this.LabelGroupF.Name = "LabelGroupF";
            this.LabelGroupF.Size = new System.Drawing.Size(58, 18);
            this.LabelGroupF.TabIndex = 16;
            this.LabelGroupF.Text = "Group F";
            // 
            // teamInfoLabel
            // 
            this.teamInfoLabel.AutoSize = true;
            this.teamInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamInfoLabel.Location = new System.Drawing.Point(242, 22);
            this.teamInfoLabel.Name = "teamInfoLabel";
            this.teamInfoLabel.Size = new System.Drawing.Size(384, 15);
            this.teamInfoLabel.TabIndex = 17;
            this.teamInfoLabel.Text = "Here we will display information about the teams(when the info button is clicked)" +
    "";
            this.teamInfoLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(669, 648);
            this.Controls.Add(this.teamInfoLabel);
            this.Controls.Add(this.LabelGroupF);
            this.Controls.Add(this.LabelGroupE);
            this.Controls.Add(this.LabelGroupD);
            this.Controls.Add(this.LabelGroupC);
            this.Controls.Add(this.LabelGroupB);
            this.Controls.Add(this.LabelGroupA);
            this.Controls.Add(this.panelF);
            this.Controls.Add(this.panelE);
            this.Controls.Add(this.panelD);
            this.Controls.Add(this.panelC);
            this.Controls.Add(this.panelB);
            this.Controls.Add(this.panelA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tournament Overview";
            this.Load += new System.EventHandler(this.MainForm);
            this.panelA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelB.ResumeLayout(false);
            this.panelC.ResumeLayout(false);
            this.panelD.ResumeLayout(false);
            this.panelE.ResumeLayout(false);
            this.panelF.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #region Panels
        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.ComboBox groupATeam4;
        private System.Windows.Forms.ComboBox groupATeam3;
        private System.Windows.Forms.ComboBox groupATeam2;
        private System.Windows.Forms.ComboBox groupATeam1;
        private System.Windows.Forms.Panel panelB;
        private System.Windows.Forms.ComboBox groupBTeam4;
        private System.Windows.Forms.ComboBox groupBTeam3;
        private System.Windows.Forms.ComboBox groupBTeam2;
        private System.Windows.Forms.ComboBox groupBTeam1;
        private System.Windows.Forms.Panel panelC;
        private System.Windows.Forms.ComboBox groupCTeam4;
        private System.Windows.Forms.ComboBox groupCTeam3;
        private System.Windows.Forms.ComboBox groupCTeam2;
        private System.Windows.Forms.ComboBox groupCTeam1;
        private System.Windows.Forms.Panel panelD;
        private System.Windows.Forms.ComboBox groupDTeam4;
        private System.Windows.Forms.ComboBox groupDTeam3;
        private System.Windows.Forms.ComboBox groupDTeam2;
        private System.Windows.Forms.ComboBox groupDTeam1;
        private System.Windows.Forms.Panel panelE;
        private System.Windows.Forms.ComboBox groupETeam4;
        private System.Windows.Forms.ComboBox groupETeam3;
        private System.Windows.Forms.ComboBox groupETeam2;
        private System.Windows.Forms.ComboBox groupETeam1;
        private System.Windows.Forms.Panel panelF;
        private System.Windows.Forms.ComboBox groupFTeam4;
        private System.Windows.Forms.ComboBox groupFTeam3;
        private System.Windows.Forms.ComboBox groupFTeam2;
        private System.Windows.Forms.ComboBox groupFTeam1;
        private System.Windows.Forms.Label LabelGroupA;
        private System.Windows.Forms.Label LabelGroupB;
        private System.Windows.Forms.Label LabelGroupC;
        private System.Windows.Forms.Label LabelGroupD;
        private System.Windows.Forms.Label LabelGroupE;
        private System.Windows.Forms.Label LabelGroupF;






        #endregion
        //



    }
}
