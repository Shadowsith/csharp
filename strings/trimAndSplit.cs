using System;

public class Trim {
    public static void Main() {
	    string str = "   This is a Test   ";
	    str = str.Trim();
	    Console.WriteLine(str);
        char strSplit = ' ';
        string[] strArray = str.Split(strSplit);
        for (int i = 0; i < strArray.Length; i++) {
            Console.WriteLine(strArray[i]);
        }
	}
}
