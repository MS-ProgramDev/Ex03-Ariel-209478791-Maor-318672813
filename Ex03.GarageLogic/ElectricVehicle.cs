using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
	internal abstract class ElectricVehicle : Vehicle
	{
		private float m_CurrentBatteryHours;
		private readonly float r_MaxBatteryHours;

		public ElectricVehicle(string i_ModelName, string i_ModelId, float i_PercentageRemainingEnergy , List<Wheel> i_Wheels, float i_CurrentBatteryHours, float i_MaxBatteryHours)
			: base(i_ModelName,i_ModelId, i_PercentageRemainingEnergy, i_Wheels)
		{
			this.m_CurrentBatteryHours = i_CurrentBatteryHours;
			this.r_MaxBatteryHours = i_MaxBatteryHours;
		}

		public float CurrentBatteryHours
		{
			get { return m_CurrentBatteryHours; }
		}
		public float MaxBatteryHours
		{
			get { return r_MaxBatteryHours; }
		}

		public bool TryChargeBattery(float i_hoursToAdd)
		{
			bool wasHoursAdded = i_hoursToAdd > 0;
			float batteryAfterAddition = m_CurrentBatteryHours + i_hoursToAdd;

			if (batteryAfterAddition <= r_MaxBatteryHours && wasHoursAdded == true)
			{
				this.m_CurrentBatteryHours = batteryAfterAddition;
			}
			else
			{
				wasHoursAdded = false;
			}

			return wasHoursAdded;
		}
	}
}
