using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Capitulo06;

public class MensagemAdministrativa : IMensagem
{
    private string nome;

    public MensagemAdministrativa(string nome)
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
        return $"Enviando a mensagem para o administrador {nome}.";
    }
}
