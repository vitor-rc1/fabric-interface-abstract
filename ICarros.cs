using System;

namespace Fabrica
{
    public interface ICarros
    {
        int Id { get; set; }
        string Nome { get; set; }
        string Modelo { get; set; }
        int Ano { get; set; }
    }
}
