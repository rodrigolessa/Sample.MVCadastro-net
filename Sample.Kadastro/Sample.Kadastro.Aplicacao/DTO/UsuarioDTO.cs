﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample.Kadastro.Aplicacao.DTO
{
    public class UsuarioDTO
    {
        public int Id
        {
            get;
            set;
        }

        public string Login
        {
            get;
            set;
        }

        public string Senha
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public bool EhPrimeiroAcesso
        {
            get;
            set;
        }
    }
}
