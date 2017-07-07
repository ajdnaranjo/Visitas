using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace Visits.Repositories
{
    public class SellerRepository
    {        
        public List<Seller> GetSellers()
        {
         
            var query = new List<Seller>() ;

            using (var context = new VisitsDatabaseEntities())
            {
                context.Database.Connection.Open();
                query = (from s in context.Sellers
                             orderby s.SellerName ascending
                             select s).ToList();
            }           

            return query;
        }

        public Seller GetSellerByDocument(string documento, int docType)
        {
            var query = new Seller();

            using (var context = new VisitsDatabaseEntities())
            {
                query = (from s in context.Sellers
                        where s.Document == documento && s.DocumentType == docType
                        select s).FirstOrDefault();
            }

            return query;

        }
    }
    
}


