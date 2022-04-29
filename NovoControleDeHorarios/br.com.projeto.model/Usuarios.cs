using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoControleDeHorarios.br.com.projeto.model {
    public class Usuarios {
        //Atributos
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string permissao { get; set; }
        public int senha { get; set; }
        public int novasenha { get; set; }
    }
}
