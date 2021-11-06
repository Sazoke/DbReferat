using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Tests.Models
{
    [Table("sales")]
    public class Sale
    {
        [Column("stor_id")]
        public string StoreId { get; set; }
        [Column("ord_num")]
        public string OrderNumber { get; set; }
        [Column("ord_date")]
        public DateTime DateTime { get; set; }
        [Column("qty")]
        public Int16 Qty { get; set; }
        [Column("payterms")]
        public string PayTerms { get; set; }
        [Column("title_id")]
        public string TitleId { get; set; }
    }
}