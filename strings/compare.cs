using System;

public class Lenght {
    public static void Main() {
	    string str = "Hallo";
        string str1 = "HAFLO";
        //true -> ignores case, false -> casesensetive 
        int result = String.Compare(str, 2, str1, 2, 2, false);
        //result -1 -> Case not equal
        //result 0 -> equal
        //result 1 -> diffrent
        Console.WriteLine(result);
    }
}
