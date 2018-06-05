﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking {
	class Savings : Account {

		public string AccountNumber { get; set; }
		public decimal InterestRate { get; set; }
		public int InterestPeriod { get; set; }

		public void CalculateInterest(int AmountOfPeriods) {
			decimal InterestRatePerPeriod = InterestRate / InterestPeriod;
			decimal Interest = GetBalance() * InterestRatePerPeriod * AmountOfPeriods;
			Deposit(Interest);
		}

		public decimal GetBalance() {
			return Balance;
		}

		public decimal GetInterestRate() {
			return InterestRate;
		}

		public Savings(string AccountNumber, string Description) {
			this.AccountNumber = AccountNumber;
			this.Description = Description;
			this.Balance = 0;
			this.InterestRate = .01M;
			this.InterestPeriod = 12;
		}
	}
}
