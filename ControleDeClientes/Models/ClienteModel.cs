using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeClientes.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Digite o nome do cliente")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o email do cliente")]
        [EmailAddress(ErrorMessage ="O email informado não é valido!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite o celular do cliente")]
        [Phone(ErrorMessage ="O celular informado não é valido!")]
        public string Celular { get; set; }

    }
}
