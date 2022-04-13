using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Project_3.Models;
using Project_3.Models.Entity;

namespace Project_3.DAL
{
    public class LibraInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LibraContext>
    {
        
        protected override void Seed(LibraContext context)
        {
            var Books = new List<Book>
            {
                //new Book{BookName="Конституция",AuthorID=0,Year=1993,LanguageID=0,CoverID=0}
            };

            
            
        }
    }
}
