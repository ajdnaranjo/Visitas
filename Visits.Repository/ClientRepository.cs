using System;
using System.Collections.Generic;
using System.Linq;

namespace Visits.Repositories
{
    [Serializable]
    public class ClientRepository
    {        

        public Client GetClientByDocument(string documento, int docType)
        {
            var query = new Client();

            using (var context = new VisitsDatabaseEntities())
            {
                query = (from c in context.Clients
                         where c.Document == documento && c.DocumentType == docType
                         select c).FirstOrDefault();
            }

            return query;

        }


        public List<DocumentType> GetDocumentTypes()
        {
            var query = new List<DocumentType>();

            using (var context = new VisitsDatabaseEntities())
            {
                query = (from dt in context.DocumentTypes
                         orderby dt.DocumentTypeID ascending
                         select dt).ToList();
            }

            return query;

        }
    }
}
