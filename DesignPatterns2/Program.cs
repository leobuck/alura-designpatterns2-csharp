using DesignPatterns2.Capitulo01;
using System.Data;

IDbConnection conexao = new ConnectionFactory().GetConnection();
IDbCommand comando =  conexao.CreateCommand();
comando.CommandText = "SELECT * FROM tabela";