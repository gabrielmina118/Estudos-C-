using System;
using System.Data;
using Dapper;
using DataAcess.Models;
using Microsoft.Data.SqlClient;
namespace DataAcess
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost,3306;Database=balta;User ID=root;Password=password";

            using (var connection = new SqlConnection(connectionString))
            {
                // CreateCategory(connection);
                // CreateManyCategory(connection);
                ExecuteProcedure(connection);
            }

        }


        static void CreateCategory(SqlConnection connection)
        {
            var category = new Category();
            category.id = 2;
            category.name = "Nova categoria";

            var insertSql = @"INSERT INTO [category] VALUES(@id , @name)";

            var rows = connection.Execute(insertSql, new
            {
                category.id,
                category.name
            });
        }

        static void CreateManyCategory(SqlConnection connection)
        {
            var category = new Category();
            category.id = 3;
            category.name = "Nova categoria 3";

            var category2 = new Category();
            category2.id = 4;
            category2.name = "Nova categoria 4";

            var insertSql = @"INSERT INTO [category] VALUES(@id , @name)";

            var rows = connection.Execute(insertSql, new[]{
                    new {
                        category.id,
                        category.name
                    },
                    new {
                        category2.id,
                        category2.name
                    }
                }
            );


        }

        // Executando uma procedure do banco de dados
        static void ExecuteProcedure(SqlConnection connection)
        {
            var procedure = "[deleteCategory]";

            var pars = new { id = 1 };

            connection.Execute(procedure, pars, commandType: CommandType.StoredProcedure);
        }

        static void ReadProcedure(SqlConnection connection)
        {
            var procedure = "[getCategories]";
            var listCategories = connection.Query(procedure, commandType: CommandType.StoredProcedure);

            foreach (var item in listCategories)
            {
                Console.WriteLine(item);
            }
        }

        // Execute scalar é quando você executa um insert e select na mesma função
        static void ExecuteScalar(SqlConnection connection)
        {
            var category = new Category();
            category.id = 26;
            category.name = "Nova categoria";

            var insertSql = @"
                    INSERT INTO [category] VALUES(@id , @name)
                    SELECT SCOPE_IDENTITY();
            ";

            var id = connection.ExecuteScalar<int>(insertSql, new
            {
                category.id,
                category.name
            });
            Console.WriteLine($"A categoria {id} inserida com sucesso!");
        }

    }

}