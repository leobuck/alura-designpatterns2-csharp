using DesignPatterns2.Capitulo01;
using DesignPatterns2.Capitulo02;
using DesignPatterns2.Capitulo03;
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

Historico historico = new Historico();

Contrato contrato = new Contrato(DateTime.Now, "Leo", TipoContrato.Novo);
historico.Adiciona(contrato.SalvaEstado());

contrato.Avanca();
historico.Adiciona(contrato.SalvaEstado());

contrato.Avanca();
historico.Adiciona(contrato.SalvaEstado());

Console.WriteLine(historico.Pega(2).Contrato.Tipo);