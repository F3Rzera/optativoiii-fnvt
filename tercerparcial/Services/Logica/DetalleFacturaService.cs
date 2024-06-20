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
    public class DetalleFacturaService : IDetalleFacturaRepository
    {
        private DetalleFacturaRepository detalleFacturaRepository;
        public DetalleFacturaService(string connectionString)
        {
            detalleFacturaRepository = new DetalleFacturaRepository(connectionString);
        }

        public bool add(DetalleFacturaModel detalleFactura)
        {
            return validarDatos(detalleFactura) ? detalleFacturaRepository.add(detalleFactura) : throw new Exception("Error en la validación de datos, corroborar");
        }

        public IEnumerable<DetalleFacturaModel> GetAll()
        {
            return detalleFacturaRepository.GetAll();
        }

        public bool delete(int id)
        {
            return id > 0 ? detalleFacturaRepository.delete(id) : false;
        }

        public bool update(DetalleFacturaModel detalleFactura)
        {
            return validarDatos(detalleFactura) ? detalleFacturaRepository.update(detalleFactura) : throw new Exception("Error en la validación de datos, corroborar");
        }
        private bool validarDatos(DetalleFacturaModel detalleFactura)
        {
            if(detalleFactura.cantidad_producto < 1 || detalleFactura.subtotal < 1)
                return false;

            return true;
        }

    }
}
