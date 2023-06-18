
using static_scope;


namespace keywords
{
	internal class SUV : Car
	{
		string specialTyre;
		string foldableSeats;
		int extandableLegSpace;

        public SUV(string engine, int numberOfTyres, int numberOfDoors, string gearType, string color, string specialTyre, string foldableSeats, int extandableLegSpace)
		{
			this.specialTyre = specialTyre;
			this.foldableSeats = foldableSeats;
			this.extandableLegSpace = extandableLegSpace;
		}

    }
	
	
	
	
}
