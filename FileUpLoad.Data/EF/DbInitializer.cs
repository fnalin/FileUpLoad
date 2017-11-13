using FileUpLoad.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FileUpLoad.Data.EF
{
    public class DbInitializer
    {
        public static void Initialize(CadClienteDataContext context)
        {

            context.Database.EnsureCreated();

            if (!context.Clientes.Any())
            {
                context.Clientes.AddRange(

                    new List<Cliente>() {

                    new Cliente() { Nome = "Fabiano Nalin", Idade = 38, Sexo = Sexo.Masculino },
                    new Cliente() { Nome = "Priscila Mitui", Idade = 39, Sexo = Sexo.Feminino },
                    new Cliente() { Nome = "Raphael Nalin", Idade = 18, Sexo = Sexo.Masculino },
                    new Cliente() { Nome = "Raimundo Nonato", Idade = 78, Sexo = Sexo.Masculino },
                    new Cliente() { Nome = "José da Silva", Idade = 58, Sexo = Sexo.Masculino },
                    new Cliente() { Nome = "Paula dos Santos", Idade = 28, Sexo = Sexo.Feminino},
                    new Cliente() { Nome = "Daniel Augusto", Idade = 40, Sexo = Sexo.Masculino },
                    new Cliente() { Nome = "Carlos Adriano", Idade = 35, Sexo = Sexo.Masculino },
                    new Cliente() { Nome = "Fernanda Franco", Idade = 29, Sexo = Sexo.Feminino},
                    new Cliente() { Nome = "Isabel Aparecida", Idade = 58, Sexo = Sexo.Feminino},
                    }

                    );

                context.SaveChanges();
            }
        }
    }
}
