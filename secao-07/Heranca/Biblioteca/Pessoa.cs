namespace Heranca.Biblioteca
{
    public class Pessoa
    {
        public int Andar() => 1;

        // método sobrecarregado
        public int Andar(int velocidade) => velocidade;

        public int Correr() => Andar() * 2;

        public int Pedalar(int lvl) => Andar() * lvl;
    }
}
