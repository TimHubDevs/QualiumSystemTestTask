using System;

public interface NavigatorService
{
    void closeAll();

    void addActionForClose(Action action);
}