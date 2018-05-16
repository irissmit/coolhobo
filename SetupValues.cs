using System;
using System.Collections.Generic;

public class OneObject
{
    public static int GetNumberOfValues()
    {
        return 1000;
    }

    private int value;

    public OneObject(int value)
    {
        this.value = value;
    }

    public void ShowValue()
    {
        Console.WriteLine(value);
    }
}

public class SetupValues
{
    private List<OneObject> allObjects = new List<OneObject>(OneObject.GetNumberOfValues()); // allocate memory

    public SetupValues()
    {
        Random randomNumber = new Random();
        for (int i = 0; i < OneObject.GetNumberOfValues(); i++)
        {
            allObjects.Add(new OneObject(randomNumber.Next()));
        }
    }

    public void ReadValues()
    {
        foreach (OneObject obj in allObjects)
        {
            obj.ShowValue();
        }
    }
}