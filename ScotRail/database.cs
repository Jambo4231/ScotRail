using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using ScotRail;
using MySql.Data.MySqlClient;


string connectionString = "Server=127.0.0.1;Database=scotrail;User Id=root;Password=root;";
using (MySqlConnection connection = new MySqlConnection(connectionString))
{
    connection.Open();
}

