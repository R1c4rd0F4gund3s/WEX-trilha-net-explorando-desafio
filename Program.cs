using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
var hospedes = new List<Pessoa>
{
    new Pessoa(nome: "Hóspede 1"),
    new Pessoa(nome: "Hóspede 2")
};

// Cria a suíte
var suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 50);

// Cria uma nova reserva, passando a suíte e os hóspedes
var reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor total: {reserva.CalcularValorDiaria():C}");