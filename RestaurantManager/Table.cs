using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManager
{
	public class Table
	{
		private int seatsOpen;

        public Table(int SeatsOpen)
        {
            seatsOpen = SeatsOpen;
        }


		public void keepRunningTotal(int seatsNeeded) => seatsOpen -= seatsNeeded; 

		public bool CanSeat(int seatsNeeded)
		{
			if (seatsNeeded <= seatsOpen)
			{
				keepRunningTotal(seatsNeeded);
				return true;
			}
			return false;
		}

	}
	

}
