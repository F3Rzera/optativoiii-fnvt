using Repository.Data.Interfaces;
using Repository.Data.Models;
using Repository.Data.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logica
{
    public class FacturaService : IFacturaRepository
    {
        private FacturaRepository facturaRepository;
        public FacturaService(string connectionString)
        {
            facturaRepository = new FacturaRepository(connectionString);
        }

        public bool add(FacturaModel factura)
        {
            return validarDatos(factura) ? facturaRepository.add(factura) : throw new Exception("Error en la validación de datos, corroborar");
        }
        public IEnumerable<FacturaModel> GetAll()
        {
            return facturaRepository.GetAll();
        }
        public bool delete(int id)
        {
            return id > 0 ? facturaRepository.delete(id) : false;
        }

        public bool update(FacturaModel facturaModel)
        {
            return validarDatos(facturaModel) ? facturaRepository.update(facturaModel) : throw new Exception("Error en la validación de datos, corroborar");
        }

        private bool validarDatos(FacturaModel factura)
        {
            if (factura == null)
                return false;
            if (factura.total == null)
                return false;
            if (factura.total_iva5 == null)
                return false;
            if (factura.total_iva10 == null)
                return false;
            if (factura.total_iva == null)
                return false;
            if (string.IsNullOrEmpty(factura.total_letras) || factura.total_letras.Length < 6)
                return false;
            if (string.IsNullOrEmpty(factura.nro_factura) || factura.nro_factura.Length != 14) {
                return false;
            } else {
                int numericValue;
                bool isNumber1, isNumber2, isNumber3;
                isNumber1 = int.TryParse(factura.nro_factura.Substring(0,3), out numericValue);
                isNumber2 = int.TryParse(factura.nro_factura.Substring(4, 3), out numericValue);
                isNumber3 = int.TryParse(factura.nro_factura.Substring(8, 6), out numericValue);
                if (!isNumber1 || !isNumber2 || !isNumber3 
                    || (!factura.nro_factura.Substring(3, 1).Equals("-")) 
                    || (!factura.nro_factura.Substring(7, 1).Equals("-")))
                {
                    return false;
                }
            }
            return true;
        } 
    }
}
