// MainForm.cs
// Created: Michał Ostrowski, 2022-03-13
// Purpose: Class that acts as a graphical user interface.
using System;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class MainForm : Form
    {
        private string name = "No Name";

        //create an instance of BMICalculator
        private BMICalculator bmiCalc = new BMICalculator();

        //create an instance of SavingCalculator
        private SavingCalculator savingCalculator = new SavingCalculator();

        //create an instance of BMRCalculator
        private BMRCalculator bmrCalc = new BMRCalculator();

        /// <summary>
        /// Initialize method
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// Initialize GUI
        /// Clear all the results
        /// Set default values
        /// </summary>
        private void InitializeGUI()
        {
            this.Text = "Super Calculator by Michał Ostrowski";
            

            //input controls
            rbtnImperial.Checked = true;
            lblHeight.Text = "Height (feet)";
            lblWeight.Text = "Weight (lbs)";
            rbtnFemale.Checked = true;
            rbtnLightlyActive.Checked = true;

            //output controls
            txtWeight.Text = string.Empty;
            txtHeight.Text = string.Empty;
            txtHeighInch.Text = string.Empty;
            lblNormalBMI.Text = string.Empty;
            lblNormalWeight.Text = string.Empty;

        }

        #region BMICalculator
        /// <summary>
        /// Read Input for the BMI Calculator
        /// </summary>
        /// <returns>True if all provided inputs are valid, false otherwise</returns>
        private bool ReadInputBMI()
        {
            ReadName();

            bool heightOK = ReadHeight();

            bool weightOK = ReadWeight();

            return heightOK && weightOK;
        }

        /// <summary>
        /// Read user's name
        /// </summary>
        private void ReadName()
        {
            txtName.Text.Trim();

            bool ok = !string.IsNullOrEmpty(txtName.Text);
            if (ok)
                name = txtName.Text;
        }

        /// <summary>
        /// Read user's height
        /// </summary>
        /// <returns>True if all provided inputs are valid, false otherwise</returns>
        private bool ReadHeight()
        {
            double height = 0.0;

            bool ok = double.TryParse(txtHeight.Text.Trim(), out height);

            if (ok)
            {
                if (height > 0)
                {
                    if (bmiCalc.GetUnit() == UnitTypes.Imperial)
                    {
                        double heighInch = 0.0;
                        bool okInches = double.TryParse(txtHeighInch.Text.Trim(), out heighInch);

                        if (okInches) 
                            bmiCalc.SetHeight(height * 12.00 + heighInch);  //feet to inches
                        else
                            MessageBox.Show("Invalid height value!", "Error");
                    }
                    else
                    {
                        bmiCalc.SetHeight(height / 100.0);  //cm --> m
                    }
                } 
                else 
                    ok = false;
            }

            if (!ok)
                MessageBox.Show("Invalid height value!", "Error");

            return ok;

        }

        /// <summary>
        /// Read user's weight
        /// </summary>
        /// <returns>True if all provided inputs are valid, false otherwise</returns>
        private bool ReadWeight()
        {
            double weight = 0.0;

            bool ok = double.TryParse(txtWeight.Text.Trim(), out weight);

            if (ok && (weight > 0.0))
                bmiCalc.SetWeight(weight);
            else
                MessageBox.Show("Invalid weight value!", "Error");

            return ok;
        }

        /// <summary>
        /// Read input from the user, calculate the user's BMI and display results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculateBMI_Click(object sender, EventArgs e)
        {
            //clear previous results
            ClearBMIResults();

            //read input
            bool ok = ReadInputBMI();

            if (ok)
                DisplayBMIResults();   //calculate and display results
        }

        /// <summary>
        /// Change units to metric
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMetric.Checked)
            {
                lblHeight.Text = "Height (cm)";
                lblWeight.Text = "Weight (kg)";
                bmiCalc.SetUnitTypes(UnitTypes.Metric);
                txtHeighInch.Hide();
            }
        }

        /// <summary>
        /// CHange units to Imperial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnImperial_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnImperial.Checked)
            {
                lblHeight.Text = "Height (feet, inch)";
                lblWeight.Text = "Weight (lbs)";
                bmiCalc.SetUnitTypes(UnitTypes.Imperial);
                txtHeighInch.Show();
            }
        }

        /// <summary>
        /// Clear results
        /// </summary>
        private void ClearBMIResults()
        {
            lblBMI.Text = string.Empty;
            lblWeightCategory.Text = string.Empty;
            lblNormalBMI.Text = string.Empty;
            lblNormalWeight.Text = string.Empty;
        }

        /// <summary>
        /// Display results to the user
        /// </summary>
        private void DisplayBMIResults()
        {
            lblBMI.Text = bmiCalc.CalculateBMI().ToString("f2");                //calculate bmi 
            lblWeightCategory.Text = bmiCalc.BmiWeightCategory().ToString();    //calculate weight category
            lblNormalBMI.Text = "Normal BMI is between 18.5 and 24.9";
            lblNormalWeight.Text = bmiCalc.NormalWeight().ToString() ;          //calculate normal weight range for the user's height
            grpResults.Text = "Results for " + name;
        }
        #endregion

        #region Saving calculator
        /// <summary>
        /// Read input from the user, caluclate the future value, display results to the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculateSaving_Click(object sender, EventArgs e)
        {
            //Read input
            bool ok = ReadSavingInput();

            //if input is ok calculate and display results
            if (ok)
                DisplayFutureSavingResults();
        }

        /// <summary>
        /// Read user's input
        /// </summary>
        /// <returns>True if all provided inputs are valid, false otherwise</returns>
        private bool ReadSavingInput()
        {
            bool depositOK = ReadMonthlyDeposit();

            bool periodOK = ReadPeriod();

            bool growthOK = ReadGrowth();

            bool feesOK = ReadFees();
          
            return depositOK && periodOK && growthOK && feesOK;
        }

        /// <summary>
        /// Read initial deposit. Set value to the SavingCalculator instance variable
        /// </summary>
        /// <returns>True if provided input is valid, false otherwise</returns>
        private bool ReadInitialDeposit()
        {
            bool ok = true;

            double initialDeposit = ReadDouble(txtInitialDeposit.Text, out ok);
            if (ok && (initialDeposit >= 0.0))
                savingCalculator.SetInitialDeposit(initialDeposit);
            else
                MessageBox.Show("Invalid value for initial deposit!");

            return ok;
        }

        /// <summary>
        /// Read monthly deposit. Set value to the SavingCalculator instance variable.
        /// </summary>
        /// <returns>True if provided input is valid, false otherwise</returns>
        private bool ReadMonthlyDeposit()
        {
            bool ok = true;

            double monthlyDeposit = ReadDouble(txtMonthlyDeposit.Text, out ok);
            if (ok && (monthlyDeposit >= 0.0))
                savingCalculator.SetMonthlyDeposit(monthlyDeposit);
            else
                MessageBox.Show("Invalid value for monthly deposit!");

            return ok;
        }

        /// <summary>
        /// Read period (years). Set value to the SavingCalculator instance variable
        /// </summary>
        /// <returns>True if provided input is valid, false otherwise</returns>
        private bool ReadPeriod()
        {
            bool ok = true;

            int period = ReadInt(txtPeriod.Text, out ok);
            if (ok && (period >= 0.0))
                savingCalculator.SetPeriod(period);
            else
                MessageBox.Show("Invalid value for period");

            return ok;
        }

        /// <summary>
        /// Read yearly growth in %. Set value to the SavingCalculator instance variable
        /// </summary>
        /// <returns>True if provided input is valid, false otherwise</returns>
        private bool ReadGrowth()
        {
            bool ok = true;

            double interestInPercent = ReadDouble(txtGrowth.Text, out ok);
            if (ok && (interestInPercent >= 0.0))
            {
                double interest = interestInPercent / 100;
                savingCalculator.SetInterestRate(interest);
            }
            else
                MessageBox.Show("Invalid value for growth");

            return ok;
        }

        /// <summary>
        /// Read yearly fees in %. Set value to the SavingCalculator instance variable
        /// </summary>
        /// <returns>True if provided input is valid, false otherwise</returns>
        private bool ReadFees()
        {
            bool ok = true;

            double feesInPercent = ReadDouble(txtFees.Text, out ok);
            if (ok && (feesInPercent >= 0.0))
            {
                double fees = feesInPercent / 100;
                savingCalculator.SetFees(fees);
            }
            else
                MessageBox.Show("Invalid value for fees");

            return ok;
        }

        /// <summary>
        /// Calculate results and display them to the user
        /// </summary>
        private void DisplayFutureSavingResults()
        {
            double amountPaid = 0.0;
            double amountEarned = 0.0;
            double totalFees = 0.0;
            double finalBalance = savingCalculator.CalculateFutureValue(out amountPaid, out amountEarned, out totalFees);

            lblAmountPaid.Text = amountPaid.ToString("f2");
            lblAmountEarned.Text = amountEarned.ToString("f2");
            lblFinalBalance.Text = finalBalance.ToString("f2");
            lblTotalFees.Text = totalFees.ToString("f2");
        }
        #endregion

        #region BMR Calculator

        /// <summary>
        /// Read input for BMRCalculator, calculate the user's BMR results and display them to the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculateBMR_Click(object sender, EventArgs e)
        {
            //Clear previous results
            lboxBMRResults.Items.Clear();

            //Read input
            bool bmiInputOK = ReadInputBMI();
            bool bmrInputOK = ReadInputBMR();

            //if input is ok calculate and display results
            if (bmiInputOK && bmrInputOK)
                DisplayBMRResults();
        }

        /// <summary>
        /// Change gender to female
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
                bmrCalc.SetGender(Gender.Female);
        }

        /// <summary>
        /// Change gender to male
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.SetGender(Gender.Male);
        }

        /// <summary>
        /// Change Weekly activity level to sedentary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnSedentary_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.SetWeeklyActivityLevel(WeeklyActivityLevel.Sedentary);
        }

        /// <summary>
        /// Change Weekly activity level to lightly active
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnLightlyActive_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.SetWeeklyActivityLevel(WeeklyActivityLevel.LightlyActive);
        }

        /// <summary>
        /// Change Weekly activity level to moderately active
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnModeratelyActive_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.SetWeeklyActivityLevel(WeeklyActivityLevel.ModeratelyActive);   
        }

        /// <summary>
        /// Change Weekly activity level to VeryActive
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnVeryActive_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.SetWeeklyActivityLevel(WeeklyActivityLevel.VeryActive);
        }

        /// <summary>
        /// Change Weekly activity level to ExtraActive
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnExtraActive_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.SetWeeklyActivityLevel(WeeklyActivityLevel.ExtraActive);
        }

        /// <summary>
        /// Read the users age
        /// </summary>
        /// <returns></returns>
        private bool ReadInputBMR()
        {
            bool ok = true;
            int age = ReadInt(txtAge.Text, out ok);
            if (ok && (age >= 0))
                bmrCalc.SetAge(age);
            else
                MessageBox.Show("Invalid value for age");

            return ok;
        }

        
        /// <summary>
        /// Calculate results through the methods of the BMRCalculator class.
        /// Display values to the user through the listbox
        /// </summary>
        private void DisplayBMRResults()
        {
            string line = string.Empty;
            double bmr = 0.0;                       // bmr - depends on the gender, age , weight and height
            double bmrToMaintainWeight = 0.0;       // bmr to keep current weight   
            double kgsToLoseOrAdd = 0.0;            // -0.5 to lose 0.5kg; 0.5 to add 0.5kg, etc.
            double bmrToLoseOrAddWeight = 0.0;

            //if values are in imperial units convert them to metric
            if (bmiCalc.GetUnit() == UnitTypes.Imperial)
                ConvertImperialToMetric();
            else
            {
                //m -> cm to calculate BMR
                double heightCm = bmiCalc.GetHeight() * 100;
                bmiCalc.SetHeight(heightCm);
            }

            lboxBMRResults.Items.Add("BMR RESULTS FOR " + name.ToUpper());
            lboxBMRResults.Items.Add(string.Empty);

            //Calculate BMR
            line = "Your BMR (calories/day)";
            bmr = bmrCalc.CalculateBMR(bmiCalc.GetWeight(), bmiCalc.GetHeight());
            lboxBMRResults.Items.Add(ToString(line, bmr));

            //Calculate BMR to keep current weight
            line = "Calories to maintain your weight";
            bmrToMaintainWeight = bmrCalc.CalculateBMRToKeepCurrentWeight(bmr);
            lboxBMRResults.Items.Add(ToString(line, bmrToMaintainWeight));

            //Calculate BMR to lose 0,5 kg per week
            line = "Calories to lose 0,5kg per week";
            kgsToLoseOrAdd = -0.5;
            bmrToLoseOrAddWeight = bmrCalc.CalculateBMRToLoseOrGainWeight(bmrToMaintainWeight, kgsToLoseOrAdd);
            lboxBMRResults.Items.Add(ToString(line, bmrToLoseOrAddWeight));

            //Calculate BMR to lose 1 kg per week
            line = "Calories to lose 1 kg per week";
            kgsToLoseOrAdd = -1.0;
            bmrToLoseOrAddWeight = bmrCalc.CalculateBMRToLoseOrGainWeight(bmrToMaintainWeight, kgsToLoseOrAdd);
            lboxBMRResults.Items.Add(ToString(line, bmrToLoseOrAddWeight));

            //Calculate BMR to gain 0,5 kg per week
            line = "Calories to gain 0,5 kg per week";
            kgsToLoseOrAdd = 0.5;
            bmrToLoseOrAddWeight = bmrCalc.CalculateBMRToLoseOrGainWeight(bmrToMaintainWeight, kgsToLoseOrAdd);
            lboxBMRResults.Items.Add(ToString(line, bmrToLoseOrAddWeight));

            //Calculate BMR to gain 1 kg per week
            line = "Calories to gain 1 kg per week";
            kgsToLoseOrAdd = 1.0;
            bmrToLoseOrAddWeight = bmrCalc.CalculateBMRToLoseOrGainWeight(bmrToMaintainWeight, kgsToLoseOrAdd);
            lboxBMRResults.Items.Add(ToString(line, bmrToLoseOrAddWeight));

            lboxBMRResults.Items.Add(string.Empty);

            line = "Losing more than 1000 calories per day is to be avoided.";
            lboxBMRResults.Items.Add(line);

        }

        /// <summary>
        /// Convert imperial units to metric - set values to BMICalculator instance variables
        /// </summary>
        private void ConvertImperialToMetric()
        {
            const double lbsToKgRate = 0.45359237;
            double weight = bmiCalc.GetWeight() * lbsToKgRate;
            bmiCalc.SetWeight(weight);

            const double inchToCmRate = 2.54;
            double height = bmiCalc.GetHeight() * inchToCmRate;
            bmiCalc.SetHeight(height);
        }

        /// <summary>
        /// Format output for the BMRCaclulator
        /// </summary>
        /// <param name="text"></param>
        /// <param name="value"></param>
        /// <returns>Oneline string</returns>
        private string ToString(string text, double value)
        {
            string textOut = string.Format("{0, -40}{1, 12:f2}", text, value);
            return textOut;
        }
        #endregion

        #region Read double, int, etc.
        /// <summary>
        /// Read double method
        /// </summary>
        /// <param name="str"></param>
        /// <param name="success"></param>
        /// <returns>Value from the input</returns>
        private double ReadDouble(string str, out bool success)
        {
            double value = -1.00;
            success = false;
            if (double.TryParse(str, out value))
                success = true;

            return value;
        }

        /// <summary>
        /// Read int method
        /// </summary>
        /// <param name="str"></param>
        /// <param name="success"></param>
        /// <returns>Value from the input</returns>
        private int ReadInt(string str, out bool success)
        {
            int value = -1;
            success = false;
            if (int.TryParse(str, out value))
                success = true;

            return value;
        }
        #endregion   
    }
}
