using System.Linq;
using System.Net.NetworkInformation;

namespace SysClinic.Bll
{
    public class MacBll
    {
        public string PegarEnderecoMAc()
        {
            return (from nic in NetworkInterface.GetAllNetworkInterfaces()
                    where nic.OperationalStatus == OperationalStatus.Up
                    select nic.GetPhysicalAddress().ToString()
                           ).FirstOrDefault().Replace(":","");
        }
    }
}
