using System;
using System.Collections.Generic;
using System.IO;

public abstract class Goal
{
    private string name;
    private int value;
    private bool isComplete;

    public Goal(string name, int value)
    {
        SetName(name);
        SetValue(value);
        SetIsComplete(false);
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public int GetValue()
    {
        return value;
    }

    public void SetValue(int value)
    {
        this.value = value;
    }

    public bool GetIsComplete()
    {
        return isComplete;
    }

    public void SetIsComplete(bool isComplete)
    {
        this.isComplete = isComplete;
    }

    public abstract void MarkComplete();
}