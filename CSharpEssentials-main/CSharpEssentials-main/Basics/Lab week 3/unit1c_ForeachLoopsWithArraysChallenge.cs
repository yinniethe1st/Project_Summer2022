using System;

namespace MyChallenge
{
  class DogsType
  {
    static void Main(string[] args)
    {
      string[] Dogs = {"Golden Doodle", "Samoyed", "Golden Retriever", "Labrador Retriever"};
      foreach (string i in Dogs) 
      {
        Console.WriteLine(i);
      }   
    }
  }
}