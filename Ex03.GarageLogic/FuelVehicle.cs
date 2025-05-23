using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
	enum eTypeFuel
	{
		Soler,
		Octan95,
		Octan96,
		Octan98
	}
	internal abstract class FuelVehicle : Vehicle
	{
		private eTypeFuel m_TypeFuel { get; set; }
		private float m_CurrentAmountFuel { get; set; }
		private float m_MaxAmountFuel { get; set; }

		public FuelVehicle(string i_ModelName, string i_ModelId, float i_PercentageRemainingEnergy, List<Wheel> i_Wheels,eTypeFuel i_TypeFuel,  float i_CurrentAmountFuel, float i_MaxAmountFuel)
			: base(i_ModelName, i_ModelId, i_PercentageRemainingEnergy, i_Wheels)
		{
			this.m_TypeFuel = i_TypeFuel;
			this.m_CurrentAmountFuel = i_CurrentAmountFuel;
			this.m_MaxAmountFuel = i_MaxAmountFuel;
		}

		public bool TryRefuel(float i_amountFuelToAdd)
		{
			bool wasRefuel = i_amountFuelToAdd > 0;
			float fuelAfterAddition = m_CurrentAmountFuel + i_amountFuelToAdd;

			if (fuelAfterAddition <= m_MaxAmountFuel && wasRefuel == true)
			{
				this.m_CurrentAmountFuel = fuelAfterAddition;
			}
			else
			{
				wasRefuel = false;
			}

			return wasRefuel;
		}

	}
}
