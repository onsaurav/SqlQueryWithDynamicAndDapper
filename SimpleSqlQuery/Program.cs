using Dapper;
using Microsoft.Data.SqlClient;

Console.WriteLine("Simple query with Dynamic C#!");


string connectionString = "Server=.;Database=MovieClub;User Id=kcbdbuser;Password=kcbdbuser;TrustServerCertificate=True;";

using var con = new SqlConnection(connectionString);

IEnumerable<dynamic> movies = con.Query("SELECT * FROM Movie");
foreach (dynamic item in movies)
{
    Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Genre: {item.Genre}, Rating: {item.Rating}, Language: {item.Language}");
}
