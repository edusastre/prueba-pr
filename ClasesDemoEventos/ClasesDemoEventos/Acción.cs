using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDemoEventos
{
    public delegate void PrecioChangedEventHandler(decimal precioAnterior, decimal precioNuevo);


    class Acción
    {
        public string Simbolo { get; set; }

        public PrecioChangedEventHandler PrecioChanged;

        private decimal precio;

        public decimal Precio 
        {
            get { return this.precio; }
            set
            {
                if (precio == value) return;
                decimal precioAnterior = this.precio;
                this.precio = value;
                if (this.PrecioChanged != null)
                    this.PrecioChanged(precioAnterior, this.precio);
            }
        }
    }
}
