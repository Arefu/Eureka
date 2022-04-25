using Microsoft.Win32;

namespace Eureka
{
    public partial class Program
    {
        static void Main()
        {
            var PreKey = "";
            var Registry = (!Environment.Is64BitOperatingSystem) ? RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32) : RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            var ProductID = Registry.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion").GetValue("ProductId").ToString();
            for (int x = 0; x < ProductID.Length; x++)
            {
                if (char.IsNumber(ProductID[x]))
                    PreKey += ProductID[x];
            }

            for (int x = 0; x < PreKey.Length; x++)
            {
                if (PreKey.Substring(x, 1) != "0")
                {
                    PreKey = PreKey.Substring(x, PreKey.Length - x);
                    break;
                }
            }

            PreKey = PreKey.Substring(0, 6); //

            var Product = GetProduct();
            var Key = ((Convert.ToInt32(PreKey) + Convert.ToInt32(Product)) * 2 + Convert.ToInt32(Product)).ToString().PadLeft(10, '0');
            Console.WriteLine($"Key: {Key}");
        }
    }
}