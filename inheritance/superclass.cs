using System;

public class Auto{

    private string engine;
    private bool engineStatus; 
    private float kW;
    private int seats;

    public Auto(){
        engine = "electric";
        engineStatus = false;
        kW = 75.5f;
        seats = 5;
    }

    public Auto(bool input){
        if(input == true){
            Console.Write("Enter engine type: ");
            //engine = Console.Read();
            Console.Write("Enter engine status: ");
            int status;
            status = Console.Read();
            if(status == 0){
                engineStatus = false;
            }
            else engineStatus = true;
            Console.Write("Enter power in kW: ");
            kW = Console.Read();
            Console.Write("Enter number of seats: ");
            seats = Console.Read();
        }
    }
    
    



    //public Auto(string engine, float kW, int seats){}

    public static void Main(){
    
    }

}
   
    
