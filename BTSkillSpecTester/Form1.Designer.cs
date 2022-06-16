namespace BTSkillSpecTester
{
    partial class BTSkillSpecTester
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
            int i;

            //construct objects
            this.PnlFort = new System.Windows.Forms.Panel();
            this.PnlLai = new System.Windows.Forms.Panel();
            this.PnlEka = new System.Windows.Forms.Panel();
            this.PnlArby = new System.Windows.Forms.Panel();
            this.PnlControls = new System.Windows.Forms.Panel();

            this.BTSBear = new System.Windows.Forms.PictureBox[17];
            this.LblFortNames = new System.Windows.Forms.Label[17];
            this.FortSPSelectors = new System.Windows.Forms.NumericUpDown[17];
            this.FortAdjSP = new System.Windows.Forms.Label[17];

            this.BTSLeopard = new System.Windows.Forms.PictureBox[17];
            this.LblLaiNames = new System.Windows.Forms.Label[17];
            this.LaiSPSelectors = new System.Windows.Forms.NumericUpDown[17];
            this.LaiAdjSP = new System.Windows.Forms.Label[17];

            this.BTSHawk = new System.Windows.Forms.PictureBox[18];
            this.LblEkaNames = new System.Windows.Forms.Label[18];
            this.EkaSPSelectors = new System.Windows.Forms.NumericUpDown[18];
            this.EkaAdjSP = new System.Windows.Forms.Label[18];

            this.BTSCat = new System.Windows.Forms.PictureBox[18];
            this.LblArbyNames = new System.Windows.Forms.Label[18];
            this.ArbySPSelectors = new System.Windows.Forms.NumericUpDown[18];
            this.ArbyAdjSP = new System.Windows.Forms.Label[18];


            // --------------------------------//
            //           Fort Panel            //
            // --------------------------------//
            this.PnlFort.Location = new System.Drawing.Point(12, 12);
            this.PnlFort.Name = "Fort";
            this.PnlFort.Size = new System.Drawing.Size(200, 600);
            this.PnlFort.TabIndex = 0;
            //Fort skill spec
            BTSBear[0] = new System.Windows.Forms.PictureBox();
            LblFortNames[0] = new System.Windows.Forms.Label();
            FortSPSelectors[0] = new System.Windows.Forms.NumericUpDown();
            FortAdjSP[0] = new System.Windows.Forms.Label();

            this.FortSPSelectors[0].Value = 0;
            this.FortSPSelectors[0].Maximum = 20;
            this.FortSPSelectors[0].Minimum = 0;
            this.FortSPSelectors[0].ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            this.FortSPSelectors[0].Width = 50;
            this.FortSPSelectors[0].Location = new System.Drawing.Point(BTSBear[0].Location.X + 35, BTSBear[0].Location.Y + 14);
            this.FortSPSelectors[0].ReadOnly = true;
            this.PnlFort.Controls.Add(this.FortSPSelectors[0]);

            this.FortAdjSP[0].Text = "0/20";
            this.FortAdjSP[0].TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FortAdjSP[0].Location = new System.Drawing.Point(FortSPSelectors[0].Location.X + 50, FortSPSelectors[0].Location.Y);
            this.PnlFort.Controls.Add(this.FortAdjSP[0]);

            this.BTSBear[0].SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PnlFort.Controls.Add(this.BTSBear[0]);
            LblFortNames[0].Location = new System.Drawing.Point(BTSBear[0].Location.X + 35, BTSBear[0].Location.Y);
            LblFortNames[0].AutoSize = true;
            this.PnlFort.Controls.Add(this.LblFortNames[0]);


            // --------------------------------//
            //            Lai Panel            //
            // --------------------------------//
            this.PnlLai.Location = new System.Drawing.Point(218, 12);
            this.PnlLai.Name = "Lai";
            this.PnlLai.Size = new System.Drawing.Size(200, 600);
            this.PnlLai.TabIndex = 1;
            //Lai skill spec
            BTSLeopard[0] = new System.Windows.Forms.PictureBox();
            LblLaiNames[0] = new System.Windows.Forms.Label();
            LaiSPSelectors[0] = new System.Windows.Forms.NumericUpDown();
            LaiAdjSP[0] = new System.Windows.Forms.Label();

            this.LaiSPSelectors[0].Value = 0;
            this.LaiSPSelectors[0].Maximum = 20;
            this.LaiSPSelectors[0].Minimum = 0;
            this.LaiSPSelectors[0].ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            this.LaiSPSelectors[0].Width = 50;
            this.LaiSPSelectors[0].Location = new System.Drawing.Point(BTSLeopard[0].Location.X + 35, BTSLeopard[0].Location.Y + 14);
            this.LaiSPSelectors[0].ReadOnly = true;
            this.PnlLai.Controls.Add(this.LaiSPSelectors[0]);

            this.LaiAdjSP[0].Text = "0/20";
            this.LaiAdjSP[0].TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LaiAdjSP[0].Location = new System.Drawing.Point(LaiSPSelectors[0].Location.X + 50, LaiSPSelectors[0].Location.Y);
            this.PnlLai.Controls.Add(this.LaiAdjSP[0]);

            this.BTSLeopard[0].SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PnlLai.Controls.Add(this.BTSLeopard[0]);
            LblLaiNames[0].Location = new System.Drawing.Point(BTSLeopard[0].Location.X + 35, BTSLeopard[0].Location.Y);
            LblLaiNames[0].AutoSize = true;
            this.PnlLai.Controls.Add(this.LblLaiNames[0]);


            // --------------------------------//
            //            Eka Panel            //
            // --------------------------------//
            this.PnlEka.Location = new System.Drawing.Point(425, 13);
            this.PnlEka.Name = "Eka";
            this.PnlEka.Size = new System.Drawing.Size(200, 640);
            this.PnlEka.TabIndex = 2;
            //Eka skill spec
            BTSHawk[0] = new System.Windows.Forms.PictureBox();
            LblEkaNames[0] = new System.Windows.Forms.Label();
            EkaSPSelectors[0] = new System.Windows.Forms.NumericUpDown();
            EkaAdjSP[0] = new System.Windows.Forms.Label();

            this.EkaSPSelectors[0].Value = 0;
            this.EkaSPSelectors[0].Maximum = 10;
            this.EkaSPSelectors[0].Minimum = 0;
            this.EkaSPSelectors[0].ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            this.EkaSPSelectors[0].Width = 50;
            this.EkaSPSelectors[0].Location = new System.Drawing.Point(BTSHawk[0].Location.X + 35, BTSHawk[0].Location.Y + 14);
            this.EkaSPSelectors[0].ReadOnly = true;
            this.PnlEka.Controls.Add(this.EkaSPSelectors[0]);

            this.EkaAdjSP[0].Text = "0/10";
            this.EkaAdjSP[0].TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EkaAdjSP[0].Location = new System.Drawing.Point(EkaSPSelectors[0].Location.X + 50, EkaSPSelectors[0].Location.Y);
            this.PnlEka.Controls.Add(this.EkaAdjSP[0]);

            this.BTSHawk[0].SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PnlEka.Controls.Add(this.BTSHawk[0]);
            LblEkaNames[0].Location = new System.Drawing.Point(BTSHawk[0].Location.X + 35, BTSHawk[0].Location.Y);
            LblEkaNames[0].AutoSize = true;
            this.PnlEka.Controls.Add(this.LblEkaNames[0]);


            // --------------------------------//
            //            Arby Panel           //
            // --------------------------------//
            this.PnlArby.Location = new System.Drawing.Point(632, 13);
            this.PnlArby.Name = "Arby";
            this.PnlArby.Size = new System.Drawing.Size(200, 640);
            this.PnlArby.TabIndex = 3;
            //Arby skill spec
            BTSCat[0] = new System.Windows.Forms.PictureBox();
            LblArbyNames[0] = new System.Windows.Forms.Label();
            ArbySPSelectors[0] = new System.Windows.Forms.NumericUpDown();
            ArbyAdjSP[0] = new System.Windows.Forms.Label();

            this.ArbySPSelectors[0].Value = 0;
            this.ArbySPSelectors[0].Maximum = 10;
            this.ArbySPSelectors[0].Minimum = 0;
            this.ArbySPSelectors[0].ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            this.ArbySPSelectors[0].Width = 50;
            this.ArbySPSelectors[0].Location = new System.Drawing.Point(BTSCat[0].Location.X + 35, BTSCat[0].Location.Y + 14);
            this.ArbySPSelectors[0].ReadOnly = true;
            this.PnlArby.Controls.Add(this.ArbySPSelectors[0]);

            this.ArbyAdjSP[0].Text = "0/10";
            this.ArbyAdjSP[0].TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ArbyAdjSP[0].Location = new System.Drawing.Point(ArbySPSelectors[0].Location.X + 50, ArbySPSelectors[0].Location.Y);
            this.PnlArby.Controls.Add(this.ArbyAdjSP[0]);

            this.BTSCat[0].SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PnlArby.Controls.Add(this.BTSCat[0]);
            LblArbyNames[0].Location = new System.Drawing.Point(BTSCat[0].Location.X + 35, BTSCat[0].Location.Y);
            LblArbyNames[0].AutoSize = true;
            this.PnlArby.Controls.Add(this.LblArbyNames[0]);


            // --------------------------------//
            //          Controls Panel         //
            // --------------------------------//
            this.PnlControls.Location = new System.Drawing.Point(12, 650);
            this.PnlControls.Name = "Controls";
            this.PnlControls.Size = new System.Drawing.Size(820, 200);
            this.PnlControls.TabIndex = 4;

            this.LblAllSkill = new System.Windows.Forms.Label();
            this.LblLevel = new System.Windows.Forms.Label();
            this.LblCurrentSP = new System.Windows.Forms.Label();
            this.AllSkill = new System.Windows.Forms.TextBox();
            this.Level = new System.Windows.Forms.TextBox();
            this.CurrentSP = new System.Windows.Forms.TextBox();
            this.Export = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();

            this.LblAllSkill.Text = "All Skill Total:";
            this.LblLevel.Text = "Current Level:";
            this.LblCurrentSP.Text = "Remaining SP:";
            this.LblAllSkill.Location = new System.Drawing.Point(LblAllSkill.Location.X, LblAllSkill.Location.Y + 10);
            this.LblLevel.Location = new System.Drawing.Point(LblAllSkill.Location.X, LblAllSkill.Location.Y + 24);
            this.LblCurrentSP.Location = new System.Drawing.Point(LblLevel.Location.X, LblLevel.Location.Y + 24);

            this.AllSkill.Text = "0";
            this.AllSkill.Location = new System.Drawing.Point(100, LblAllSkill.Location.Y - 4);
            this.AllSkill.TextChanged += new System.EventHandler(this.AllSkill_ValueChanged);
            this.Level.Text = "200";
            this.Level.Location = new System.Drawing.Point(100, LblLevel.Location.Y - 4);
            this.Level.TextChanged += new System.EventHandler(this.Level_ValueChanged);
            this.CurrentSP.Text = "593";
            this.CurrentSP.Location = new System.Drawing.Point(100, LblCurrentSP.Location.Y - 4);
            this.CurrentSP.Enabled = false;

            this.Export.Text = "Export";
            this.Import.Text = "Import";
            this.Export.Click += new System.EventHandler(this.Export_Clicked);
            this.Import.Click += new System.EventHandler(this.Import_Clicked);
            this.Import.Location = new System.Drawing.Point(Level.Location.X + 210, Level.Location.Y);
            this.Export.Location = new System.Drawing.Point(Import.Location.X + 100, Import.Location.Y);

            this.PnlControls.Controls.Add(this.LblAllSkill);
            this.PnlControls.Controls.Add(this.LblLevel);
            this.PnlControls.Controls.Add(this.LblCurrentSP);
            this.PnlControls.Controls.Add(this.AllSkill);
            this.PnlControls.Controls.Add(this.Level);
            this.PnlControls.Controls.Add(this.CurrentSP);
            this.PnlControls.Controls.Add(this.Import);
            this.PnlControls.Controls.Add(this.Export);

            // 
            // BTSkillSpecTester
            // 
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 727);
            this.Controls.Add(this.PnlControls);
            this.Controls.Add(this.PnlArby);
            this.Controls.Add(this.PnlEka);
            this.Controls.Add(this.PnlLai);
            this.Controls.Add(this.PnlFort);
            this.Name = "BTSkillSpecTester";
            this.Text = "BT Skill Spec Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        //
        // Instanciate widges
        //
        private System.Windows.Forms.Panel PnlFort;
        private System.Windows.Forms.Panel PnlLai;
        private System.Windows.Forms.Panel PnlEka;
        private System.Windows.Forms.Panel PnlArby;
        private System.Windows.Forms.Panel PnlControls;

        private System.Windows.Forms.PictureBox[] BTSBear;
        private System.Windows.Forms.PictureBox[] BTSLeopard;
        private System.Windows.Forms.PictureBox[] BTSHawk;
        private System.Windows.Forms.PictureBox[] BTSCat;

        private System.Windows.Forms.Label[] LblFortNames;
        private System.Windows.Forms.Label[] LblLaiNames;
        private System.Windows.Forms.Label[] LblEkaNames;
        private System.Windows.Forms.Label[] LblArbyNames;

        private System.Windows.Forms.NumericUpDown[] FortSPSelectors;
        private System.Windows.Forms.NumericUpDown[] LaiSPSelectors;
        private System.Windows.Forms.NumericUpDown[] EkaSPSelectors;
        private System.Windows.Forms.NumericUpDown[] ArbySPSelectors;

        private System.Windows.Forms.Label[] FortAdjSP;
        private System.Windows.Forms.Label[] LaiAdjSP;
        private System.Windows.Forms.Label[] EkaAdjSP;
        private System.Windows.Forms.Label[] ArbyAdjSP;

        private System.Windows.Forms.Label LblAllSkill;
        private System.Windows.Forms.TextBox AllSkill;
        private System.Windows.Forms.Label LblLevel;
        private System.Windows.Forms.TextBox Level;
        private System.Windows.Forms.Label LblCurrentSP;
        private System.Windows.Forms.TextBox CurrentSP;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button Import;
    }
}

