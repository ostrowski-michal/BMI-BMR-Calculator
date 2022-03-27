// BMRCalculator.cs
// Created: Michał Ostrowski, 2022-03-16
// Purpose: Class to calculate BMR

namespace Assignment3
{
    internal class BMRCalculator
    {
        private int age;
        private Gender gender;
        private WeeklyActivityLevel level;

        #region Getters and Setters
        public int GetAge()
        {
            return age;
        }
        public void SetAge(int age)
        {
            if (age > 0)
            this.age = age;
        }
        public Gender GetGender()
        {
            return gender;
        }
        public void SetGender(Gender gender)
        {
            this.gender = gender;
        }
        public WeeklyActivityLevel GetWeeklyActivityLevel()
        {
            return level;
        }
        public void SetWeeklyActivityLevel(WeeklyActivityLevel activityLevel)
        {
            level = activityLevel;
        }
        #endregion

        /// <summary>
        /// Calculate the user's BMR based on the weight (kg), height (cm), age and gender
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        /// <returns>The user's BMR</returns>
        public double CalculateBMR(double weight, double height)
        {
            double bMR = 10 * weight + 6.25 * height - 5 * age;

            if (gender == Gender.Female)
                bMR = bMR - 161;
            else
                bMR = bMR + 5;

            return bMR;
        }

        /// <summary>
        /// Calculate the user's BMR to keep current weight.
        /// It depends on weekly activity level.
        /// </summary>
        /// <param name="bmr"></param>
        /// <returns>BMR which user should eat daily to keep current weight</returns>
        public double CalculateBMRToKeepCurrentWeight(double bmr)
        {
            double maintainWeightBMRs = 0.0;
            double factor = 0.0;

            switch (level)
            {
                case WeeklyActivityLevel.Sedentary : factor = 1.2;
                    break;
                case WeeklyActivityLevel.LightlyActive : factor = 1.375;
                    break;
                case WeeklyActivityLevel.ModeratelyActive : factor = 1.550;
                    break;
                case WeeklyActivityLevel.VeryActive : factor = 1.725;
                    break;
                case WeeklyActivityLevel.ExtraActive : factor = 1.9;
                    break;
            }

            maintainWeightBMRs = bmr * factor;

            return maintainWeightBMRs;
        }

        /// <summary>
        /// Calculate daily BMR the user should eat to gain or lose weight
        /// </summary>
        /// <param name="maintainWeightBMR">Daily BMR to keep current weight</param>
        /// <param name="kgToLoseOrAdd">kg to lose or gain</param>
        /// <returns>Daily BMR to lose or gain weight</returns>
        public double CalculateBMRToLoseOrGainWeight(double maintainWeightBMR, double kgToLoseOrAdd)
        {
            double calculatedBMR = maintainWeightBMR + kgToLoseOrAdd * 1000;
            return calculatedBMR;
        }

    }
}
