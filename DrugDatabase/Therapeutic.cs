using System;

namespace DrugDatabase
{
	public class Therapeutic
	{
		public Therapeutic (int drugCode, string tcAtcNumber, string tcAtc, string tcAhfsNumber, string tcAhfs)
		{
			this.DRUG_CODE = drugCode;
			this.TC_ATC_NUMBER = tcAtcNumber;
			this.TC_ATC = tcAtc;
			this.TC_AHFS_NUMBER = tcAhfsNumber;
			this.TC_AHFS = tcAhfs;
		}

		public int DRUG_CODE	{ get; private set; }

		public string TC_ATC_NUMBER { get; private set; }

		public string TC_ATC { get; private set; }

		public string TC_AHFS_NUMBER { get; private set; }

		public string TC_AHFS { get; private set; }
	}
}

