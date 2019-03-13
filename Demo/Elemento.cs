using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo {
    public class Elemento<T> {
        T id;
        string descripcion;

        public T Id {
            get {
                return id;
            }

            set {
                id = value;
            }
        }

        public string Descripcion {
            get {
                return descripcion;
            }

            set {
                descripcion = value;
            }
        }

    }
}
