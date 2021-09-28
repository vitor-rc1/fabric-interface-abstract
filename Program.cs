using System;

namespace Fabrica
{
    class Program
    {
        public static readonly string SqlCNN = "Server=localhost;database=aula_xp;user=root;password=;SslMode=none";
        static void Main(string[] args)
        {
            CarroRepositorio repoGM= new CarroRepositorio(typeof(GM));
            CarroRepositorio repoFiat= new CarroRepositorio(typeof(Fiat));

            //repoCarro.Salvar(new GM()
            //{ 
            //    Nome = "Spin",
            //    Modelo = "X",
            //    Ano = 2010
            //});

            //repoCarro.Salvar(new Fiat()
            //{
            //    Nome = "Uno",
            //    Modelo = "Fire",
            //    Ano = 2010
            //});

            //repoCarro.Salvar(new Ford()
            //{
            //    Nome = "Fusion",
            //    Modelo = "Titanium",
            //    Ano = 2010
            //});

            foreach (var carro in repoGM.Todos())
            {
                Console.WriteLine($"Nome: {carro.Nome} - Modelo: {carro.Modelo} - Marca: {carro.GetType().Name} - Ano: {carro.Ano}");
            }

            foreach (var carro in repoFiat.Todos())
            {
                Console.WriteLine($"Nome: {carro.Nome} - Modelo: {carro.Modelo} - Marca: {carro.GetType().Name} - Ano: {carro.Ano}");
            }
        }
    }
}
