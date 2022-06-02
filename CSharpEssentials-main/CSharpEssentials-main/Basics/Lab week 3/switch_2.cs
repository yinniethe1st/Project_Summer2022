using System;

public class Program
{
    public GameStates gameStates;

    public void Main()
    {
        gameStates = new GameStates();
        gameStates.currentState = GameStates.States.Playing;
        gameStates.CheckState();
    }
}

public class GameStates {
    public enum States {
        starting,
        Playing,
        Ending
    }

    public States currentState = States.starting;


   public void CheckState () {
       switch (currentState)
       {
           case States.starting: 
            Console.WriteLine("Starting");
            break;
            case States.Playing: 
            Console.WriteLine("Playing");
            break;
            case States.Ending: 
            Console.WriteLine("Ending");
            break;
       }


        
    }
}