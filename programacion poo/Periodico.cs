using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacion_poo
{
    class Periodico
    {
        //DEFINIR LOS MIENBROS DE LA CLASE
        //Propiedades
        private int _periodicoId;
        private string _nombre;
        private string _fechas;
       
        private string _descripcion;

        //metodo contructor
        public Periodico() //metodo vacio
        { }

        //soporte de sobrecarga de contructor
        public Periodico(int periodicoID, string nombre, string fecha,
            string descripcion)
        {
            _periodicoId = periodicoID;
            _nombre = nombre;
            _fechas = fecha;
            _descripcion = descripcion;
        }
        


        //metodos de propiedad
        // get 
        private int getPeriodicoId()
        {
            return _periodicoId;
        }
        
        
        //set
        public void setPeriodicoId(int peridicoId)
        {
            _periodicoId = peridicoId;

        }

        private string getNombre()
        {
            return _nombre;

        }

        public void setNombre(string nombreId)
        {
            _nombre = nombreId;
        }

        private string getFechas()
        {
            return _fechas;
        }

        public void setFechas(string fechasId)
        {
            _fechas = fechasId;
        }

        private string getDescripcion()
        {
            return _descripcion;

        }

        public void setDescripcion(string descripcionId)
        {
            _descripcion = descripcionId;

        }

        public string getPeriodicoInfo()
        {
            return "ID:  " + _periodicoId + "nombre:  " + _nombre + "fechas:  "
                + _fechas + "descripcion:  " + _descripcion;
        }






    }
}
