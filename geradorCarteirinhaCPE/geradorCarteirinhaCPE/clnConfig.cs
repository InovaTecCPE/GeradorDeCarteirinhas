using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geradorCarteirinhaCPE
{
    class clnConfig
    {
        private int ano_validade = 2019;
        private int tipo = 1;
        private string cargo = "Aluno";


        public int Tipo { get => tipo; set => tipo = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public int Ano_validade { get => ano_validade; set => ano_validade = value; }

        /*  1 - Aluno
            2 - Professor
            3 - Plantonista
            4 - Membro
        */





    }
}
