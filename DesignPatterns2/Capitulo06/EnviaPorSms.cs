using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Capitulo06;

public class EnviaPorSms : IEnviador
{
    public void Envia(IMensagem mensagem)
    {
        Console.WriteLine("Enviando a mensagem por SMS...");
        Console.WriteLine(mensagem.Formata());
    }
}
