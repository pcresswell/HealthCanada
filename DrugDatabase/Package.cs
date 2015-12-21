using System;

namespace DrugDatabase
{
	public class Package
	{
		public Package  (int drugCode, 
			string upc,
			string packageSizeUnit,
			string packageType,
			string packageSize, 
			string productInformation)
		{
			this.DRUG_CODE = drugCode;
			this.UPC = upc;
			this.PACKAGE_SIZE_UNIT = packageSizeUnit;
			this.PACKAGE_TYPE = packageType;
			this.PACKAGE_SIZE = packageSize;
			this.PRODUCT_INFORMATION = productInformation;
		}

		public int DRUG_CODE { get; private set; }

		public string UPC { get; private set; }

		public string PACKAGE_SIZE_UNIT { get; private set; }

		public string PACKAGE_TYPE { get; private set; }

		public string PACKAGE_SIZE { get; private set; }

		public string PRODUCT_INFORMATION { get ; private set; }
	
	}
}

