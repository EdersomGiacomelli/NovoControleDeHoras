using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoControleDeHorarios.br.com.projeto.model {
    class Horarios {
        public int id { get; set; }
        public string cpf { get; set; }
        public string nome { get; set; }
        public string data { get; set; }
        public string entrada { get; set; }
        public string saida { get; set; }
        public int senha { get; set; }
        public int Fk_id { get; set; }

    }
}
