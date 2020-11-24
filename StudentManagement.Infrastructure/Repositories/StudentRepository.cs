using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using StudentManagement.Application.Interfaces;
using StudentManagement.Core.Entities;

namespace StudentManagement.Infrastructure.Repositories
{
    public class StudentRepository:IStudentRepository
    {
        private readonly IConfiguration _configuration;
        public StudentRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<int> Add(Student entity)
        {
            entity.CreatedAt = DateTime.Now;
            var sqlQuery = "INSERT INTO Students(Name, Status, CreatedAt) Values (@Name, @Status, @CreatedAt);";

            using (var connection = new NpgsqlConnection(_configuration["ConnectionString"]))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sqlQuery, entity);
                return affectedRows;
            }
        }

        public async Task<int> Delete(int id)
        {
            var sqlQuery = "DELETE FROM Students WHERE Id = @Id;";
            using (var connection = new NpgsqlConnection(_configuration["ConnectionString"]))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sqlQuery, new { Id = id});
                return affectedRows;
            }
        }

        public async Task<Student> Get(int id)
        {
            var sqlQuery = "SELECT * FROM Students WHERE Id = @Id;";
            using (var connection = new NpgsqlConnection(_configuration["ConnectionString"]))
            {
                connection.Open();
                var result = await connection.QueryAsync<Student>(sqlQuery, new { Id = id });
                return result.FirstOrDefault();
            }
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            var sqlQuery = "SELECT * FROM Students;";
            using (var connection = new NpgsqlConnection(_configuration["ConnectionString"]))
            {
                connection.Open();
                var result = await connection.QueryAsync<Student>(sqlQuery);
                return result;
            }
        }

        public async Task<int> Update(Student entity)
        {
            entity.UpdatedAt = DateTime.Now;
            var sqlQuery = "UPDATE Students Set Name = @Name, Status = @Status, UpdatedAt = @UpdatedAt WHERE Id = @Id;";
            using (var connection = new NpgsqlConnection(_configuration["ConnectionString"]))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sqlQuery, entity);
                return result;
            }
        }
    }
}
