using System;
public class University
{
    public static void Main() 
    {
    university[] UniChoices = {new university(), new university(), new university()};

    UniChoices[1].uniName = "UVU";
    UniChoices[2].uniName = "USU";

    for(var i=0; i<UniChoices.Length; i++) {
        UniChoices[i].years = 2000;
    }

    foreach(var item in UniChoices) 
        {
        Console.WriteLine(item.uniName);
        Console.WriteLine(item.years);
        }
    }
}

public class university {
    public string uniName = "UofU";
    public int years = 2000;
}