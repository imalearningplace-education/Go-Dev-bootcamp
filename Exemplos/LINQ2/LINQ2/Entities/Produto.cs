using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ2.Entities {
    public class Produto {

        public long Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Categoria Categoria { get; set; }


        public override string ToString() {
            return $"Produto: Id = {Id}, Nome = {Nome}, Preco = R${Preco:F2}";
        }


    }
}
