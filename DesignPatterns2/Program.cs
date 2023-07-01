using DesignPatterns2.Capitulo01;
using DesignPatterns2.Capitulo02;
using DesignPatterns2.Capitulo03;
using DesignPatterns2.Capitulo04;
using System.Data;
using System.Linq.Expressions;

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

IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
IExpressao soma = new Soma(esquerda, direita);

Console.WriteLine(soma.Avalia());

Expression somaExp = Expression.Add(Expression.Constant(10), Expression.Constant(100));
Func<int> funcao = Expression.Lambda<Func<int>>(somaExp).Compile();
Console.WriteLine(funcao());

IExpressao esquerda2 = new Multiplicacao(new Numero(2), new Numero(5));
IExpressao direita2 = new Divisao(new Numero(10), new Numero(5));
IExpressao soma2 = new Soma(esquerda2, direita2);

Console.WriteLine(soma2.Avalia());
