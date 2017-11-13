namespace FileUpLoad.Domain.Entities
{
    public class Cliente : Entity
    {
        public string Nome { get; set; }
        public string UrlFoto { get; set; }
        public int Idade { get; set; }
        public Sexo Sexo { get; set; }
    }

    public enum Sexo
    {
        Masculino, Feminino
    }
}
