using DesignPatterns2.Capitulo08;

namespace DesignPatterns2.Capitulo09;

public class ClienteDao
{
    public Cliente BuscarPorCpf(string cpf)
    {
        return new Cliente() { Cpf = cpf };
    }
}