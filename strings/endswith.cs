using System;

public class EndsWith {
    public static void Main() {
	string str = "weapon_rpg";
	string str1 = "rpg";
	if (str.EndsWith(str1)) {
	    Console.WriteLine(str + " ends with " + str1);
	}
    }
}
