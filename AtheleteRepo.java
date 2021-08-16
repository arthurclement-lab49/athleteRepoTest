import java.io.*;
import java.util.*;

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

class Main {
  private final static class Athlete {
    public final int height;
    public final String profession;
    public final String name;
    
    public Athlete(String name, int height, String profession) {
      this.name = name;
      this.height = height;
      this.profession = profession;
    }
  }
  
  private final static List<Athlete> ATHLETES = Arrays.asList(
      new Athlete("Bob", 190, "basketball"),
      new Athlete("Alex", 170, "soccer"),
      new Athlete("Frank", 130, "basketball"),
      new Athlete("Shorty", 175, "basketball"),
      new Athlete("Jane", 190, "chess"));
  
  
  // NOTE: Do not change any code above this line
  
  public static void main(String[] args) {
    System.out.println(new AthleteRepo().printAll(ATHLETES));  // Frank, Shorty and Jane
  }
  public static class AthleteRepo {
    public ArrayList<String> printAll(List<Athlete> all) {
       if (all == null)
          throw new NullPointerException();
       else if (all.size() < 1)
          return new ArrayList<>();
       else {
         ArrayList<String> allNames = new ArrayList<>();
         for (Athlete f : all) {
            if (rare(f)) {
              allNames.add(f.name);
            }
         }
        return allNames;
      }
    }
      
      // it is the norm for tall athletes to be basketball players
    public static boolean rare(Athlete a) {
      if (a.height > 180 || a.profession != "basketball")
        return false;
      else
        return true;
    }
  }
}
