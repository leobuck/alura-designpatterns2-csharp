using DesignPatterns2.Capitulo08;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Capitulo09;

public class EmpresaFacade
{
    public Cliente BuscaCliente(string cpf)
    {
        return new ClienteDao().BuscarPorCpf(cpf);
    }

    public Fatura CriaFatura(Cliente cliente, double valor)
    {
        return new Fatura(cliente, valor);
    }

    public Cobranca GeraCobranca(TipoCobranca tipo, Fatura fatura)
    {
        Cobranca cobranca = new Cobranca(tipo, fatura);
        cobranca.Emite();
        return cobranca;
    }

    public ContatoCliente FazContato(Cliente cliente, Cobranca cobranca)
    {
        ContatoCliente contato = new ContatoCliente(cliente, cobranca);
        contato.Dispara();
        return contato;
    }
}
