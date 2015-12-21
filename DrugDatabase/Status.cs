using System;

namespace DrugDatabase
{
	public class Status
	{
		public Status (int drugCode, string currentStatusFlag, string status, DateTime historyDate)
		{
			this.DRUG_CODE = drugCode;
			this.CURRENT_STATUS_FLAG = currentStatusFlag;
			this.STATUS = status;
			this.HISTORY_DATE = historyDate;
		}

		public int DRUG_CODE { get; private set; }

		public string CURRENT_STATUS_FLAG { get; private set; }

		public string STATUS { get; private set; }

		public DateTime HISTORY_DATE { get; private set; }
	}
}

