using System;

namespace DrugDatabase
{
	public class Route
	{
		public Route (int drugCode, int routeOfAdministrationCode, string routeOfAdministration)
		{
			this.DRUG_CODE = drugCode;
			this.ROUTE_OF_ADMINISTRATION_CODE = routeOfAdministrationCode;
			this.ROUTE_OF_ADMINISTRATION = routeOfAdministration;
		}

		public int DRUG_CODE { get; private set; }

		public int ROUTE_OF_ADMINISTRATION_CODE { get; private set; }

		public string ROUTE_OF_ADMINISTRATION { get; private set; }
	}
}

