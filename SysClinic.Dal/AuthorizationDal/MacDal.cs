using SysClinic.DAL.Repositorio;
using SysClinic.Dto.AuthorizationDto;
using SysClinic.RESOURCE.Resources;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SysClinic.Dal.AuthorizationDal
{
    public class MacDal
    {
        public MacDto GetMac()
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT chave, empresa, cnpj " +
                                      "FROM analise";             

                SqlDataReader dr = Conexao.Buscar(comando);
                
                MacDto macDto = new MacDto();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        macDto.Chave = Convert.ToString(Convert.IsDBNull(dr["chave"]) ? null : dr["chave"]);
                        macDto.Empresa = Convert.ToString(Convert.IsDBNull(dr["empresa"]) ? null : dr["empresa"]);
                        macDto.Cnpj = Convert.ToString(Convert.IsDBNull(dr["cnpj"]) ? null : dr["cnpj"]);
                    }                                        
                }
                return macDto;
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataError + " - " + ex.Message);
            }
        }
        
        public void AlteraMac(MacDto macDto)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE analise SET chave = @Chave, empresa = @Empresa, cnpj = @Cnpj " +
                                      "WHERE idConfig = @IdConfig";

                comando.Parameters.AddWithValue("@Chave", macDto.Chave);
                comando.Parameters.AddWithValue("@Empresa", macDto.Empresa);
                comando.Parameters.AddWithValue("@Cnpj", macDto.Cnpj);
                comando.Parameters.AddWithValue("@IdConfig", 1);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.UpdateDataError + " - " + ex.Message);
            }
        }
    }
}
