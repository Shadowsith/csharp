using System;

public class Equals {
    public static void Main() {
	    string str = "Hallo";
	    string str2 = "Hallo";
	    string varstr = "Test";
	    if (str.Equals(str2)) {
	        Console.WriteLine("str equals str2");
	    }
	    else {
	        Console.WriteLine("Not Working");
	    }
	    if (!str.Equals(varstr)) {
	        Console.WriteLine("str doesn't equals varstr");
	    }
    }
}

