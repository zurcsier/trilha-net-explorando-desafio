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

            bool CapacidadePorHospedes;

            CapacidadePorHospedes = Suite.Capacidade >= hospedes.Count;

            if (CapacidadePorHospedes)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Número de hóspedes é maior que o comportado na suite!");

            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = (DiasReservados * Suite.ValorDiaria);

            if (DiasReservados >= 10)
            {
                valor = valor - (valor * 0.1M);
            }

            return valor;
        }
    }
}