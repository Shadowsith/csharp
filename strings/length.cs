using System;

public class Lenght {
    public static void Main() {
	string str = "Hallo";
	int length = str.Length;
	Console.WriteLine(length);
	for(int i = 0; i < length; i++){
	    Console.WriteLine(str[i]);
	}
    }
}
