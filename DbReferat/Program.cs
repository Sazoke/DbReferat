using System;
using System.Data.Entity;
using System.Linq;
using Tests;

namespace DbReferat
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ApplicationDbContext(@"Server=server;Database=db;Trusted_Connection=True;");
            var a = db.TitleAuthors.Include(t => t.Author).ToList();
        }
    }
}