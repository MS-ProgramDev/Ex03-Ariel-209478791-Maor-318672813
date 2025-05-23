using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
	enum eCarColor
	{
		Yellow,
		Black,
		White,
		Silver
	}
	enum eLicenseType
	{
		A,
		A2,
		AB,
		B2
	}
	internal abstract class Vehicle
	{
		private readonly string r_ModelName;
		private readonly string r_ModelId;
		private float m_PercentageRemainingEnergy;
		protected List<Wheel> m_Wheel = new List<Wheel>();


		public Vehicle(string i_ModelName, string i_ModelId, float i_PrecentageRemainingEnergy)
		{
			this.r_ModelName = i_ModelName;
			this.r_ModelId = i_ModelId;
			this.m_PercentageRemainingEnergy = i_PrecentageRemainingEnergy;
		}
		protected abstract List<Wheel> CreateWheels();
		public string ModelName
		{
			get { return r_ModelName; }
		}
		public string ModelId
		{
			get { return r_ModelId; }
		}
		public float PercentageRemainingEnergy
		{
			get { return m_PercentageRemainingEnergy; }
			protected set { m_PercentageRemainingEnergy = value; }
		}
		public List<Wheel> Wheels
		{
			get { return r_Wheels; }
		}
	}
}
