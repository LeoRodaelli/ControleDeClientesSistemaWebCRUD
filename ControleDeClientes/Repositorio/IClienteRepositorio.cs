using ControleDeClientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeClientes.Repositorio
{
    public interface IClienteRepositorio
    {
        ClienteModel ListarPorId(int id);

        List<ClienteModel> BuscarTodos();  //listar dados no banco

        ClienteModel Adicionar(ClienteModel cliente);

        ClienteModel Atualizar(ClienteModel cliente);

        bool Apagar(int id);
        

        




    }
}
