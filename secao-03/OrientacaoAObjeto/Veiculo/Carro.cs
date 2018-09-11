namespace Veiculo
{
    // é possível ter várias classes dentro de um mesmo namespace, porém recomenda-se criar classes em arquivos separados
    class Carro
    {
        // modificadores de acesso: public, private, protected
        // por default, as propriedades e métodos da classe são private
        string Marca;
        string Modelo;
        string Cor;
        bool LuzesInternasLigadas = false;

        // criando uma propriedade estática pertencente a classe e não ao objeto (sem necessidade de new)
        public static int quantidadeDeCarrosProduzidos = 6;

        // métodos que retornam informações
        // métodos que não retornam informações (void)
        public void AbrirPorta() => LuzesInternasLigadas = true;

        public void FecharPorta() => LuzesInternasLigadas = false;

        public string AcenderFarolAutomaticamente() => "Médio";
    }
}
