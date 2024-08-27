using ParkingSystem.Models;

Console.WriteLine("Sistema de Estacionamento");

Console.WriteLine("Digite o preço inicial:");
decimal startingPrice = decimal.Parse(Console.ReadLine());

Console.WriteLine("Digite o preço por hora:");
decimal pricePerHour = decimal.Parse(Console.ReadLine());

Parking parking = new Parking(startingPrice, pricePerHour);

int input = 0;

while (input != 4)
{
    Console.WriteLine(
        "\nO que você gostaria de fazer?\n" +
        "1 - Cadastrar veículo\n" +
        "2 - Remover veículo\n" +
        "3 - Listar veículos\n" +
        "4 - Encerrar"
    );

    if (!int.TryParse(Console.ReadLine(), out input))
    {
        Console.WriteLine("Opção inválida");
        continue;
    }
   
    switch (input)
    {
        case 1:
            Console.WriteLine("Digite a placa do veículo:");
            string plate = Console.ReadLine();

            parking.AddVehicle(plate);
            break;

        case 2:
            Console.WriteLine("Digite a placa do veículo:");
            string plateToRemove = Console.ReadLine();

            Console.WriteLine("Digite o número de horas que o veículo ficou estacionado:");
            int numberOfHours = int.Parse(Console.ReadLine());

            parking.RemoveVehicle(plateToRemove, numberOfHours);
            break;

        case 3:
            parking.ListVehicles();
            break;

        case 4:
            Console.WriteLine("Encerrando o sistema");
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}