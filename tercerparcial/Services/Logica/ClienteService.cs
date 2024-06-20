using Repository.Data.Interfaces;
using Repository.Data.Models;
using Repository.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logica
{
    public class ClienteService : IClienteRepository
    {
        private ClienteRepository clienteRepository;
        public ClienteService(string connectionString)
        {
            clienteRepository = new ClienteRepository(connectionString);
        }

        public bool add(ClienteModel cliente)
        {
            return validarDatos(cliente) ? clienteRepository.add(cliente) : throw new Exception("Error en la validación de datos, corroborar");
        }

        public IEnumerable<ClienteModel> GetAll()
        {
            return clienteRepository.GetAll();
        }

        public bool delete(int id)
        {
            return id > 0 ? clienteRepository.delete(id) : false;
        }


        public bool update(ClienteModel clienteModel)
        {
            return validarDatos(clienteModel) ? clienteRepository.update(clienteModel) : throw new Exception("Error en la validación de datos, corroborar");
        }
        private bool validarDatos(ClienteModel cliente)
        {
            if(cliente == null)
                return false;
            if(string.IsNullOrEmpty(cliente.nombre) || cliente.nombre.Length < 3)
                return false;
            if (string.IsNullOrEmpty(cliente.apellido) || cliente.apellido.Length < 3)
                return false;
            if (string.IsNullOrEmpty(cliente.documento) || cliente.documento.Length < 3)
                return false;
            if (cliente.celular > 9999999999)
                return false;

            return true;
        }
    }
}
