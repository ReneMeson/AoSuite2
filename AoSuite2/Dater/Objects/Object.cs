using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dater
{
    class Object
    {
        public enum objType { Arma, Escudo}; //esto no queda asi, esta hecho asi nomas
  
        private string _objectName;
        private objType _objectType;

        private int _grhIndex;
        private int _grhIndexSecundario;

        public Object() //constructor vacio (eliminar cuando se termine de hacer la clase)
        {

        }
        public Object(string objName, objType objType, int grhIndex, int grhIndexSecundario) //constructor sobrecargado
        {
            this._objectName = objName;
            this._objectType = objType;
            this._grhIndex = grhIndex;
            this._grhIndexSecundario = grhIndexSecundario;
        }

        //Propiedades;
        public string objectName
        {
            get { return _objectName; }
            set { _objectName = value; }
        }

        public objType objectType
        {
            get { return _objectType; }
            set { _objectType = value; }
        }
    }
}
