using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Capitulo09;

public class ServicoSingleton
{
    private static Servico servico = new Servico();

    public Servico Instancia
    {
        get
        {
            return servico;
        }
    }
}
