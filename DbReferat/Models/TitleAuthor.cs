using System.ComponentModel.DataAnnotations.Schema;

namespace Tests.Models
{
    [Table("titleauthor")]
    public class TitleAuthor
    {
        [Column("au_id")]
        public string AuthorId { get; set; }
        [ForeignKey(nameof(AuthorId))]
        public Author Author { get; set; }
        [Column("title_id")]
        public string TitleId { get; set; }
        [ForeignKey(nameof(TitleId))]
        public Title Title { get; set; }
        [Column("au_ord")]
        public byte Order { get; set; }
        [Column("royaltyper")]
        public int RoyalTyper { get; set; }
    }
}