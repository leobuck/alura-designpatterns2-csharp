using DesignPatterns2.Capitulo05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Capitulo04;

public interface IExpressao
{
    int Avalia();
    void Aceita(IVisitor impressora);
}
