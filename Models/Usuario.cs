﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Cpf { get; set; }
        public string Fone { get; set; }
        public string E_mail { get; set; }
        public string Senha { get; set; }
    }
}
