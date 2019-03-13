using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senasa.Curso.Biblioteca {
    public class BibliotecaException : Exception {
        public BibliotecaException() : base() { }
        public BibliotecaException(string message) : base(message) { }
        public BibliotecaException(string message, Exception innerException) : 
            base(message, innerException) { }
    }
}
