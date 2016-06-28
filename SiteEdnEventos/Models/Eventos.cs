namespace SiteEdnEventos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Eventos
    {
        [Key]
        public int IdEvento { get; set; }

        [Required]
        public string BairroEvento { get; set; }

        public int CepEvento { get; set; }

        [Required]
        public string CidadeEvento { get; set; }

        [Column(TypeName = "datetime2")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataEvento { get; set; }

        [Required]
        public string ImagemProduto { get; set; }

        [Required]
        public string LocalEvento { get; set; }

        [Required]
        public string NomeEvento { get; set; }

        public int NumeroLocalEvento { get; set; }

        public bool Status { get; set; }

        public decimal ValorEvento { get; set; }

        public decimal Caixa { get; set; }

        public TimeSpan Hora { get; set; }
    }
}
