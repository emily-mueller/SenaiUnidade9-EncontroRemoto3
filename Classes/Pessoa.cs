using EncontroRemoto3.Interfaces;

namespace EncontroRemoto3.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? Nome { get; set; }
        
        public float Rendimento { get; set; }

        public Endereco? Endereco { get; set; }

        public abstract float PagarImposto(float rendimento);
        
    }
}