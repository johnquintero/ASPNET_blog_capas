//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace blogApp.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class post
    {
        public int C_id { get; set; }
        public string titulo { get; set; }
        public string urlimagen { get; set; }
        public string post1 { get; set; }
        public string autor { get; set; }
        private DateTime _date = DateTime.Now;
        public DateTime fecha
        {
            get { return this._date; }

            set { this._date = value; }
        }
    }
}
