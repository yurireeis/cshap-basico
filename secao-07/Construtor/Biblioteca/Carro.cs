namespace Construtor.Biblioteca
{
    public class Carro
    {
        public string Marca;
        public string Modelo;
        // método construtor da classe
        // construtorest também admitem sobrecarga
        public Carro()
        {
            // podemos utilizar o this para referenciar o objeto
            this.Marca = "Fiat";
            this.Modelo = "Palio";
        }

        // sobrecarga do construtor
        public Carro(string Marca, string Modelo)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
        }
    }
}
