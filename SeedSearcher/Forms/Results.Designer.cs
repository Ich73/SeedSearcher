﻿namespace SeedSearcherGui
{
    partial class Results
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
            this.searchButton = new System.Windows.Forms.Button();
            this.resetFilter = new System.Windows.Forms.Button();
            this.applyFilter = new System.Windows.Forms.Button();
            this.shinyBox = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.abilityBox = new System.Windows.Forms.ComboBox();
            this.natureBox = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.endFrame = new System.Windows.Forms.TextBox();
            this.startFrame = new System.Windows.Forms.TextBox();
            this.speciesList = new System.Windows.Forms.ComboBox();
            this.denBox = new System.Windows.Forms.ComboBox();
            this.seedBox = new System.Windows.Forms.TextBox();
            this.generateData = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.maxSpe = new System.Windows.Forms.NumericUpDown();
            this.maxSpd = new System.Windows.Forms.NumericUpDown();
            this.maxSpa = new System.Windows.Forms.NumericUpDown();
            this.maxDef = new System.Windows.Forms.NumericUpDown();
            this.maxAtk = new System.Windows.Forms.NumericUpDown();
            this.maxHP = new System.Windows.Forms.NumericUpDown();
            this.MinSpe = new System.Windows.Forms.NumericUpDown();
            this.minSpd = new System.Windows.Forms.NumericUpDown();
            this.minSpa = new System.Windows.Forms.NumericUpDown();
            this.minDef = new System.Windows.Forms.NumericUpDown();
            this.minAtk = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.minHP = new System.Windows.Forms.NumericUpDown();
            this.raidContent = new System.Windows.Forms.DataGridView();
            this.FrameCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HPCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtkCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpaCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpdCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpeCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NatureCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbilityCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShinyCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Characteristic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeedCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_IVCalc = new System.Windows.Forms.Button();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.DetailsBox = new System.Windows.Forms.GroupBox();
            this.BT_NextShiny = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxDef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxAtk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinSpe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSpa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minAtk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raidContent)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.DetailsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(698, 193);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 28);
            this.searchButton.TabIndex = 37;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // resetFilter
            // 
            this.resetFilter.Location = new System.Drawing.Point(368, 193);
            this.resetFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetFilter.Name = "resetFilter";
            this.resetFilter.Size = new System.Drawing.Size(92, 28);
            this.resetFilter.TabIndex = 34;
            this.resetFilter.Text = "Reset Filter";
            this.resetFilter.UseVisualStyleBackColor = true;
            this.resetFilter.Click += new System.EventHandler(this.ResetFilter_Click);
            // 
            // applyFilter
            // 
            this.applyFilter.Location = new System.Drawing.Point(261, 193);
            this.applyFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.applyFilter.Name = "applyFilter";
            this.applyFilter.Size = new System.Drawing.Size(92, 28);
            this.applyFilter.TabIndex = 33;
            this.applyFilter.Text = "Apply Filter";
            this.applyFilter.UseVisualStyleBackColor = true;
            this.applyFilter.Click += new System.EventHandler(this.ApplyFilter_Click);
            // 
            // shinyBox
            // 
            this.shinyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shinyBox.FormattingEnabled = true;
            this.shinyBox.Items.AddRange(new object[] {
            "Any",
            "Yes (Any Type)",
            "No",
            "Star",
            "Square"});
            this.shinyBox.Location = new System.Drawing.Point(638, 140);
            this.shinyBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shinyBox.Name = "shinyBox";
            this.shinyBox.Size = new System.Drawing.Size(152, 24);
            this.shinyBox.TabIndex = 32;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(261, 140);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(43, 17);
            this.label23.TabIndex = 31;
            this.label23.Text = "Shiny";
            // 
            // genderBox
            // 
            this.genderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Location = new System.Drawing.Point(638, 110);
            this.genderBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(152, 24);
            this.genderBox.TabIndex = 30;
            // 
            // abilityBox
            // 
            this.abilityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.abilityBox.DropDownWidth = 135;
            this.abilityBox.FormattingEnabled = true;
            this.abilityBox.Location = new System.Drawing.Point(638, 80);
            this.abilityBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abilityBox.Name = "abilityBox";
            this.abilityBox.Size = new System.Drawing.Size(152, 24);
            this.abilityBox.TabIndex = 29;
            // 
            // natureBox
            // 
            this.natureBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.natureBox.FormattingEnabled = true;
            this.natureBox.Location = new System.Drawing.Point(638, 50);
            this.natureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.natureBox.Name = "natureBox";
            this.natureBox.Size = new System.Drawing.Size(152, 24);
            this.natureBox.TabIndex = 28;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(261, 110);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 17);
            this.label22.TabIndex = 27;
            this.label22.Text = "Gender";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(261, 80);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 17);
            this.label21.TabIndex = 26;
            this.label21.Text = "Ability";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(261, 50);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 17);
            this.label20.TabIndex = 25;
            this.label20.Text = "Nature";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(133, 171);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 17);
            this.label19.TabIndex = 24;
            this.label19.Text = "~";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(133, 147);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 17);
            this.label18.TabIndex = 23;
            this.label18.Text = "~";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(133, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 17);
            this.label17.TabIndex = 22;
            this.label17.Text = "~";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(133, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 17);
            this.label16.TabIndex = 21;
            this.label16.Text = "~";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.endFrame);
            this.groupBox1.Controls.Add(this.startFrame);
            this.groupBox1.Controls.Add(this.speciesList);
            this.groupBox1.Controls.Add(this.denBox);
            this.groupBox1.Controls.Add(this.seedBox);
            this.groupBox1.Controls.Add(this.generateData);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(373, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raid Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "~";
            // 
            // endFrame
            // 
            this.endFrame.Location = new System.Drawing.Point(264, 140);
            this.endFrame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endFrame.Name = "endFrame";
            this.endFrame.Size = new System.Drawing.Size(80, 22);
            this.endFrame.TabIndex = 10;
            this.endFrame.Text = "1000";
            // 
            // startFrame
            // 
            this.startFrame.Location = new System.Drawing.Point(157, 140);
            this.startFrame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startFrame.Name = "startFrame";
            this.startFrame.Size = new System.Drawing.Size(80, 22);
            this.startFrame.TabIndex = 9;
            this.startFrame.Text = "0";
            // 
            // speciesList
            // 
            this.speciesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speciesList.FormattingEnabled = true;
            this.speciesList.Location = new System.Drawing.Point(157, 105);
            this.speciesList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.speciesList.Name = "speciesList";
            this.speciesList.Size = new System.Drawing.Size(187, 24);
            this.speciesList.TabIndex = 8;
            this.speciesList.SelectedIndexChanged += new System.EventHandler(this.SpeciesList_SelectedIndexChanged);
            // 
            // denBox
            // 
            this.denBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.denBox.Enabled = false;
            this.denBox.FormattingEnabled = true;
            this.denBox.Location = new System.Drawing.Point(157, 70);
            this.denBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.denBox.Name = "denBox";
            this.denBox.Size = new System.Drawing.Size(187, 24);
            this.denBox.TabIndex = 7;
            // 
            // seedBox
            // 
            this.seedBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seedBox.Location = new System.Drawing.Point(157, 34);
            this.seedBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seedBox.MaxLength = 16;
            this.seedBox.Name = "seedBox";
            this.seedBox.Size = new System.Drawing.Size(187, 23);
            this.seedBox.TabIndex = 6;
            this.seedBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SeedBox_KeyPress);
            // 
            // generateData
            // 
            this.generateData.Location = new System.Drawing.Point(19, 181);
            this.generateData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateData.Name = "generateData";
            this.generateData.Size = new System.Drawing.Size(325, 30);
            this.generateData.TabIndex = 5;
            this.generateData.Text = "Show";
            this.generateData.UseVisualStyleBackColor = true;
            this.generateData.Click += new System.EventHandler(this.GenerateData_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Frames";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Species";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nest";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seed";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(133, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 17);
            this.label15.TabIndex = 20;
            this.label15.Text = "~";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(133, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "~";
            // 
            // maxSpe
            // 
            this.maxSpe.Location = new System.Drawing.Point(152, 166);
            this.maxSpe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxSpe.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.maxSpe.Name = "maxSpe";
            this.maxSpe.Size = new System.Drawing.Size(43, 22);
            this.maxSpe.TabIndex = 19;
            this.maxSpe.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.maxSpe.Enter += new System.EventHandler(this.MinHP_Enter);
            // 
            // maxSpd
            // 
            this.maxSpd.Location = new System.Drawing.Point(152, 142);
            this.maxSpd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxSpd.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.maxSpd.Name = "maxSpd";
            this.maxSpd.Size = new System.Drawing.Size(43, 22);
            this.maxSpd.TabIndex = 17;
            this.maxSpd.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.maxSpd.Enter += new System.EventHandler(this.MinHP_Enter);
            // 
            // maxSpa
            // 
            this.maxSpa.Location = new System.Drawing.Point(152, 119);
            this.maxSpa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxSpa.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.maxSpa.Name = "maxSpa";
            this.maxSpa.Size = new System.Drawing.Size(43, 22);
            this.maxSpa.TabIndex = 15;
            this.maxSpa.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.maxSpa.Enter += new System.EventHandler(this.MinHP_Enter);
            // 
            // maxDef
            // 
            this.maxDef.Location = new System.Drawing.Point(152, 94);
            this.maxDef.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxDef.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.maxDef.Name = "maxDef";
            this.maxDef.Size = new System.Drawing.Size(43, 22);
            this.maxDef.TabIndex = 13;
            this.maxDef.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.maxDef.Enter += new System.EventHandler(this.MinHP_Enter);
            // 
            // maxAtk
            // 
            this.maxAtk.Location = new System.Drawing.Point(152, 70);
            this.maxAtk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxAtk.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.maxAtk.Name = "maxAtk";
            this.maxAtk.Size = new System.Drawing.Size(43, 22);
            this.maxAtk.TabIndex = 11;
            this.maxAtk.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.maxAtk.Enter += new System.EventHandler(this.MinHP_Enter);
            // 
            // maxHP
            // 
            this.maxHP.Location = new System.Drawing.Point(152, 46);
            this.maxHP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxHP.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.maxHP.Name = "maxHP";
            this.maxHP.Size = new System.Drawing.Size(43, 22);
            this.maxHP.TabIndex = 9;
            this.maxHP.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.maxHP.Enter += new System.EventHandler(this.MinHP_Enter);
            // 
            // MinSpe
            // 
            this.MinSpe.Location = new System.Drawing.Point(85, 166);
            this.MinSpe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinSpe.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.MinSpe.Name = "MinSpe";
            this.MinSpe.Size = new System.Drawing.Size(43, 22);
            this.MinSpe.TabIndex = 18;
            this.MinSpe.Enter += new System.EventHandler(this.MinHP_Enter);
            // 
            // minSpd
            // 
            this.minSpd.Location = new System.Drawing.Point(85, 142);
            this.minSpd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minSpd.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.minSpd.Name = "minSpd";
            this.minSpd.Size = new System.Drawing.Size(43, 22);
            this.minSpd.TabIndex = 16;
            this.minSpd.Enter += new System.EventHandler(this.MinHP_Enter);
            // 
            // minSpa
            // 
            this.minSpa.Location = new System.Drawing.Point(85, 119);
            this.minSpa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minSpa.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.minSpa.Name = "minSpa";
            this.minSpa.Size = new System.Drawing.Size(43, 22);
            this.minSpa.TabIndex = 14;
            this.minSpa.Enter += new System.EventHandler(this.MinHP_Enter);
            // 
            // minDef
            // 
            this.minDef.Location = new System.Drawing.Point(85, 94);
            this.minDef.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minDef.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.minDef.Name = "minDef";
            this.minDef.Size = new System.Drawing.Size(43, 22);
            this.minDef.TabIndex = 12;
            this.minDef.Enter += new System.EventHandler(this.MinHP_Enter);
            // 
            // minAtk
            // 
            this.minAtk.Location = new System.Drawing.Point(85, 70);
            this.minAtk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minAtk.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.minAtk.Name = "minAtk";
            this.minAtk.Size = new System.Drawing.Size(43, 22);
            this.minAtk.TabIndex = 10;
            this.minAtk.Enter += new System.EventHandler(this.MinHP_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "SPE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "SPD";
            // 
            // minHP
            // 
            this.minHP.Location = new System.Drawing.Point(85, 46);
            this.minHP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minHP.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.minHP.Name = "minHP";
            this.minHP.Size = new System.Drawing.Size(43, 22);
            this.minHP.TabIndex = 8;
            this.minHP.Enter += new System.EventHandler(this.MinHP_Enter);
            // 
            // raidContent
            // 
            this.raidContent.AllowUserToAddRows = false;
            this.raidContent.AllowUserToDeleteRows = false;
            this.raidContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raidContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FrameCell,
            this.HPCell,
            this.AtkCell,
            this.DefCell,
            this.SpaCell,
            this.SpdCell,
            this.SpeCell,
            this.NatureCell,
            this.AbilityCell,
            this.GenderCell,
            this.ShinyCell,
            this.Characteristic,
            this.SeedCell});
            this.raidContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.raidContent.Location = new System.Drawing.Point(0, 282);
            this.raidContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.raidContent.Name = "raidContent";
            this.raidContent.ReadOnly = true;
            this.raidContent.RowHeadersWidth = 51;
            this.raidContent.RowTemplate.Height = 24;
            this.raidContent.Size = new System.Drawing.Size(1252, 609);
            this.raidContent.TabIndex = 2;
            // 
            // FrameCell
            // 
            this.FrameCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FrameCell.HeaderText = "Frame Advances";
            this.FrameCell.MinimumWidth = 6;
            this.FrameCell.Name = "FrameCell";
            this.FrameCell.ReadOnly = true;
            this.FrameCell.Width = 77;
            // 
            // HPCell
            // 
            this.HPCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.HPCell.HeaderText = "HP";
            this.HPCell.MinimumWidth = 6;
            this.HPCell.Name = "HPCell";
            this.HPCell.ReadOnly = true;
            this.HPCell.Width = 56;
            // 
            // AtkCell
            // 
            this.AtkCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AtkCell.HeaderText = "ATK";
            this.AtkCell.MinimumWidth = 6;
            this.AtkCell.Name = "AtkCell";
            this.AtkCell.ReadOnly = true;
            this.AtkCell.Width = 64;
            // 
            // DefCell
            // 
            this.DefCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DefCell.HeaderText = "DEF";
            this.DefCell.MinimumWidth = 6;
            this.DefCell.Name = "DefCell";
            this.DefCell.ReadOnly = true;
            this.DefCell.Width = 64;
            // 
            // SpaCell
            // 
            this.SpaCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SpaCell.HeaderText = "SPA";
            this.SpaCell.MinimumWidth = 6;
            this.SpaCell.Name = "SpaCell";
            this.SpaCell.ReadOnly = true;
            this.SpaCell.Width = 64;
            // 
            // SpdCell
            // 
            this.SpdCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SpdCell.HeaderText = "SPD";
            this.SpdCell.MinimumWidth = 6;
            this.SpdCell.Name = "SpdCell";
            this.SpdCell.ReadOnly = true;
            this.SpdCell.Width = 65;
            // 
            // SpeCell
            // 
            this.SpeCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SpeCell.HeaderText = "SPE";
            this.SpeCell.MinimumWidth = 6;
            this.SpeCell.Name = "SpeCell";
            this.SpeCell.ReadOnly = true;
            this.SpeCell.Width = 64;
            // 
            // NatureCell
            // 
            this.NatureCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NatureCell.HeaderText = "Nature";
            this.NatureCell.MinimumWidth = 6;
            this.NatureCell.Name = "NatureCell";
            this.NatureCell.ReadOnly = true;
            this.NatureCell.Width = 80;
            // 
            // AbilityCell
            // 
            this.AbilityCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AbilityCell.HeaderText = "Ability";
            this.AbilityCell.MinimumWidth = 6;
            this.AbilityCell.Name = "AbilityCell";
            this.AbilityCell.ReadOnly = true;
            this.AbilityCell.Width = 74;
            // 
            // GenderCell
            // 
            this.GenderCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GenderCell.HeaderText = "Gender";
            this.GenderCell.MinimumWidth = 6;
            this.GenderCell.Name = "GenderCell";
            this.GenderCell.ReadOnly = true;
            this.GenderCell.Width = 85;
            // 
            // ShinyCell
            // 
            this.ShinyCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ShinyCell.HeaderText = "Shiny";
            this.ShinyCell.MinimumWidth = 6;
            this.ShinyCell.Name = "ShinyCell";
            this.ShinyCell.ReadOnly = true;
            this.ShinyCell.Width = 72;
            // 
            // Characteristic
            // 
            this.Characteristic.HeaderText = "Characteristic";
            this.Characteristic.MinimumWidth = 6;
            this.Characteristic.Name = "Characteristic";
            this.Characteristic.ReadOnly = true;
            this.Characteristic.Width = 125;
            // 
            // SeedCell
            // 
            this.SeedCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SeedCell.HeaderText = "Seed";
            this.SeedCell.MaxInputLength = 16;
            this.SeedCell.MinimumWidth = 6;
            this.SeedCell.Name = "SeedCell";
            this.SeedCell.ReadOnly = true;
            this.SeedCell.Width = 140;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "SPA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "DEF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "ATK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "HP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Max IV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Min IV";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BT_NextShiny);
            this.groupBox2.Controls.Add(this.BTN_IVCalc);
            this.groupBox2.Controls.Add(this.BTN_Clear);
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Controls.Add(this.resetFilter);
            this.groupBox2.Controls.Add(this.applyFilter);
            this.groupBox2.Controls.Add(this.shinyBox);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.genderBox);
            this.groupBox2.Controls.Add(this.abilityBox);
            this.groupBox2.Controls.Add(this.natureBox);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.maxSpe);
            this.groupBox2.Controls.Add(this.maxSpd);
            this.groupBox2.Controls.Add(this.maxSpa);
            this.groupBox2.Controls.Add(this.maxDef);
            this.groupBox2.Controls.Add(this.maxAtk);
            this.groupBox2.Controls.Add(this.maxHP);
            this.groupBox2.Controls.Add(this.MinSpe);
            this.groupBox2.Controls.Add(this.minSpd);
            this.groupBox2.Controls.Add(this.minSpa);
            this.groupBox2.Controls.Add(this.minDef);
            this.groupBox2.Controls.Add(this.minAtk);
            this.groupBox2.Controls.Add(this.minHP);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(395, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(817, 231);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // BTN_IVCalc
            // 
            this.BTN_IVCalc.Location = new System.Drawing.Point(85, 193);
            this.BTN_IVCalc.Name = "BTN_IVCalc";
            this.BTN_IVCalc.Size = new System.Drawing.Size(110, 28);
            this.BTN_IVCalc.TabIndex = 20;
            this.BTN_IVCalc.Text = "IV Calc";
            this.BTN_IVCalc.UseVisualStyleBackColor = true;
            this.BTN_IVCalc.Click += new System.EventHandler(this.BTN_IVCalc_Click);
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Location = new System.Drawing.Point(475, 193);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(92, 28);
            this.BTN_Clear.TabIndex = 35;
            this.BTN_Clear.Text = "Clear Filter";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // DetailsBox
            // 
            this.DetailsBox.Controls.Add(this.groupBox2);
            this.DetailsBox.Controls.Add(this.groupBox1);
            this.DetailsBox.Location = new System.Drawing.Point(4, 11);
            this.DetailsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DetailsBox.Name = "DetailsBox";
            this.DetailsBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DetailsBox.Size = new System.Drawing.Size(1236, 267);
            this.DetailsBox.TabIndex = 3;
            this.DetailsBox.TabStop = false;
            this.DetailsBox.Text = "Details";
            // 
            // BT_NextShiny
            // 
            this.BT_NextShiny.Location = new System.Drawing.Point(582, 193);
            this.BT_NextShiny.Name = "BT_NextShiny";
            this.BT_NextShiny.Size = new System.Drawing.Size(100, 28);
            this.BT_NextShiny.TabIndex = 36;
            this.BT_NextShiny.Text = "Next Shinies";
            this.BT_NextShiny.UseVisualStyleBackColor = true;
            this.BT_NextShiny.Click += new System.EventHandler(this.BT_NextShiny_Click);
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 891);
            this.Controls.Add(this.raidContent);
            this.Controls.Add(this.DetailsBox);
            this.Name = "Results";
            this.ShowIcon = false;
            this.Text = "Results";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxDef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxAtk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinSpe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSpa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minAtk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raidContent)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.DetailsBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button resetFilter;
        private System.Windows.Forms.Button applyFilter;
        private System.Windows.Forms.ComboBox shinyBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.ComboBox abilityBox;
        private System.Windows.Forms.ComboBox natureBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox endFrame;
        private System.Windows.Forms.TextBox startFrame;
        private System.Windows.Forms.TextBox seedBox;
        private System.Windows.Forms.Button generateData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown maxSpe;
        private System.Windows.Forms.NumericUpDown maxSpd;
        private System.Windows.Forms.NumericUpDown maxSpa;
        private System.Windows.Forms.NumericUpDown maxDef;
        private System.Windows.Forms.NumericUpDown maxAtk;
        private System.Windows.Forms.NumericUpDown maxHP;
        private System.Windows.Forms.NumericUpDown MinSpe;
        private System.Windows.Forms.NumericUpDown minSpd;
        private System.Windows.Forms.NumericUpDown minSpa;
        private System.Windows.Forms.NumericUpDown minDef;
        private System.Windows.Forms.NumericUpDown minAtk;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown minHP;
        private System.Windows.Forms.DataGridView raidContent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox DetailsBox;
        private System.Windows.Forms.ComboBox speciesList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox denBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrameCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn HPCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtkCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpaCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpdCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpeCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn NatureCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbilityCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShinyCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Characteristic;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeedCell;
        private System.Windows.Forms.Button BTN_IVCalc;
        private System.Windows.Forms.Button BT_NextShiny;
    }
}