using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace MeowLL.Helpers
{
    public class NetworkHelper
    {
        
        public static string[] GetInterfaceAddresses()
        {
            List<string> res = new List<string>();
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.OperationalStatus == OperationalStatus.Up &&
                    !ni.GetIPProperties().GetIPv4Properties().Equals(null))
                {
                    foreach (UnicastIPAddressInformation uip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (uip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            res.Add(uip.Address.ToString());
                        }
                    }
                }
            }

            return res.ToArray();
        }
    }
}
