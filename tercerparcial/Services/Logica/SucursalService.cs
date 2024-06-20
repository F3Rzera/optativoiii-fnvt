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
    public class SucursalService : ISucursalRepository
    {
        private SucursalRepository sucursalRepository;
        public SucursalService(string connectionString)
        {
            sucursalRepository = new SucursalRepository(connectionString);
        }

        public bool add(SucursalModel sucursal)
        {
            return validarDatos(sucursal) ? sucursalRepository.add(sucursal) : throw new Exception("Error en la validación de datos, corroborar");
        }

        public IEnumerable<SucursalModel> GetAll()
        {
            return sucursalRepository.GetAll();
        }

        public bool delete(int id)
        {
            return id > 0 ? sucursalRepository.delete(id) : false;
        }

        public bool update(SucursalModel sucursal)
        {
            return validarDatos(sucursal) ? sucursalRepository.update(sucursal) : throw new Exception("Error en la validación de datos, corroborar");
        }
        private bool validarDatos(SucursalModel sucursal)
        {
            if(sucursal == null)
                return false;
            if(string.IsNullOrEmpty(sucursal.descripcion) || sucursal.descripcion.Length < 10)
                return false;
            if (string.IsNullOrEmpty(sucursal.direccion))
                return false;
            if (string.IsNullOrEmpty(sucursal.telefono))
                return false;
            if (string.IsNullOrEmpty(sucursal.mail) || (!System.Text.RegularExpressions.Regex.IsMatch(sucursal.mail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")))
                return false;
            if (string.IsNullOrEmpty(sucursal.estado))
                return false;

            return true;
        }
    }
}
