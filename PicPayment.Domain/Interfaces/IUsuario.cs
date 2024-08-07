using PicPayment.Domain.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicPayment.Domain.Interfaces
{
    public interface IUsuario
    {
        public Guid Id { get; set; }
        public string NomeCompleto { get; set; }
        public long CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Categoria { get; set; }
        public double Saldo { get; set; }
        public ICollection<Transferencia> TransferenciasOrigem { get; set; }
        public ICollection<Transferencia> TransferenciasDestino { get; set; }
    }
}
