using System;

namespace ATMInternational.Software
{
    public class AtmLogic : IAtmLogic
    {
        /// <summary>
        /// User's account balance in coins
        /// </summary>
        public int AccountBalance { get; private set; }

        /// <summary>
        /// User's total daily withdrawal amount
        /// </summary>
        public int TotalDailyWithdrawal { get; private set; }

        /// <summary>
        /// Message to show the user
        /// </summary>
        public string UserMessage { get; private set; }
        
        /// <summary>
        /// Deposits coins into the user's account
        /// </summary>
        /// <param name="coinsToDeposit">Amount of coins to deposit</param>
        /// <returns>True if the deposit was successful; otherwise false</returns>
        public bool Deposit(int coinsToDeposit)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Withdrawals coins from the user's account if the user has the funds available
        /// and is below the maximum daily withdrawal limit
        /// </summary>
        /// <param name="coinsToWithdrawal">Amount of coins to withdrawal</param>
        /// <returns>True if the withdrawal was successful; otherwise false</returns>
        public bool Withdrawal(int coinsToWithdrawal)
        {
            throw new NotImplementedException();
        }
    }
}