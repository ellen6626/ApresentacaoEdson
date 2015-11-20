using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjDoctorHelpDev
{
    class clsContatos
    {
        public int id { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public String Cep { get; set; }
        public String Endereco { get; set; }
        public int Numero { get; set; }
        public String Complemento { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public String Observacoes { get; set; }

        public void GravarContato()
        {
            clsBD.ExecutarSQL("INSERT INTO tbl_Contatos(Nome, Email, Telefone, Cep,Endereco, Numero, Complemento, Bairro, Cidade, Estado, Observacoes) VALUES ('" + Nome + "','" + Email + "','" + Telefone + "','" + Cep + "','" + Endereco + "','" + Numero + "','" + Complemento + "','" + Bairro + "','" + Cidade + "','" + Estado + "','" + Observacoes +"' )");
        }
    }
}
