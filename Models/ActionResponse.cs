using System;
using System.Collections.Generic;

#nullable enable

namespace crud_cep.Models
{
    public partial class ActionResponse
    {
        public string? result { get; set; }
        public Cep? cep { get; set; }
    }
}
