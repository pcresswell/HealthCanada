using System;

namespace DrugDatabase
{
	public class Company
	{
		public Company (int drugCode,
		                string mfrCode,
		                string companyCode,
		                string companyName,
		                string companyType,
		                string addressMailingFlag,
		                string addressBillingFlag,
		                string addressNotificationFlag,
		                string addressOther,
		                string suiteNumber,
		                string streetName,
		                string cityName,
		                string province,
		                string country,
		                string postalCode,
		                string postOfficeBox)
		{
			this.DRUG_CODE = drugCode;
			this.MFR_CODE = mfrCode;
			this.COMPANY_CODE = companyCode;
			this.COMPANY_NAME = companyName;
			this.COMPANY_TYPE = companyType;
			this.ADDRESS_MAILING_FLAG = addressMailingFlag;
			this.ADDRESS_BILLING_FLAG = addressBillingFlag;
			this.ADDRESS_NOTIFICATION_FLAG = addressNotificationFlag;
			this.ADDRESS_OTHER = addressOther;
			this.SUITE_NUMBER = suiteNumber;
			this.STREET_NAME = streetName;
			this.CITY_NAME = cityName;
			this.PROVINCE = province;
			this.COUNTRY = country;
			this.POSTAL_CODE = postalCode;
			this.POST_OFFICE_BOX = postOfficeBox;
		}

		public int DRUG_CODE { get; private set; }

		public string MFR_CODE { get; private set; }

		public string COMPANY_CODE { get; private set; }

		public string COMPANY_NAME { get; private set; }

		public string COMPANY_TYPE { get; private set; }

		public string ADDRESS_MAILING_FLAG { get; private set; }

		public string ADDRESS_BILLING_FLAG { get; private set; }

		public string ADDRESS_NOTIFICATION_FLAG	 { get; private set; }

		public string ADDRESS_OTHER { get; private set; }

		public string SUITE_NUMBER { get; private set; }

		public string STREET_NAME { get; private set; }

		public string CITY_NAME { get; private set; }

		public string PROVINCE { get; private set; }

		public string COUNTRY { get; private set; }

		public string POSTAL_CODE { get; private set; }

		public string POST_OFFICE_BOX { get; private set; }
	}
}

