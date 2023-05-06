using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Profissao { get; set; }

        public Cliente(string nome, string email, string profissao)
        {
            Nome = nome;
            Email = email;
            Profissao = profissao;
        }



    }
}
