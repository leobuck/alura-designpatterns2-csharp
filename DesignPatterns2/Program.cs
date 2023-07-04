using DesignPatterns2.Capitulo01;
using DesignPatterns2.Capitulo02;
using DesignPatterns2.Capitulo03;
using DesignPatterns2.Capitulo04;
using DesignPatterns2.Capitulo05;
using DesignPatterns2.Capitulo06;
using DesignPatterns2.Capitulo07;
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

IExpressao raizQuadrada = new RaizQuadrada(new Numero(9));
Console.WriteLine(raizQuadrada.Avalia());

ImpressoraVisitor impressora = new ImpressoraVisitor();
soma.Aceita(impressora);

Console.WriteLine();
soma2.Aceita(impressora);

Console.WriteLine();
raizQuadrada.Aceita(impressora);

ImpressoraPreFixoVisitor preFixo = new ImpressoraPreFixoVisitor();
Console.WriteLine();
soma.Aceita(preFixo);

Console.WriteLine();
soma2.Aceita(preFixo);

Console.WriteLine();
raizQuadrada.Aceita(preFixo);

Console.WriteLine();

IMensagem mensagem = new MensagemCliente("Leo");
IEnviador enviador = new EnviaPorSms();
mensagem.Enviador = enviador;
mensagem.Envia();

FilaDeTrabalho fila = new FilaDeTrabalho();

Pedido pedido1 = new Pedido("Leo", 100.0);
Pedido pedido2 = new Pedido("Ana", 200.0);

fila.Adiciona(new PagaPedido(pedido1));
fila.Adiciona(new PagaPedido(pedido2));

fila.Adiciona(new FinalizaPedido(pedido1));

fila.Processa();
