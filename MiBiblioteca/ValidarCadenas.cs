using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senasa.Curso.Biblioteca {
    public static class ValidarCadenas {
        public static bool EstaVacia(this string cad) {
            return string.IsNullOrWhiteSpace(cad);
        }
        public static bool NoEstaVacia(this string cad) {
            return !EstaVacia(cad);
        }
        public static bool MaxLen(this string cad, int max) {
            return EstaVacia(cad) || cad.Length <= max;
        }

    }
}
