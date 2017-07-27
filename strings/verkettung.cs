using System;

public class Concat {
    public static void Main() {
	string str = "Hallo";
	string str1 = " ";
	string str2 = "Test";
	//concatination with String Class
	string str3 = String.Concat(str, str1, str2);
	Console.WriteLine(str3);
	//alternative concat variant
	Console.WriteLine(str + str1 + str2);
    }
}
