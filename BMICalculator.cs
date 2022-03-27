// BMICalculator.cs
// Created: Michał Ostrowski, 2022-03-12
// Purpose: Class to calculate BMI

namespace Assignment3
{
    internal class BMICalculator
    {
        private double height = 0;  // m, feet
        private double weight = 0;  // kg, lb
        private UnitTypes unit;


        #region Getters and Setters
        public double GetHeight()
        {
            return height;
        }
        public void SetHeight(double height)
        {
            if (height > 0)
                this.height = height;   
        }
        public double GetWeight()
        {
            return weight;
        }
        public void SetWeight(double weight)
        {
            this.weight = weight;
        }
        public UnitTypes GetUnit()
        {
            return unit;
        }
        public void SetUnitTypes(UnitTypes type)
        {
            unit = type;
        }
        #endregion

        /// <summary>
        /// Calculate user's BMI
        /// </summary>
        /// <returns>User's BMI</returns>
        public double CalculateBMI()
        {
            double bmi = 0.0;
            
            if (unit == UnitTypes.Metric)
                bmi = weight / (height * height);
            else 
                bmi = 703.0 * weight / (height * height);
            return bmi;
        }

        /// <summary>
        /// Calculate BMI weight category based on the BMI value
        /// </summary>
        /// <returns>BMI weight category</returns>
        public string BmiWeightCategory()
        {
            double bmi = CalculateBMI();
            string stringout = string.Empty;
            if (bmi > 40)
                stringout = "Overweight (Obesity class III)";
            else if (bmi >= 35)
                stringout = "Overweight (Obesity class II)";
            else if (bmi >= 30)
                stringout = "Overweight(Obesity class I)";
            else if (bmi >= 25)
                stringout = "Overweight (Pre-obesity)";
            else if (bmi >= 18.5)
                stringout = "Normal weight";
            else
                stringout = "Underweight";

            return stringout;
        }

        /// <summary>
        /// Calculate the range user should weight to havve Normal BMI
        /// </summary>
        /// <returns>Range of the weight to normal BMI</returns>
        public string NormalWeight()
        {
            double lowNormalWeight = 0.0;
            double highNormalWeight = 0.0;
            string unitType = string.Empty;

            const double lowLimitBMI = 18.5;
            const double highLimitBMI = 24.9;

            if (unit == UnitTypes.Metric)
            {
                highNormalWeight = highLimitBMI * (height * height);
                lowNormalWeight = lowLimitBMI * (height * height);
                unitType = "kg";
            }
            else
            {
                highNormalWeight = highLimitBMI * (height * height) / 703.0;
                lowNormalWeight = lowLimitBMI * (height * height) / 703.0;
                unitType = "lbs";
            }

            return string.Format("Normal weight should be between {0,3:f1} and {1,3:f1} ",
                lowNormalWeight, highNormalWeight) + unitType;
        }
    }
}
