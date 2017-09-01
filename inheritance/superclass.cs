using System;

public class Auto{

    private string engine;
    private bool engineStatus; 
    private float kW;
    private int seats;

    //Constructors
    public Auto(){
        engine = "electric";
        engineStatus = false;
        kW = 75.5f;
        seats = 5;
    }

    public Auto(string e, bool status, float kw, int s){
        setEngine(e);
        setEngineStatus(status);
        setKW(kw);
        setSeats(s);
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

    //Getters

    public string getEngine(){
        return engine;
    }

    public bool getEngineStatus(){
        return engineStatus;
    }

    public float getKW(){
        return kW;
    }

    public int getSeats(){
        return seats;
    }

    //Setters

    public void setEngine(string engineName){
        engine = engineName;
    }

    public void setEngineStatus(bool status){
        engineStatus = status;
    }

    public void setKW(float kw){
        kW = kw;
    }

    public void setSeats(int s){
        seats = s;
    }

    //Other Methods
    
    public void printAuto(){
        Console.WriteLine(getEngine());
        Console.WriteLine(getEngineStatus());
        Console.WriteLine(getKW());
        Console.WriteLine(getSeats());
    }

    //Main
    public static void Main(){
    
    }

}
   
    
