using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
   public class Especialidad : BusinessEntity
    {

       public Especialidad(string desc)
       {
           this.Descripcion = desc;
           //this.Id = id;

       }

        private string _descripcion;
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

       private int _id;
       public int Id
       {
           get { return _id; }
           set { _id = value; }
       }
    }
}
