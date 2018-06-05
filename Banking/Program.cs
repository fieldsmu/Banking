using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking {
	class Program {
		static void Main(string[] args) {

			Checking Checking = new Checking("45069", "This is my checking account") {
				Owner = "Fields, Marcus",
			};
			Checking.Deposit(10000);
			Checking.Withdrawl(500);
			Checking.WriteCheck("Porsche of Kings Auto Mall", 300);

			Savings Savings = new Savings("45070", "This is my savings account") {
				Owner = "Fields, Marcus",
				Description = "This is my savings account"
			};
			Savings.Deposit(2000);
			Savings.Withdrawl(700);

			List<Account> Accounts = new List<Account> { Checking, Savings };
			decimal TotalOfAllAccounts = 0;
			foreach (Account Account in Accounts) {
				TotalOfAllAccounts += Account.GetBalance();
				Account.Print();
			}
		}
	}
}
