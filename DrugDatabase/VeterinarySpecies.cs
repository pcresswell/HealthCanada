using System;

namespace DrugDatabase
{
	public class VeterinarySpecies
	{
		public VeterinarySpecies (int drugCode, string vetSpecies, string vetSubSpecies)
		{
			this.DRUG_CODE = drugCode;
			this.VET_SPECIES = vetSpecies;
			this.VET_SUB_SPECIES = vetSubSpecies;
		}

		public int DRUG_CODE { get; private set; }

		public string VET_SPECIES { get; private set; }

		public string VET_SUB_SPECIES { get; private set; }
	}
}