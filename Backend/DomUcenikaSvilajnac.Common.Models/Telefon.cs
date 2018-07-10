﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    [Table("BrojeviTelefona")]
    public class Telefon
    {
        public int Id { get; set; }
        [Column(TypeName = "NVARCHAR(MAX)")]
        public string Mobilni { get; set; }
        [Column(TypeName = "NVARCHAR(MAX)")]
        public string Kucni { get; set; }

        ICollection<Ucenik> Ucenici { get; set; }

        public Telefon()
        {
            Ucenici = new Collection<Ucenik>();
        }
    }
}
