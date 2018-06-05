using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking {
	class Checking : Account {

		public int NextCheckNumber { get; set; } = 1;

		public void WriteCheck(string Payee, decimal Amount) {
			int CheckNumber = NextCheckNumber++;
			this.Withdrawl(Amount);
		}

		public Checking(string AccountNumber, string Description) {
			this.AccountNumber = AccountNumber;
			this.Description = Description;
			this.Balance = 0;
		}
	}
}
