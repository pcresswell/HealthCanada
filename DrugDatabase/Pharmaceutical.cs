using System;

namespace DrugDatabase
{
	public class Pharmaceutical
	{
		public Pharmaceutical (int drugCode, string pharmaceuticalStd)
		{
			this.DRUG_CODE = drugCode;
			this.PHARMACEUTICAL_STD = pharmaceuticalStd;
		}

		public int DRUG_CODE { get; private set; }

		public string PHARMACEUTICAL_STD { get; private set; }
	}
}

