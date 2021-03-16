using System;
using System.Collections.Generic;

public class NavigatorServiceImpl : NavigatorService
{
    private List<Action> needToClose = new List<Action>();

    public void closeAll()
    {
        foreach (var action in needToClose)
        {
            action.Invoke();
        }

        needToClose.Clear();
    }

    public void addActionForClose(Action action)
    {
        needToClose.Add(action);
    }
}