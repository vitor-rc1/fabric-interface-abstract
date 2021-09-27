using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    class CarroRepositorio
    {
        public CarroRepositorio(Type type)
        {
            this.type = type;
        }

        private Type type;

        public void Salvar(ICarro carro)
        {
            using (MySqlConnection connection = new MySqlConnection(Program.SqlCNN))
            {
                connection.Open();
                if (carro.Id == 0)
                {
                    var sql = "INSERT INTO aula_xp.carros(nome, modelo, marca, ano) VALUES (@nome, @modelo, @marca, @ano);";

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@nome", carro.Nome);
                        command.Parameters.AddWithValue("@modelo", carro.Modelo);
                        command.Parameters.AddWithValue("@marca", carro.GetType().Name);
                        command.Parameters.AddWithValue("@ano", carro.Ano);

                        carro.Id = Convert.ToInt32(command.ExecuteScalar());
                    }
                }


                connection.Close();
            }
        }
    }
}
