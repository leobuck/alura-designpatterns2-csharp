using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Capitulo02;

public class Piano
{
    public void Toca(IList<INota> musica)
    {
        foreach (var nota in musica)
        {
            Console.Beep(nota.Frequencia, 300);
        }
    }
}
