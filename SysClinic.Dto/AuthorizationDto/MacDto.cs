using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysClinic.Dto.AuthorizationDto
{
    public class MacDto
    {
        public int IdConfig { get; set; }

        public string Chave { get; set; }

        public string Empresa { get; set; }

        public string Cnpj { get; set; }
    }
}
