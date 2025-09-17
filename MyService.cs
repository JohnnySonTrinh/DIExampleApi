using System;

public class MyService : IMyService
{
    private readonly int _serviceId;

    public MyService()
    {
        // Random 6-digit ID for this instance
        this._serviceId = new Random().Next(100000, 999999);
    }

    public void LogCreation(string message)
    {
        Console.WriteLine($"[{_serviceId}] {message}");
    }
}
