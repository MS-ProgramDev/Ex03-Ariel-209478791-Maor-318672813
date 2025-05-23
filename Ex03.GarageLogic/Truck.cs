using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
	internal class Truck : FuelCar
	{
		private readonly float r_CargoVolume;
		private bool m_CarryHazardousMterials;

		public Truck(string i_ModelName, string i_ModelId, float i_PercentageRemainingEnergy, List<Wheel> i_Wheels, eTypeFuel i_TypeFuel,
					float i_CurrentAmountFuel, float i_MaxAmountFuel, int i_NumberOfDoors, eCarColor i_CarColor, float i_CargoVolume, bool i_CarryHazardousMterials)
					: base(i_ModelName, i_ModelId, i_PercentageRemainingEnergy, i_Wheels, i_TypeFuel, i_CurrentAmountFuel, i_MaxAmountFuel, i_NumberOfDoors, i_CarColor)
		{
			this.r_CargoVolume = i_CargoVolume;
			this.m_CarryHazardousMterials = i_CarryHazardousMterials;
		}

		public float CargoVolume
		{
			get { return r_CargoVolume; }
		}

		public bool CarryHazardousMterials
		{
			get { return m_CarryHazardousMterials; }
			set { m_CarryHazardousMterials = value; }
		}
	}
}
