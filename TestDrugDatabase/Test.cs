using NUnit.Framework;
using System;
using DrugDatabase.June2015;
using DrugDatabase;

namespace TestDrugDatabase
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void TestSampleDrugProductList ()
		{
			var drugProductList = new DrugProductList ();
			var drug = drugProductList.Find (x => x.DRUG_CODE == 47738);
			Assert.IsNotNull (drug);
			Assert.AreEqual (drug.DRUG_IDENTIFICATION_NUMBER, "2229682");
			Assert.AreEqual (new DateTime (2015,4,29), drug.LAST_UPDATE_DATE);
		}
	}
}

