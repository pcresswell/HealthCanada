using System;

namespace DrugDatabase
{
	public class Schedule
	{
		public Schedule (int drugCode, string schedule)
		{
			this.DRUG_CODE = drugCode;
			this.SCHEDULE = schedule;
		}

		public int DRUG_CODE { get; private set; }

		public string SCHEDULE { get; private set; }
	}
}

