using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
	internal class ElectricCar : ElectricVehicle
	{
		private readonly int r_NumberOfDoors;
		private eCarColor m_CarColor;

		public ElectricCar(
			string i_ModelName, string i_ModelId, float i_PercentageRemainingEnergy, List<Wheel> i_Wheels,
			float i_CurrentBatteryHours, float i_MaxBatteryHours,int i_NumberOfDoors, eCarColor i_CarColor)
			: base (i_ModelName, i_ModelId, i_PercentageRemainingEnergy, i_Wheels, i_CurrentBatteryHours, i_MaxBatteryHours)
		{ 
			this.r_NumberOfDoors = i_NumberOfDoors;
			this.m_CarColor = i_CarColor;
		}
		protected override List<Wheel> CreateWheels()
		{
			List<Wheel> wheels = new List<Wheel>();
			for (int i = 0; i < 4; i++)
			{
				wheels.Add(new Wheel("Default", 32, 32));
			}
			return wheels;
		}
		public eCarColor CarColor
		{
			get { return m_CarColor; }
			set { m_CarColor = value; }
		}
		public int NumberOfDoors
		{
			get { return r_NumberOfDoors; }
		}





	}
}
