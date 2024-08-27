using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Models
{
    public class Parking
    {
        public decimal StartingPrice { get; set; }
        public decimal PricePerHour { get; set; }
        public List<string> Vehicles { get; set; }

        public Parking(decimal startingPrice, decimal pricePerHour)
        {
            StartingPrice = startingPrice;
            PricePerHour = pricePerHour;
            Vehicles = new List<string>();
        }

        /// <summary>
        /// Adds a vehicle to the parking.
        /// </summary>
        /// <param name="vehicle">The vehicle to add.</param>
        public void AddVehicle(string vehicle)
        {
            Vehicles.Add(vehicle);
            Console.WriteLine("Veículo adicionado com sucesso");
        }

        /// <summary>
        /// Removes a vehicle from the parking.
        /// </summary>
        /// <param name="vehicle">The vehicle to remove.</param>
        private bool RemoveVehicle(string vehicle)
        {
            if (!Vehicles.Contains(vehicle))
            {
                Console.WriteLine("Veículo não encontrado");
                return false;
            }

            Vehicles.Remove(vehicle);
            Console.WriteLine("Veículo removido com sucesso");
            return true;
        }

        /// <summary>
        /// Calculates the price based on the number of hours.
        /// </summary>
        /// <param name="numberOfHours">The number of hours the vehicle was parked.</param>
        private void CalculatePrice(int numberOfHours)
        {
            decimal price = StartingPrice + numberOfHours * PricePerHour;
            Console.WriteLine($"Preço a pagar: {price}");
        }

        /// <summary>
        /// Removes a vehicle from the parking and calculates the price based on the number of hours.
        /// </summary>
        /// <param name="vehicle">The vehicle to remove.</param>
        /// <param name="numberOfHours">The number of hours the vehicle was parked.</param>
        public void RemoveVehicle(string vehicle, int numberOfHours)
        {
            if (RemoveVehicle(vehicle))
            {
                CalculatePrice(numberOfHours);
            }
        }

        /// <summary>
        /// Lists all the vehicles in the parking.
        /// </summary>
        public void ListVehicles()
        {
            if (Vehicles.Count == 0)
            {
                Console.WriteLine("Nenhum veículo no estacionamento");
                return;
            }

            Console.WriteLine("Lista de veículos estacionados:");
            foreach (var vehicle in Vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }
    }
}
