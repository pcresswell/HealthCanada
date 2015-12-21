using System;

namespace DrugDatabase
{
	public class DrugProduct
	{
		public DrugProduct (int drugCode,
		                    string productCategorization,
		                    string classValue,
		                    string drugIdentificationNumber,
		                    string brandName,
		                    string descriptor,
		                    string pediatricFlag,
		                    string accessionNumber,
		                    string numberOfAIS,
		                    DateTime lastUpdateDate,
		                    string aiGroupNo)
		{
			this.DRUG_CODE = drugCode;
			this.PRODUCT_CATEGORIZATION = productCategorization;
			this.CLASS = classValue;
			this.DRUG_IDENTIFICATION_NUMBER = drugIdentificationNumber;
			this.BRAND_NAME = brandName;
			this.DESCRIPTOR = descriptor;
			this.PEDIATRIC_FLAG = pediatricFlag;
			this.ACCESSION_NUMBER = accessionNumber;
			this.NUMBER_OF_AIS = numberOfAIS;
			this.LAST_UPDATE_DATE = lastUpdateDate;
			this.AI_GROUP_NO = aiGroupNo;
		}

		public int DRUG_CODE { get; private set; }

		public string PRODUCT_CATEGORIZATION { get; private set; }

		public string CLASS { get; private set; }

		public string DRUG_IDENTIFICATION_NUMBER { get; private set; }

		public string BRAND_NAME { get; private set; }

		public string DESCRIPTOR { get; private set; }

		public string PEDIATRIC_FLAG { get; private set; }

		public string ACCESSION_NUMBER { get; private set; }

		public string NUMBER_OF_AIS { get; private set; }

		public DateTime LAST_UPDATE_DATE { get; private set; }

		public string AI_GROUP_NO { get; private set; }
	}
}

