using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Capitulo09;

public class EmpresaFacadeSingleton
{
    private static EmpresaFacade Facade = new EmpresaFacade();

    public EmpresaFacade Instancia
    {
        get { return Facade; }
    }
}
