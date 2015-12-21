using System;

namespace DrugDatabase
{
	public class Form
	{
		public Form (int drugCode, int pharmFormCode, string pharmaceuticalForm)
		{
			this.DRUG_CODE = drugCode;
			this.PHARM_FORM_CODE = pharmFormCode;
			this.PHARMACEUTICAL_FORM = pharmaceuticalForm;
		}

		public int DRUG_CODE { get; private set; }

		public int PHARM_FORM_CODE { get; private set; }

		public string PHARMACEUTICAL_FORM { get; private set; }
	}
}

