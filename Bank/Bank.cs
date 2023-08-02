using System.Runtime.CompilerServices;

namespace Bank
{
    public static class Bank
    {
        public static int AccountNumber { get; set; }
        public static string AccountName { get; set; }
        public static float AccountBalance { get; set; }

        public static void Deposit(float amount)
        {
            AccountBalance += amount;
        }

        public static void Withdraw(float amount)
        {
            AccountBalance += amount;
        }

        public static float CheckBalance()
        {
            return AccountBalance;
        }
    }
}