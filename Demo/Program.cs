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
            Coordenada a = new Coordenada(2, 2);
            OperaCoordenada metodo = a.Resta;
            Elemento<int> prov = new Elemento<int>();
            prov.Id =4;
            Elemento<string> pais = new Elemento<string>();
            pais.Id = "ES";

            try {
                c.Incrementa("11");
                metodo = c.Suma;
            } catch (BibliotecaException ex) {
                Console.WriteLine(ex.Message);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            var rslt = metodo(c);
            c.Calcula(a.Resta);
            c.Calcula(Calc);
            c.Calcula(
                delegate(Coordenada item) 
                { return new Coordenada(item.X*2, item.Y*2); }
                );
            c.Calcula(item => new Coordenada(item.X*2, item.Y*2));
            Console.ReadKey();
        }

        static public Coordenada Calc(Coordenada otra) {
            return new Coordenada(otra.X, otra.Y);
        }
    }
}
