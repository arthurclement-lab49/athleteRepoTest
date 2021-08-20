// Entry point name must be "Solution"
using System;
using System.Collections;
using System.Collections.Generic;


public static class Solution
{
    class Athlete {
        public int height;
        public string profession;
        public string name;
        

        public Athlete(string name, int height, string profession) {
            this.name = name;
            this.height = height;
            this.profession = profession;
        }
    }

    static List<Athlete> ATHLETES = new List<Athlete>() { 
        new Athlete("Bob", 190, "basketball"), 
        new Athlete("Alex", 170, "soccer"), 
        new Athlete("Frank", 130, "basketball"), 
        new Athlete("Shorty", 175, "basketball"), 
        new Athlete("Jane", 190, "chess")

    };
    
    private static void Main() {
        //Console.WriteLine(String.Join(", ", new AthleteRepo().printAll(ATHLETES)));
    }
    
    class AthleteRepo {
        public List < String > printAll(List<Athlete> all)
		{
			if (all == null)
			{
				throw new NullReferenceException();
			}
			else if (all.Count < 1)
			{
				return new List < String > ();
			}
			else
			{
				var allNames = new List < String > ();
				foreach(Athlete f in all)
				{
					if (rare(f))
					{
						allNames.Add(f.name);
					}
				}
				return allNames;
			}
		}
		// it is the norm for tall athletes to be basketball players
		public static bool rare(Athlete a)
		{
			if ((a.height >= 180 && a.profession.Equals("basketball")) || (a.height < 180 && !a.profession.Equals("basketball")))
			{
				return false;
			}
			else if (a.height >= 180 || a.profession.Equals("basketball"))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
    }
}

