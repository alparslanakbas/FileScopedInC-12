using System.Net.NetworkInformation;

file class Helper
{
    public static string HelloWord() => "Hello Word";
    public static string WindowsAPI()
    {
        string LoginName = Environment.UserName;
        Console.WriteLine($"Oturum açan kişi: {LoginName}");
        Console.WriteLine();
        Console.WriteLine("Mac Adresiniz:");
        foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
        {
            if (nic.NetworkInterfaceType != NetworkInterfaceType.Loopback && nic.OperationalStatus == OperationalStatus.Up)
            {
                string MacAddress = string
                .Join(":", nic.
                    GetPhysicalAddress().
                    GetAddressBytes().
                        Select(b => b.ToString("X2"))
                 );
                Console.WriteLine(MacAddress);
            }
        }
        return null;
    }
}

class Program
{
    public static void Main()
    {
        Console.WriteLine(Helper.HelloWord());
        Console.WriteLine(Helper.WindowsAPI());
    }
}

