using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
	internal class Wheel
	{
		private readonly string r_ManufacturerName;
		private readonly float r_MaxAirPressure;
		private float m_CurrentAirPressure;

		public Wheel(string i_ManufacturerName, float i_MaxAirPressure, float i_CurrentAirPressure) 
		{
			this.r_ManufacturerName = i_ManufacturerName;
			this.r_MaxAirPressure = i_MaxAirPressure;
			this.m_CurrentAirPressure = i_CurrentAirPressure;
		}
		
		public string ManufacturerName
		{
			get { return r_ManufacturerName; }
		}
		public float MaxAirPressure
		{
			get { return r_MaxAirPressure; }
		}
		public float CurrentAirPressure
		{
			get { return m_CurrentAirPressure; }
		}

		public bool TryAddAir(float i_amountAirToAdd)
		{
			bool wasAirAdded = i_amountAirToAdd > 0;
			float airAfterAddition = m_CurrentAirPressure + i_amountAirToAdd;

			if (airAfterAddition <= r_MaxAirPressure && wasAirAdded == true)
			{
				this.m_CurrentAirPressure = airAfterAddition;
			}
			else
			{
				wasAirAdded = false; 
			}
			
			return wasAirAdded;
		}

	}
	
}
