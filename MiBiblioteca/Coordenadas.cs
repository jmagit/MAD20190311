using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senasa.Curso.Biblioteca {
    public delegate Coordenada OperaCoordenada(Coordenada otra);

    public class Coordenada {
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

        public Coordenada(int x, int y) {
            this.x = x;
            Y = y;
        }

        public virtual void Invierte() {
            var aux = X;
            X = Y;
            Y = X;
        }

        public Coordenada Incrementa(int cuanto) {
            return new Coordenada(X + cuanto, Y + cuanto);
        }
        public Coordenada Incrementa(int cuantoX, int cuantoY) {
            return new Coordenada(X + cuantoX, Y + cuantoY);
        }
        /// <summary>
        /// Incrementa el valor de los componentes de la coordenada
        /// </summary>
        /// <param name="cuanto">Valor del incremento, debe ser númerico</param>
        /// <returns>Nuevo punto con los componentes incrementados</returns>
        /// <exception cref="ArgumentNullException" />
        [Obsolete]
        public Coordenada Incrementa(string cuanto) {
            return new Coordenada(X + int.Parse(cuanto), Y + int.Parse(cuanto));
        }
        public Coordenada IncrementaEx(string cuanto) {
            try {
                return new Coordenada(X + int.Parse(cuanto), Y + int.Parse(cuanto));
            } catch (Exception ex) {
                throw new BibliotecaException("ERROR en cuantos", ex);
            }
        }

        public Coordenada Suma(Coordenada otra) {
            return new Coordenada(X + otra.X, Y + otra.Y);
        }
        public Coordenada Resta(Coordenada otra) {
            return new Coordenada(X - otra.X, Y - otra.Y);
        }

        public void Calcula(OperaCoordenada m) {
            var rslt = m(this);
            X = rslt.X;
            Y = rslt.Y;
        }
        public override string ToString() {
            return $"Punto: x={X} y={Y}";
        }
    }

    public class Coordenada3D : Coordenada {
        public int Z { get; set; }

        public Coordenada3D(int x, int y, int z) : base(x, y) {
            Z = z;
        }
        public override void Invierte() {
            base.Invierte();
            Z = -Z;
        }

    }
}
