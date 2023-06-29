using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Capitulo01;

public class ConnectionFactory
{
    public IDbConnection GetConnection()
    {
        IDbConnection conexao = new SqlConnection();
        conexao.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DesignPatterns;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        conexao.Open();

        return conexao;
    }
}
