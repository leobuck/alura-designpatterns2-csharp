using DesignPatterns2.Capitulo01;
using DesignPatterns2.Capitulo02;
using System.Data;

IDbConnection conexao = new ConnectionFactory().GetConnection();
IDbCommand comando =  conexao.CreateCommand();
comando.CommandText = "SELECT * FROM tabela";

NotasMusicais notas = new NotasMusicais();

IList<INota> musica = new List<INota>()
{
    notas.Pega("do"),
    notas.Pega("re"),
    notas.Pega("mi"),
    notas.Pega("fa"),
    notas.Pega("fa"),
    notas.Pega("fa"),
};

Piano piano = new Piano();
piano.Toca(musica);