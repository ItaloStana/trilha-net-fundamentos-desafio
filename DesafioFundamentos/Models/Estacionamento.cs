using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal PrecoInicial;
        private decimal PrecoPorHora;
        private List<string> Veiculos;

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.PrecoInicial = precoInicial;
            this.PrecoPorHora = precoPorHora;
            this.Veiculos = new List<string>();
        }

        public void CadastrarVeiculo(string placa)
        {
            Veiculos.Add(placa);
            Console.WriteLine("Veículo cadastrado com sucesso!");
        }

        public void RemoverVeiculo(string placa, int horas)
        {
            if (Veiculos.Contains(placa))
            {
                decimal valorTotal = PrecoInicial + (PrecoPorHora * horas);
                Veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está aqui.");
            }
        }

        public void ListarVeiculos()
        {
            if (Veiculos.Count > 0)
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string veiculo in Veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
