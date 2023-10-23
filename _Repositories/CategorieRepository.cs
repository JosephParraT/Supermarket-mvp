using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._Repositories
{
    internal class CategorieRepository : BaseRepository, ICategorieRepository
    {
        public CategorieRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(CategorieModel categorieModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Categorie VALUES (@name, @observation)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categorieModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = categorieModel.Observation;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Categorie WHERE Categorie_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CategorieModel categorieModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Categorie
                                        SET Categorie_Name =@name,
                                        Categorie_Observation = @observation
                                        WHERE Categorie_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categorieModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = categorieModel.Observation;
                command.Parameters.Add("@id", SqlDbType.Int).Value = categorieModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CategorieModel> GetAll()
        {
            var categorieList = new List<CategorieModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Categorie ORDER BY Categorie_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categorieModel = new CategorieModel();
                        categorieModel.Id = (int)reader["Categorie_Id"];
                        categorieModel.Name = reader["Categorie_Name"].ToString();
                        categorieModel.Observation = reader["Categorie_Observation"].ToString();
                        categorieList.Add(categorieModel);
                    }
                }
            }
            return categorieList;
        }

        public IEnumerable<CategorieModel> GetByValue(string value)
        {
            var categorieList = new List<CategorieModel>();
            int categorieId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string categorieName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Categorie
                                        WHERE Categorie_Id=@id or Categorie_Name LIKE @name+ '%'
                                        ORDER By Categorie_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = categorieId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categorieName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categorieModel = new CategorieModel();
                        categorieModel.Id = (int)reader["Categorie_Id"];
                        categorieModel.Name = reader["Categorie_Name"].ToString();
                        categorieModel.Observation = reader["Categorie_Observation"].ToString();
                        categorieList.Add(categorieModel);
                    }
                }

            }
            return categorieList;

        }

    }
}
