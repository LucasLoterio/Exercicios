﻿using Crud.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    internal class DaoProduto : ICrudGeneric<Produto>
    {
        public bool Salvar(Produto produto)
        {
            using (SqlConnection connection = new())
            {
                connection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Crud;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO tb_produtos([Nome],[ValorUnit],[Estoque],[CategoriaID])VALUES(@Nome, @ValorUnit, @Estoque, @CategoriaID)";

                cmd.Parameters.Add("Nome", SqlDbType.VarChar).Value = produto.Nome;
                cmd.Parameters.Add("ValorUnit", SqlDbType.Decimal).Value = produto.ValorUnit;
                cmd.Parameters.Add("Estoque", SqlDbType.Int).Value = produto.Estoque;
                cmd.Parameters.Add("CategoriaID", SqlDbType.Int).Value = produto.Categoria.Id;

                cmd.Connection = connection;
                return cmd.ExecuteNonQuery() > 0;

            }

        }

        public List<Produto> GetItens()
        {
            using (SqlConnection connection = new())
            {
                connection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Crud;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM tb_produtos";

                cmd.Connection = connection;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                List<Produto> produtos = new List<Produto>();
                while (dr.Read())
                {
                    Produto produto = new Produto();
                    produto.Id = Convert.ToInt32(dr["Id"]);
                    produto.Nome = Convert.ToString(dr["Nome"]);
                    produto.ValorUnit = Convert.ToDouble(dr["ValorUnit"]);
                    produto.Estoque = Convert.ToInt32(dr["Estoque"]);
                    var catID = Convert.ToInt32(dr["CategoriaID"]);
                    produto.Categoria = new DaoCategoria().GetItemByID(catID);

                    produtos.Add(produto);
                }
                return produtos;
            }
        }
        public Produto GetItemByID(int id)
        {
            using (SqlConnection connection = new())
            {
                connection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Crud;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT * FROM tb_produtos WHERE ID = {id}";

                cmd.Connection = connection;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Produto produto = new Produto();
                    produto.Id = Convert.ToInt32(dr["Id"]);
                    produto.Nome = Convert.ToString(dr["Nome"]);
                    produto.ValorUnit = Convert.ToDouble(dr["ValorUnit"]);
                    produto.Estoque = Convert.ToInt32(dr["Estoque"]);
                    var catID = Convert.ToInt32(dr["CategoriaID"]);
                    produto.Categoria = new DaoCategoria().GetItemByID(catID);

                    return produto;
                }
                return null;
            }
        }

            public List<Produto> GetItemByCategoria(int id)
            {
                using (SqlConnection connection = new())
                {
                    connection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Crud;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"SELECT * FROM tb_produtos WHERE CategoriaID = {id}";

                    cmd.Connection = connection;

                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    List<Produto> produtos = new List<Produto>();
                    while (dr.Read())
                    {
                        Produto produto = new Produto();
                        produto.Id = Convert.ToInt32(dr["Id"]);
                        produto.Nome = Convert.ToString(dr["Nome"]);
                        produto.ValorUnit = Convert.ToDouble(dr["ValorUnit"]);
                        produto.Estoque = Convert.ToInt32(dr["Estoque"]);
                        var catID = Convert.ToInt32(dr["CategoriaID"]);
                        produto.Categoria = new DaoCategoria().GetItemByID(catID);

                        produtos.Add(produto);
                    }
                    return produtos;
                }
            }

        public bool Update(Produto produto)
        {
            using (SqlConnection connection = new())
            {
                connection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Crud;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"UPDATE tb_produtos SET Nome = @Nome , ValorUnit = @ValorUnit, Estoque = @Estoque, CategoriaID = @CategoriaID WHERE ID = @ID";

                cmd.Parameters.Add("Nome", SqlDbType.VarChar).Value = produto.Nome;
                cmd.Parameters.Add("ValorUnit", SqlDbType.Decimal).Value = produto.ValorUnit;
                cmd.Parameters.Add("Estoque", SqlDbType.Int).Value = produto.Estoque;
                cmd.Parameters.Add("CategoriaID", SqlDbType.Int).Value = produto.Categoria.Id;
                cmd.Parameters.Add("ID", SqlDbType.Int).Value = produto.Id;


                cmd.Connection = connection;
                return cmd.ExecuteNonQuery() > 0;

            }

        }

        public bool Delete(Produto produto)
        {
            using (SqlConnection connection = new())
            {
                connection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Crud;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"DELETE FROM tb_produtos WHERE Id='{produto.Id}'";
                cmd.Connection = connection;
                return cmd.ExecuteNonQuery() > 0;

            }
        }
    }
}
