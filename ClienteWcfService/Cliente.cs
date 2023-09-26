using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClienteWcfService
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        public bool Save()
        {
            return true;
        }
    }
}