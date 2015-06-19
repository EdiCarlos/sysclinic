using SysClinic.Bll.Common;
using SysClinic.Dal.AuthorizationDal;
using SysClinic.Dto.AuthorizationDto;
using System.Linq;
using System.Net.NetworkInformation;
using SysClinic.Resource.Validation;
using SysClinic.RESOURCE.Resources;

namespace SysClinic.Bll
{
    public class MacBll
    {
        MacDal macDal;
        MacDto macDto;

        public MacBll()
        {
            macDal = new MacDal();
            macDto = new MacDto();


        }
        public string PegarEnderecoMAc()
        {
            return (from nic in NetworkInterface.GetAllNetworkInterfaces()
                    where nic.OperationalStatus == OperationalStatus.Up
                    select nic.GetPhysicalAddress().ToString()
                           ).FirstOrDefault().Replace(":", "");
        }
        public MacDto GetMac()
        {
            return macDal.GetMac();
        }

        public void AlteraMac(MacDto macDto)
        {
            macDal.AlteraMac(macDto);
        }

        public bool VerificaMac()
        {
            CifraBll cf = new CifraBll();

            macDto = GetMac();

            if (macDto.Chave != cf.GetCriptografiaMD5(PegarEnderecoMAc())) return false;
            else return true;
        }

        public bool ValidaPassword(string password)
        {
            AssertionConcern.AssertArgumentNotEmpty(password, Errors.EmpytValue);

            if (password != "simoes") return false;
            if (password == "simoes") return true;
            else return false;           
        }



    }
}
