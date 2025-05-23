using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
	internal class ElectricMotorcycle : ElectricVehicle
	{
		private eLicenseType m_LicenseType;
		private readonly int r_EngineVolume;


		public ElectricMotorcycle(string i_ModelName, string i_ModelId, float i_PercentageRemainingEnergy, List<Wheel> i_Wheels,
			float i_CurrentBatteryHours, float i_MaxBatteryHours, eLicenseType i_licenseType, int i_EngineVolume)
			: base (i_ModelName,i_ModelId, i_PercentageRemainingEnergy, i_Wheels, i_CurrentBatteryHours, i_MaxBatteryHours)
		{
			this.m_LicenseType = i_licenseType;
			this.r_EngineVolume = i_EngineVolume;
		}

		public eLicenseType LicenseType
		{ 
			get { return m_LicenseType; }
			set { m_LicenseType = value; }
		}
		public int EngineVolume
		{
			get { return r_EngineVolume; }
		}

	}
}
