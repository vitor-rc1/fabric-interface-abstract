using System;

namespace Fabrica
{
    class Program
    {
        public static readonly string SqlCNN = "Server=localhost;database=aula_xp;user=root;password=;SslMode=none";
        static void Main(string[] args)
        {
            CarroRepositorio repoCarro = new CarroRepositorio(typeof(GM));

            repoCarro.Salvar(new GM()
            { 
                Nome = "Spin",
                Modelo = "X",
                Ano = 2010
            });
        }
    }
}
