﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.Text;

namespace Sample.Kadastro.ServicoDistribuido.Contracts
{
    [DataContract]
    public class UsuarioDataContract
    {
        [DataMember]
        public Nullable<Int32> Id { get; set; }

        [DataMember]
        public string Login { get; set; }

        [DataMember]
        public string Senha { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public string DescricaoDoStatus { get; set; }
    }
}