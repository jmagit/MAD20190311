using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senasa.Curso.Biblioteca {
    public class Coordenadas {
        private int x, y;
        private int[] men = new int[2];

        public string tipo;

        public int X {
            get {
                return x;
            }
            set {
                if (x != value)
                    x = value;
            }
        }
        public int Y {
            get { return y; }
            set { y = value; }
        }

        public string Nombre { get; set; }
    }
}
