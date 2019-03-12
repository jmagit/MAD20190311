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
        static int Main(string[] args, int kk) {
            Coordenadas c = new Coordenadas();
            c.X = 4;
            if(c.X == 4)
            c.tipo = "kk";

            //Nullable<int> i;
            int? i = 4;
            string p = "400€";
            try {
                i = int.Parse(p);
                

            } catch (Exception) {

                throw;
            }

            if(int.TryParse(p, out i)) {

            }

            i = null;
            if(i.HasValue) {
                int j = i.Value;
                j.ToString();
            }
            string r = "kk";
            var c = 4;
            c = "dd";
            //r = "Elemento" + (i.Value == 1 ? "" : "s") + 
            for(int i=0; i < limite; i++) {

            }
            
            return 0;
        }
    }
}
