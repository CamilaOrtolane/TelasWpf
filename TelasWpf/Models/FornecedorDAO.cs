using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TelasWpf.interfaces;
using TelasWpf.Helpers;
using TelasWpf.Database;

namespace TelasWpf.Models
{
    internal class FornecedorDAO : IDAO<Fornecedor>

    {
        private static Conexao conn;
        
        public FornecedorDAO() 
        {
            conn = new Conexao();
        }  
        void IDAO<Fornecedor>.Delete(Fornecedor t)
        {
            throw new NotImplementedException();
        }

        Fornecedor IDAO<Fornecedor>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        private void Insert(Fornecedor t)
        {
            throw new NotImplementedException();
        }

        public List<Fornecedor> List()
        {
            try
            {
                List<Fornecedor> list = new List<Fornecedor>();

                var query = conn.Query();
                query.CommandText = "SELECT * FROM fornecedor";

                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Fornecedor()
                    {
                        Id = reader.GetInt32("cod_forn"),
                        RazaoSocial = DAOhelpers.GetString(reader, "razao_social_for"),
                        NomeFantasia = DAOhelpers.GetString(reader, "nome_fantasia_for"),
                        Cnpj = DAOhelpers.GetString(reader, "cnpj_for"),
                        Cidade = DAOhelpers.GetString(reader, "cidade_for"),
                        Estado = DAOhelpers.GetString(reader, "estado_fun")
                    });
                }

                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
        }


        void IDAO<Fornecedor>.Update(Fornecedor t)
        {
            throw new NotImplementedException();
        }
    }
}
