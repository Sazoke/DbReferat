using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tests.Models
{
    [Table("authors")]
    public class Author
    {
        [Column("au_id")]
        public string Id { get; set; }
        [Column("au_lname")]
        public string LastName { get; set; }
        [Column("au_fname")]
        public string FirstName { get; set; }
        [Column("phone")]
        public string Phone { get; set; }
        [Column("address")]
        public string Address { get; set; }
        [Column("city")]
        public string City { get; set; }
        [Column("state")]
        public string State { get; set; }
        [Column("zip")]
        public string Zip { get; set; }
        [Column("contract")]
        public bool Contract { get; set; }
    }
}