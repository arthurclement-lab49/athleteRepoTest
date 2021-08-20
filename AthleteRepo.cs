// Entry point name must be "Solution"
using System;
using System.Collections;
using System.Collections.Generic;

/*
 We have a repository of athletes.
 An athlete has a name, height in centimeters, and a profession.

 Typically, there is a clear correlation between being tall and
 playing basketball: If an Athlete is tall (i.e.: height >= 180)
 then s/he is a basketball player, and if s/he is not tall then
 s/he is not a basketball player. 
 
 In the code below:
 Bob is tall and plays basketball, and Alex is short and plays
 soccer, so they are typical. 
 Frank, shorty and Jane are rare.
 
 We want to print the names of all the rare athletes.
 
 Unfortunately we have a bug. Please fix it. 
 Use the opportunity to improve the code quality, until you feel comfortable putting your name behind it.
 
 *Do not change the behavior of the function "printAll". For example: When it gets a null value as input, it is expected to throw an NPE.
*/
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
    
    // NOTE: No need to change any code above this line
    private static void Main() {
        Console.WriteLine(String.Join(", ", new AthleteRepo().printAll(ATHLETES)));
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

