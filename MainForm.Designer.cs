namespace Assignment3
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHeighInch = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCalculateBMI = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnImperial = new System.Windows.Forms.RadioButton();
            this.rbtnMetric = new System.Windows.Forms.RadioButton();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblNormalWeight = new System.Windows.Forms.Label();
            this.lblNormalBMI = new System.Windows.Forms.Label();
            this.lblWeightCategory = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSavingPlan = new System.Windows.Forms.GroupBox();
            this.txtInitialDeposit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.txtGrowth = new System.Windows.Forms.TextBox();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblGrowth = new System.Windows.Forms.Label();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.txtMonthlyDeposit = new System.Windows.Forms.TextBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblMonthlyDeposit = new System.Windows.Forms.Label();
            this.btnCalculateSaving = new System.Windows.Forms.Button();
            this.grpFutureValue = new System.Windows.Forms.GroupBox();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblAmountEarned = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFinalBalance = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpBMR = new System.Windows.Forms.GroupBox();
            this.btnCalculateBMR = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lboxBMRResults = new System.Windows.Forms.ListBox();
            this.grpWeeklyActivity = new System.Windows.Forms.GroupBox();
            this.rbtnExtraActive = new System.Windows.Forms.RadioButton();
            this.rbtnVeryActive = new System.Windows.Forms.RadioButton();
            this.rbtnModeratelyActive = new System.Windows.Forms.RadioButton();
            this.rbtnLightlyActive = new System.Windows.Forms.RadioButton();
            this.rbtnSedentary = new System.Windows.Forms.RadioButton();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.grpSavingPlan.SuspendLayout();
            this.grpFutureValue.SuspendLayout();
            this.grpBMR.SuspendLayout();
            this.grpWeeklyActivity.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHeighInch);
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Controls.Add(this.txtWeight);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblWeight);
            this.groupBox1.Controls.Add(this.lblHeight);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(69, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BMI Calculator";
            // 
            // txtHeighInch
            // 
            this.txtHeighInch.Location = new System.Drawing.Point(290, 66);
            this.txtHeighInch.Name = "txtHeighInch";
            this.txtHeighInch.Size = new System.Drawing.Size(46, 22);
            this.txtHeighInch.TabIndex = 6;
            this.txtHeighInch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(184, 66);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(97, 22);
            this.txtHeight.TabIndex = 5;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(184, 99);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(96, 22);
            this.txtWeight.TabIndex = 4;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(184, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 22);
            this.txtName.TabIndex = 3;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(21, 99);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(49, 16);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Weight";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(21, 66);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(49, 16);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Height ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Location = new System.Drawing.Point(21, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // btnCalculateBMI
            // 
            this.btnCalculateBMI.Location = new System.Drawing.Point(253, 239);
            this.btnCalculateBMI.Name = "btnCalculateBMI";
            this.btnCalculateBMI.Size = new System.Drawing.Size(231, 51);
            this.btnCalculateBMI.TabIndex = 1;
            this.btnCalculateBMI.Text = "Calculate BMI";
            this.btnCalculateBMI.UseVisualStyleBackColor = true;
            this.btnCalculateBMI.Click += new System.EventHandler(this.btnCalculateBMI_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnImperial);
            this.groupBox2.Controls.Add(this.rbtnMetric);
            this.groupBox2.Location = new System.Drawing.Point(542, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 136);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unit";
            // 
            // rbtnImperial
            // 
            this.rbtnImperial.AutoSize = true;
            this.rbtnImperial.Location = new System.Drawing.Point(23, 92);
            this.rbtnImperial.Name = "rbtnImperial";
            this.rbtnImperial.Size = new System.Drawing.Size(117, 20);
            this.rbtnImperial.TabIndex = 1;
            this.rbtnImperial.TabStop = true;
            this.rbtnImperial.Text = "Imperial (ft, lbs)";
            this.rbtnImperial.UseVisualStyleBackColor = true;
            this.rbtnImperial.CheckedChanged += new System.EventHandler(this.rbtnImperial_CheckedChanged);
            // 
            // rbtnMetric
            // 
            this.rbtnMetric.AutoSize = true;
            this.rbtnMetric.Location = new System.Drawing.Point(24, 42);
            this.rbtnMetric.Name = "rbtnMetric";
            this.rbtnMetric.Size = new System.Drawing.Size(114, 20);
            this.rbtnMetric.TabIndex = 0;
            this.rbtnMetric.TabStop = true;
            this.rbtnMetric.Text = "Metric (kg, cm)";
            this.rbtnMetric.UseVisualStyleBackColor = true;
            this.rbtnMetric.CheckedChanged += new System.EventHandler(this.rbtnMetric_CheckedChanged);
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblNormalWeight);
            this.grpResults.Controls.Add(this.lblNormalBMI);
            this.grpResults.Controls.Add(this.lblWeightCategory);
            this.grpResults.Controls.Add(this.lblBMI);
            this.grpResults.Controls.Add(this.label2);
            this.grpResults.Controls.Add(this.label1);
            this.grpResults.Location = new System.Drawing.Point(63, 311);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(681, 208);
            this.grpResults.TabIndex = 3;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results for";
            // 
            // lblNormalWeight
            // 
            this.lblNormalWeight.AutoSize = true;
            this.lblNormalWeight.Location = new System.Drawing.Point(126, 171);
            this.lblNormalWeight.Name = "lblNormalWeight";
            this.lblNormalWeight.Size = new System.Drawing.Size(92, 16);
            this.lblNormalWeight.TabIndex = 5;
            this.lblNormalWeight.Text = "Normal weight";
            // 
            // lblNormalBMI
            // 
            this.lblNormalBMI.AutoSize = true;
            this.lblNormalBMI.Location = new System.Drawing.Point(126, 135);
            this.lblNormalBMI.Name = "lblNormalBMI";
            this.lblNormalBMI.Size = new System.Drawing.Size(74, 16);
            this.lblNormalBMI.TabIndex = 4;
            this.lblNormalBMI.Text = "NormalBMI";
            // 
            // lblWeightCategory
            // 
            this.lblWeightCategory.AutoSize = true;
            this.lblWeightCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWeightCategory.Location = new System.Drawing.Point(201, 75);
            this.lblWeightCategory.MinimumSize = new System.Drawing.Size(200, 0);
            this.lblWeightCategory.Name = "lblWeightCategory";
            this.lblWeightCategory.Size = new System.Drawing.Size(200, 18);
            this.lblWeightCategory.TabIndex = 3;
            this.lblWeightCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBMI.Location = new System.Drawing.Point(201, 40);
            this.lblBMI.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(100, 18);
            this.lblBMI.TabIndex = 2;
            this.lblBMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weight category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMI";
            // 
            // grpSavingPlan
            // 
            this.grpSavingPlan.Controls.Add(this.txtInitialDeposit);
            this.grpSavingPlan.Controls.Add(this.label5);
            this.grpSavingPlan.Controls.Add(this.txtFees);
            this.grpSavingPlan.Controls.Add(this.txtGrowth);
            this.grpSavingPlan.Controls.Add(this.lblFees);
            this.grpSavingPlan.Controls.Add(this.lblGrowth);
            this.grpSavingPlan.Controls.Add(this.txtPeriod);
            this.grpSavingPlan.Controls.Add(this.txtMonthlyDeposit);
            this.grpSavingPlan.Controls.Add(this.lblPeriod);
            this.grpSavingPlan.Controls.Add(this.lblMonthlyDeposit);
            this.grpSavingPlan.Location = new System.Drawing.Point(795, 58);
            this.grpSavingPlan.Name = "grpSavingPlan";
            this.grpSavingPlan.Size = new System.Drawing.Size(308, 187);
            this.grpSavingPlan.TabIndex = 4;
            this.grpSavingPlan.TabStop = false;
            this.grpSavingPlan.Text = "Saving plan";
            // 
            // txtInitialDeposit
            // 
            this.txtInitialDeposit.Location = new System.Drawing.Point(191, 26);
            this.txtInitialDeposit.Name = "txtInitialDeposit";
            this.txtInitialDeposit.Size = new System.Drawing.Size(94, 22);
            this.txtInitialDeposit.TabIndex = 9;
            this.txtInitialDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Initial deposit";
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(191, 153);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(94, 22);
            this.txtFees.TabIndex = 7;
            this.txtFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGrowth
            // 
            this.txtGrowth.Location = new System.Drawing.Point(191, 122);
            this.txtGrowth.Name = "txtGrowth";
            this.txtGrowth.Size = new System.Drawing.Size(94, 22);
            this.txtGrowth.TabIndex = 6;
            this.txtGrowth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Location = new System.Drawing.Point(18, 153);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(66, 16);
            this.lblFees.TabIndex = 5;
            this.lblFees.Text = "Fees in %";
            // 
            // lblGrowth
            // 
            this.lblGrowth.AutoSize = true;
            this.lblGrowth.Location = new System.Drawing.Point(18, 122);
            this.lblGrowth.Name = "lblGrowth";
            this.lblGrowth.Size = new System.Drawing.Size(144, 16);
            this.lblGrowth.TabIndex = 4;
            this.lblGrowth.Text = "Growth (of interest in %)";
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(191, 92);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(94, 22);
            this.txtPeriod.TabIndex = 3;
            this.txtPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMonthlyDeposit
            // 
            this.txtMonthlyDeposit.Location = new System.Drawing.Point(191, 58);
            this.txtMonthlyDeposit.Name = "txtMonthlyDeposit";
            this.txtMonthlyDeposit.Size = new System.Drawing.Size(94, 22);
            this.txtMonthlyDeposit.TabIndex = 2;
            this.txtMonthlyDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(18, 92);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(92, 16);
            this.lblPeriod.TabIndex = 1;
            this.lblPeriod.Text = "Period (years)";
            // 
            // lblMonthlyDeposit
            // 
            this.lblMonthlyDeposit.AutoSize = true;
            this.lblMonthlyDeposit.Location = new System.Drawing.Point(18, 58);
            this.lblMonthlyDeposit.Name = "lblMonthlyDeposit";
            this.lblMonthlyDeposit.Size = new System.Drawing.Size(101, 16);
            this.lblMonthlyDeposit.TabIndex = 0;
            this.lblMonthlyDeposit.Text = "Monthly deposit";
            // 
            // btnCalculateSaving
            // 
            this.btnCalculateSaving.Location = new System.Drawing.Point(840, 260);
            this.btnCalculateSaving.Name = "btnCalculateSaving";
            this.btnCalculateSaving.Size = new System.Drawing.Size(218, 35);
            this.btnCalculateSaving.TabIndex = 5;
            this.btnCalculateSaving.Text = "Calculate saving";
            this.btnCalculateSaving.UseVisualStyleBackColor = true;
            this.btnCalculateSaving.Click += new System.EventHandler(this.btnCalculateSaving_Click);
            // 
            // grpFutureValue
            // 
            this.grpFutureValue.Controls.Add(this.lblTotalFees);
            this.grpFutureValue.Controls.Add(this.lblAmountEarned);
            this.grpFutureValue.Controls.Add(this.label7);
            this.grpFutureValue.Controls.Add(this.label6);
            this.grpFutureValue.Controls.Add(this.lblFinalBalance);
            this.grpFutureValue.Controls.Add(this.lblAmountPaid);
            this.grpFutureValue.Controls.Add(this.label4);
            this.grpFutureValue.Controls.Add(this.label3);
            this.grpFutureValue.Location = new System.Drawing.Point(794, 317);
            this.grpFutureValue.Name = "grpFutureValue";
            this.grpFutureValue.Size = new System.Drawing.Size(308, 202);
            this.grpFutureValue.TabIndex = 6;
            this.grpFutureValue.TabStop = false;
            this.grpFutureValue.Text = "Future value";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalFees.Location = new System.Drawing.Point(165, 120);
            this.lblTotalFees.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(100, 18);
            this.lblTotalFees.TabIndex = 7;
            this.lblTotalFees.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAmountEarned
            // 
            this.lblAmountEarned.AutoSize = true;
            this.lblAmountEarned.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmountEarned.Location = new System.Drawing.Point(165, 63);
            this.lblAmountEarned.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblAmountEarned.Name = "lblAmountEarned";
            this.lblAmountEarned.Size = new System.Drawing.Size(100, 18);
            this.lblAmountEarned.TabIndex = 6;
            this.lblAmountEarned.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Total fees";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Amount earned";
            // 
            // lblFinalBalance
            // 
            this.lblFinalBalance.AutoSize = true;
            this.lblFinalBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFinalBalance.Location = new System.Drawing.Point(166, 89);
            this.lblFinalBalance.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblFinalBalance.Name = "lblFinalBalance";
            this.lblFinalBalance.Size = new System.Drawing.Size(100, 18);
            this.lblFinalBalance.TabIndex = 3;
            this.lblFinalBalance.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmountPaid.Location = new System.Drawing.Point(165, 31);
            this.lblAmountPaid.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(100, 18);
            this.lblAmountPaid.TabIndex = 2;
            this.lblAmountPaid.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Final balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Amount paid";
            // 
            // grpBMR
            // 
            this.grpBMR.Controls.Add(this.btnCalculateBMR);
            this.grpBMR.Controls.Add(this.txtAge);
            this.grpBMR.Controls.Add(this.lblAge);
            this.grpBMR.Controls.Add(this.lboxBMRResults);
            this.grpBMR.Controls.Add(this.grpWeeklyActivity);
            this.grpBMR.Controls.Add(this.grpGender);
            this.grpBMR.Location = new System.Drawing.Point(66, 558);
            this.grpBMR.Name = "grpBMR";
            this.grpBMR.Size = new System.Drawing.Size(1036, 338);
            this.grpBMR.TabIndex = 7;
            this.grpBMR.TabStop = false;
            this.grpBMR.Text = "BMR  Calculator";
            // 
            // btnCalculateBMR
            // 
            this.btnCalculateBMR.Location = new System.Drawing.Point(200, 263);
            this.btnCalculateBMR.Name = "btnCalculateBMR";
            this.btnCalculateBMR.Size = new System.Drawing.Size(167, 37);
            this.btnCalculateBMR.TabIndex = 5;
            this.btnCalculateBMR.Text = "Calculate BMR";
            this.btnCalculateBMR.UseVisualStyleBackColor = true;
            this.btnCalculateBMR.Click += new System.EventHandler(this.btnCalculateBMR_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(91, 170);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(47, 22);
            this.txtAge.TabIndex = 4;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(30, 170);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 16);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age";
            // 
            // lboxBMRResults
            // 
            this.lboxBMRResults.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lboxBMRResults.FormattingEnabled = true;
            this.lboxBMRResults.ItemHeight = 16;
            this.lboxBMRResults.Location = new System.Drawing.Point(544, 30);
            this.lboxBMRResults.Name = "lboxBMRResults";
            this.lboxBMRResults.Size = new System.Drawing.Size(486, 244);
            this.lboxBMRResults.TabIndex = 2;
            // 
            // grpWeeklyActivity
            // 
            this.grpWeeklyActivity.Controls.Add(this.rbtnExtraActive);
            this.grpWeeklyActivity.Controls.Add(this.rbtnVeryActive);
            this.grpWeeklyActivity.Controls.Add(this.rbtnModeratelyActive);
            this.grpWeeklyActivity.Controls.Add(this.rbtnLightlyActive);
            this.grpWeeklyActivity.Controls.Add(this.rbtnSedentary);
            this.grpWeeklyActivity.Location = new System.Drawing.Point(198, 30);
            this.grpWeeklyActivity.Name = "grpWeeklyActivity";
            this.grpWeeklyActivity.Size = new System.Drawing.Size(330, 215);
            this.grpWeeklyActivity.TabIndex = 1;
            this.grpWeeklyActivity.TabStop = false;
            this.grpWeeklyActivity.Text = "Weekly activity level";
            // 
            // rbtnExtraActive
            // 
            this.rbtnExtraActive.AutoSize = true;
            this.rbtnExtraActive.Location = new System.Drawing.Point(25, 180);
            this.rbtnExtraActive.Name = "rbtnExtraActive";
            this.rbtnExtraActive.Size = new System.Drawing.Size(228, 20);
            this.rbtnExtraActive.TabIndex = 4;
            this.rbtnExtraActive.TabStop = true;
            this.rbtnExtraActive.Text = "Extra active, hard exercises or job";
            this.rbtnExtraActive.UseVisualStyleBackColor = true;
            this.rbtnExtraActive.CheckedChanged += new System.EventHandler(this.rbtnExtraActive_CheckedChanged);
            // 
            // rbtnVeryActive
            // 
            this.rbtnVeryActive.AutoSize = true;
            this.rbtnVeryActive.Location = new System.Drawing.Point(25, 142);
            this.rbtnVeryActive.Name = "rbtnVeryActive";
            this.rbtnVeryActive.Size = new System.Drawing.Size(218, 20);
            this.rbtnVeryActive.TabIndex = 3;
            this.rbtnVeryActive.TabStop = true;
            this.rbtnVeryActive.Text = "Very active (6 to 7 times a week)";
            this.rbtnVeryActive.UseVisualStyleBackColor = true;
            this.rbtnVeryActive.CheckedChanged += new System.EventHandler(this.rbtnVeryActive_CheckedChanged);
            // 
            // rbtnModeratelyActive
            // 
            this.rbtnModeratelyActive.AutoSize = true;
            this.rbtnModeratelyActive.Location = new System.Drawing.Point(25, 103);
            this.rbtnModeratelyActive.Name = "rbtnModeratelyActive";
            this.rbtnModeratelyActive.Size = new System.Drawing.Size(268, 20);
            this.rbtnModeratelyActive.TabIndex = 2;
            this.rbtnModeratelyActive.TabStop = true;
            this.rbtnModeratelyActive.Text = "Moderatively active (3 to 5 times a week)";
            this.rbtnModeratelyActive.UseVisualStyleBackColor = true;
            this.rbtnModeratelyActive.CheckedChanged += new System.EventHandler(this.rbtnModeratelyActive_CheckedChanged);
            // 
            // rbtnLightlyActive
            // 
            this.rbtnLightlyActive.AutoSize = true;
            this.rbtnLightlyActive.Location = new System.Drawing.Point(25, 67);
            this.rbtnLightlyActive.Name = "rbtnLightlyActive";
            this.rbtnLightlyActive.Size = new System.Drawing.Size(228, 20);
            this.rbtnLightlyActive.TabIndex = 1;
            this.rbtnLightlyActive.TabStop = true;
            this.rbtnLightlyActive.Text = "Lightly active (1 to 3 times a week)";
            this.rbtnLightlyActive.UseVisualStyleBackColor = true;
            this.rbtnLightlyActive.CheckedChanged += new System.EventHandler(this.rbtnLightlyActive_CheckedChanged);
            // 
            // rbtnSedentary
            // 
            this.rbtnSedentary.AutoSize = true;
            this.rbtnSedentary.Location = new System.Drawing.Point(25, 34);
            this.rbtnSedentary.Name = "rbtnSedentary";
            this.rbtnSedentary.Size = new System.Drawing.Size(211, 20);
            this.rbtnSedentary.TabIndex = 0;
            this.rbtnSedentary.TabStop = true;
            this.rbtnSedentary.Text = "Sedentary (little or no exercise)";
            this.rbtnSedentary.UseVisualStyleBackColor = true;
            this.rbtnSedentary.CheckedChanged += new System.EventHandler(this.rbtnSedentary_CheckedChanged);
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rbtnMale);
            this.grpGender.Controls.Add(this.rbtnFemale);
            this.grpGender.Location = new System.Drawing.Point(19, 30);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(119, 87);
            this.grpGender.TabIndex = 0;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(20, 52);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(58, 20);
            this.rbtnMale.TabIndex = 1;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            this.rbtnMale.CheckedChanged += new System.EventHandler(this.rbtnMale_CheckedChanged);
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(20, 26);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(74, 20);
            this.rbtnFemale.TabIndex = 0;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            this.rbtnFemale.CheckedChanged += new System.EventHandler(this.rbtnFemale_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 969);
            this.Controls.Add(this.grpBMR);
            this.Controls.Add(this.grpFutureValue);
            this.Controls.Add(this.btnCalculateSaving);
            this.Controls.Add(this.grpSavingPlan);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCalculateBMI);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Calculator by Michał Ostrowski";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.grpSavingPlan.ResumeLayout(false);
            this.grpSavingPlan.PerformLayout();
            this.grpFutureValue.ResumeLayout(false);
            this.grpFutureValue.PerformLayout();
            this.grpBMR.ResumeLayout(false);
            this.grpBMR.PerformLayout();
            this.grpWeeklyActivity.ResumeLayout(false);
            this.grpWeeklyActivity.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCalculateBMI;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnImperial;
        private System.Windows.Forms.RadioButton rbtnMetric;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblWeightCategory;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNormalBMI;
        private System.Windows.Forms.Label lblNormalWeight;
        private System.Windows.Forms.TextBox txtHeighInch;
        private System.Windows.Forms.GroupBox grpSavingPlan;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.TextBox txtMonthlyDeposit;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblMonthlyDeposit;
        private System.Windows.Forms.Button btnCalculateSaving;
        private System.Windows.Forms.GroupBox grpFutureValue;
        private System.Windows.Forms.Label lblFinalBalance;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.TextBox txtGrowth;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblGrowth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAmountEarned;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.GroupBox grpBMR;
        private System.Windows.Forms.GroupBox grpWeeklyActivity;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.ListBox lboxBMRResults;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnExtraActive;
        private System.Windows.Forms.RadioButton rbtnVeryActive;
        private System.Windows.Forms.RadioButton rbtnModeratelyActive;
        private System.Windows.Forms.RadioButton rbtnLightlyActive;
        private System.Windows.Forms.RadioButton rbtnSedentary;
        private System.Windows.Forms.Button btnCalculateBMR;
        private System.Windows.Forms.TextBox txtInitialDeposit;
        private System.Windows.Forms.Label label5;
    }
}

