using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Senasa.Curso.Biblioteca;

namespace Demo {
    /// <summary>
    /// 
    /// </summary>
    class Program {
        struct Punto {
            int x, y;
        }
        #region Atributos
        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <param name="kk"></param>
        /// <returns></returns>
        static void Main(string[] args) {
            Coordenada c = new Coordenada(0, 0);

            try {
                c.Incrementa("abc");
            } catch (BibliotecaException ex) {
                Console.WriteLine(ex.Message);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
