namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            if (Suite != null && hospedes.Count <= Suite.Capacidade)//Se a Suite existir e a quantidade de hospedes for menor que a capacidade da Suite
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new ArgumentException("O número de hóspedes é maior que a capacidade da suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;//cadastra a suite.
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            return Hospedes?.Count ?? 0;//se Hospedes não for nulo, retorna a quantidade de hóspedes, senão retorna 0.
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados >= 10)
            {
                valor *= 0.9M;//desconto de 10%.
            }

            return valor;
        }
    }
}