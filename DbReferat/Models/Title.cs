using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace Tests.Models
{
    [Table("titles")]
    public class Title
    {
        [Column("title_id")]
        public string Id { get; set; }
        [Column("title")]
        public string Name { get; set; }
        [Column("type")]
        public string Type { get; set; }
        [Column("pub_id")]
        public string PubId { get; set; }
        [Column("price")]
        public SqlMoney Price { get; set; }
        [Column("advance")]
        public SqlMoney Advance { get; set; }
        [Column("royalty")]
        public Int32? Royalty { get; set; }
        [Column("ytd_sales")]
        public Int32? Ytd { get; set; }
        [Column("notes")]
        public string Notes { get; set; }
        [Column("pubdate")]
        public DateTime PubDate { get; set; }
    }
}