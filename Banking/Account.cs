using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking {
	abstract class Account {

		public string AccountNumber { get; set; }
		public string Owner { get; set; }
		public string Description { get; set; }
		public decimal Balance { get; private set; }

		public void Deposit(decimal Amount) {
			if (Amount <= 0) {
				Console.WriteLine("The amount must be greater than 0");
				return;
			}
			Balance += Amount;
		}

		public void Withdrawl(decimal Amount) {
			if (Amount <= 0) {
				Console.WriteLine("The amount must be greater than 0");
				return;
			}
			if (Amount > Balance) {
				Console.WriteLine("The amount must not exceed the balance");
				return;
			}
			Balance -= Amount;
		}

		public decimal GetBalance() {
			return Decimal.Round(Balance, 2);
		}

		public void Print() {
			Console.WriteLine($"{Owner} your balance is {Balance}");
		}
	}
}
