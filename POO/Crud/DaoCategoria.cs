using Crud.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    internal class DaoCategoria : ICrudGeneric<Categoria>
    {
        // private static List<Categoria> categorias = new List<Categoria>();
        public bool Salvar(Categoria categoria)
        {
            using (SqlConnection connection = new())
            {
                connection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Crud;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO tb_categorias([Descricao])VALUES(@Descricao)";

                cmd.Parameters.Add("Descricao", SqlDbType.VarChar).Value = categoria.Descricao;

                cmd.Connection = connection;
                return cmd.ExecuteNonQuery() > 0;

            }

        }

        public List<Categoria> GetItens()
        {
            using (SqlConnection connection = new())
            {
                connection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Crud;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM tb_categorias";

                cmd.Connection = connection;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                List<Categoria> categorias = new List<Categoria>();
                while (dr.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = Convert.ToInt32(dr["Id"]);
                    categoria.Descricao = Convert.ToString(dr["Descricao"]);

                    categorias.Add(categoria);
                }
                return categorias;
            }
        }

        public Categoria GetItemByID(int id)
        {
            using (SqlConnection connection = new())
            {
                connection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Crud;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT * FROM tb_categorias WHERE Id = '{id}'";

                cmd.Connection = connection;

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = Convert.ToInt32(dr["Id"]);
                    categoria.Descricao = Convert.ToString(dr["Descricao"]);

                    return categoria;
                }
                return null;
            }
        }

        public bool Update(Categoria categoria)
        {
            using (SqlConnection connection = new())
            {
                connection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Crud;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"UPDATE tb_categorias SET Descricao = @Descricao WHERE Id = @Id";
                cmd.Parameters.Add("Descricao", SqlDbType.VarChar).Value = categoria.Descricao;
                cmd.Parameters.Add("Id", SqlDbType.Int).Value = categoria.Id;

                cmd.Connection = connection;
                return cmd.ExecuteNonQuery() > 0;

            }

        }

        public bool Delete(Categoria categoria)
        {
            using (SqlConnection connection = new())
            {
                connection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Crud;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"DELETE FROM tb_categorias WHERE Id='{categoria.Id}'";
                cmd.Connection = connection;
                return cmd.ExecuteNonQuery() > 0;

            }
        }

    }
}
