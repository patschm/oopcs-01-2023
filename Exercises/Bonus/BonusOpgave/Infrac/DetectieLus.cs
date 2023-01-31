using IEEE;

namespace Infrac;

public class DetectieLus
{
    private IDevice[] devices = new IDevice[10];

    public void Connect(IDevice device)
    {
        for(int i = 0; i < devices.Length; i++)
        {
            if (devices[i] == null)
            {
                devices[i] = device;
                return;
            }
        }
    }
    public void Detect()
    {
        Console.WriteLine("Hmmmm. Wasda?");
        foreach(IDevice device in devices) 
        { 
            device?.Activate();
        }
    }
}