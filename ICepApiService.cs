using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace ProjetoRefit.Models
{
    internal interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<Endereco> GetAddresAsync(string cep);
    }
}
