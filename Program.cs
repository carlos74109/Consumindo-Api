
using ProjetoRefit.Models;
using Refit;
using System;
using System.Threading.Tasks;

namespace ProjetoRefit
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var cepClient = RestService.For<ICepApiService>("https://viacep.com.br");
                Console.WriteLine("Informe seu cep");

                string cep = Console.ReadLine().ToString();
                Console.WriteLine("Consultando cep Informado: " + cep);

                var endereco = await cepClient.GetAddresAsync(cep);

                Console.WriteLine("Logradou: " + endereco.Logradouro);
                Console.WriteLine("Bairro: " + endereco.Bairro);
                Console.WriteLine("Localidade: " + endereco.Localidade);
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
