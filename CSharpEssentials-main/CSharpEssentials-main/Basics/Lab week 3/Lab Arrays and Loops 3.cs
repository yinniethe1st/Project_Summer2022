using System;
public class Program
{
    public void Main() {
        string[] playerTypes = {"Pawn", "Pawn", "Pawn"};
        playerTypes[1] = "Queen";
        foreach(var playerType in playerTypes) {
            Console.WriteLine(playerType);
        }
       }       
}