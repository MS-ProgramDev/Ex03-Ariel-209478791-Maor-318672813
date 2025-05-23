using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
	//Need to decide what is the best place to put the Enum

	internal class FuelCar : FuelVehicle
	{
		private readonly int r_NumberOfDoors;
		private eCarColor m_CarColor;

		public FuelCar(
		string i_ModelName, string i_ModelId, float i_PercentageRemainingEnergy, List<Wheel> i_Wheels, eTypeFuel i_TypeFuel,
		float i_CurrentAmountFuel, float i_MaxAmountFuel, int i_NumberOfDoors, eCarColor i_CarColor)
		: base(i_ModelName, i_ModelId, i_PercentageRemainingEnergy, i_Wheels, eTypeFuel.Octan95, i_CurrentAmountFuel, 48f)
		{
			this.r_NumberOfDoors = i_NumberOfDoors;
			this.m_CarColor = i_CarColor;
		}

		public int NumberOfDoors
		{
			get { return r_NumberOfDoors; }
		}

		public eCarColor CarColor
		{
			get { return m_CarColor; }
			set { m_CarColor = value; }
		}





	}
}

 