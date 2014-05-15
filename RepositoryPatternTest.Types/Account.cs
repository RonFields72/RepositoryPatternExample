using System;

namespace RepositoryPatternTest.Types
{
	public class Account
	{
		public string AccountNumber;
		public string Location;
		public int SaleType;
		public int LoanType;
		public bool IsNewConstruction;

		public Account ()
		{
		}

        public Account(string accountNumber, string location, int saleType, int loanType, bool isNewConstruction)
		{
            AccountNumber = accountNumber;
            Location = location;
            SaleType = saleType;
            LoanType = loanType;
            IsNewConstruction = isNewConstruction;
		}
	}
}

