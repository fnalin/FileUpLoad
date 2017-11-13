using System;

namespace FileUpLoad.Domain.Entities
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public DateTime Cadastro { get; set; } = DateTime.Now;
    }
}
