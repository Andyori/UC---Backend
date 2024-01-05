using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UC_Backend.classes
{
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }
        public void Inserir(PessoaJuridica pj)
        {
            using(StreamWriter escritor = new StreamWriter(pj.Nome+".txt"))
            {
                escritor.WriteLine($"{pj.Nome};{pj.CNPJ};{pj.Rendimento}");
            }
        }
    }
}