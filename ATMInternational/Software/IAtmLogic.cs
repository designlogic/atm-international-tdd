namespace ATMInternational.Software
{
    public interface IAtmLogic
    {
        /// <summary>
        /// User's account balance in coins
        /// </summary>
        int AccountBalance { get; }

        /// <summary>
        /// User's total daily withdrawal amount
        /// </summary>
        int TotalDailyWithdrawal { get; }

        /// <summary>
        /// Message to show the user
        /// </summary>
        string UserMessage { get; }

        /// <summary>
        /// Deposits coins into the user's account
        /// </summary>
        /// <param name="coinsToDeposit">Amount of coins to deposit</param>
        /// <returns>True if the deposit was successful; otherwise false</returns>
        bool Deposit(int coinsToDeposit);

        /// <summary>
        /// Withdrawals coins from the user's account if the user has the funds available
        /// and is below the maximum daily withdrawal limit
        /// </summary>
        /// <param name="coinsToWithdrawal">Amount of coins to withdrawal</param>
        /// <returns>True if the withdrawal was successful; otherwise false</returns>
        bool Withdrawal(int coinsToWithdrawal);
    }
}