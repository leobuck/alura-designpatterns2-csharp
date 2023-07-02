using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Capitulo06;

public class MensagemCliente : IMensagem
{
    private string nome;

    public MensagemCliente(string nome)
    {
        this.nome = nome;
    }

    public IEnviador Enviador { get; set; }

    public void Envia()
    {
        Enviador.Envia(this);
    }

    public string Formata()
    {
        return $"Enviando a mensagem para o cliente {nome}";
    }
}
