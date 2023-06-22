﻿using System;
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
    internal class MovelDAO : IDAO<Movel>
    {
        private static Conexao conn;

        public MovelDAO()
        {
            conn = new Conexao();
        }
        void IDAO<Movel>.Delete(Movel t)
        {
            throw new NotImplementedException();
        }

        Movel IDAO<Movel>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Movel t)
        {
            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO Funcionario (nome_mov, materia_mov, descricao_mov, comprimento_mov, cor_mov, altura_mov, valor_custo_mov, valor_venda_mov) VALUES (@nome_mov, @materia_mov, @descricao_mov, @comprimento_mov, @cor_mov, @altura_mov, @valor_custo_mov, @valor_venda_mov)";
                query.Parameters.AddWithValue("@nome_mov", t.Nome);
                query.Parameters.AddWithValue("@materia_mov", t.Material);
                query.Parameters.AddWithValue("@descricao_mov", t.Descricao);
                query.Parameters.AddWithValue("@comprimento_mov", t.Peso);
                query.Parameters.AddWithValue("@cor_mov", t.Cor);
                query.Parameters.AddWithValue("@altura_mov", t.Altura);
                query.Parameters.AddWithValue("@largura_mov", t.Largura);
                query.Parameters.AddWithValue("@valor_custo_mov", t.ValorCusto);
                query.Parameters.AddWithValue("@valor_venda_mov", t.ValorTotal);

                var result = query.ExecuteNonQuery();

                if (result == 0)
                    throw new Exception("O registo não foi inserido. Verifique e tente novamente");


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

        public List<Movel> List()
        {
            throw new NotSupportedException();
        }


        void IDAO<Movel>.Update(Movel t)
        {
            throw new NotImplementedException();
        }

        void IDAO<Movel>.Insert(Movel t)
        {
            throw new NotImplementedException();
        }
    }
}
