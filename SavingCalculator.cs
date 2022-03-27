// SavingCalculator.cs
// Created: Michał Ostrowski, 2022-03-13
// Purpose: Calculate the saving plan;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class SavingCalculator
    {
        private double initialDeposit;
        private double monthlyDeposit;
        private int years;
        private double interestRate;
        private double fees;

        #region Getters and Setters
        public double GetInitialDeposit()
        {
            return initialDeposit;
        }
        public void SetInitialDeposit(double deposit)
        {
            if (deposit >= 0.0)
                initialDeposit = deposit;
        }
        public double GetMonthlyDeposit()
        {
            return monthlyDeposit;
        }
        public void SetMonthlyDeposit(double deposit)
        {
            if (deposit >= 0.0)
                monthlyDeposit = deposit;
        }
        public int GetPeriod()
        {
            return years;
        }
        public void SetPeriod(int years)
        {
            if (years >= 0)
                this.years = years;
        }
        public double GetInterestRate()
        {
            return interestRate;
        }
        public void SetInterestRate(double growth)
        {
            if (growth >= 0.0)
                interestRate = growth;
        }
        public double GetFees()
        {
            return fees;
        }
        public void SetFees(double fees)
        {
            if (fees >= 0.0)
                this.fees = fees;
        }
        #endregion

        /// <summary>
        /// Calculate future values: amount paid, amount earned, final balance and total fees
        /// based on initial deposit, monthly deposit, period (years), interest (%), and fees (%). 
        /// </summary>
        /// <param name="amountPaid"></param>
        /// <param name="interestEarned"></param>
        /// <param name="totalFees"></param>
        /// <returns></returns>
        public double CalculateFutureValue(out double amountPaid, out double interestEarned, out double totalFees)
        {
            double balance = initialDeposit;
            int numOfMonths = years * 12;
            double monthlyInterestRate = interestRate / 12;
            double monthlyFeesRate = fees / 12;

            amountPaid = monthlyDeposit * numOfMonths;
            totalFees = 0.0;
            interestEarned = 0.0;

            for (int i = 1; i <= numOfMonths; i++)
            {
                double monthlyFees = balance * monthlyFeesRate;
                double monthlyInterestEarned = balance * monthlyInterestRate;
                
                interestEarned += monthlyInterestEarned;
                totalFees += monthlyFees;
                balance += monthlyInterestEarned + monthlyDeposit - monthlyFees;
            }

            return balance;
        }

        /// <summary>
        /// Calculate future values - basic saving plan. Used at the beginning.
        /// Based only on interest rate and monthly deposit
        /// </summary>
        /// <param name="amountPaid">Total paid amount</param>
        /// <returns>Final balance</returns>
        //public double CalculateFutureValue(out double amountPaid)
        //{
        //    double balance = 0.0;
        //    int numOfMonths = years * 12;
        //    double monthlyInterestRate = interestRate / 12;

        //    amountPaid = monthlyDeposit * numOfMonths;

        //    for (int i = 1; i <= numOfMonths; i++)
        //    {
        //        double interestEarned = monthlyInterestRate * balance;
        //        balance += interestEarned + monthlyDeposit;
        //    }

        //    return balance;
        //}
    }
}
