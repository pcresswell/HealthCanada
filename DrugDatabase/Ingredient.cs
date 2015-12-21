using System;

namespace DrugDatabase
{
	public class Ingredient
	{
		public Ingredient (int drugCode, 
			int activeIngredientCode,
			string ingredient,
			string ingredientSuppliedInd,
			double strength,
			string strengthUnit,
			string strengthType,
			string dosageValue,
			string baseValue,
			string dosageUnit,
			string notes)
		{
			this.DRUG_CODE = drugCode;
			this.ACTIVE_INGREDIENT_CODE = activeIngredientCode;
			this.INGREDIENT = ingredient;
			this.INGREDIENT_SUPPLIED_IND = ingredientSuppliedInd;
			this.STRENGTH = strength;
			this.STRENGTH_UNIT = strengthUnit;
			this.STRENGTH_TYPE = strengthType;
			this.DOSAGE_VALUE = dosageValue;
			this.BASE = baseValue;
			this.DOSAGE_UNIT = dosageUnit;
			this.NOTES = notes;
		}

		public int DRUG_CODE { get; private set; }

		public int ACTIVE_INGREDIENT_CODE { get; private set; }

		public string INGREDIENT { get; private set; }

		public string INGREDIENT_SUPPLIED_IND { get; private set; }

		public double STRENGTH { get; private set; }

		public string STRENGTH_UNIT { get; private set; }

		public string STRENGTH_TYPE { get; private set; }

		public string DOSAGE_VALUE { get; private set; }

		public string BASE { get; private set; }

		public string DOSAGE_UNIT { get; private set; }

		public string NOTES{ get; private set; }

	}
}

