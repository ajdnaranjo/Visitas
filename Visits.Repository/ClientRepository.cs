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

        public Client SaveClient(Client client)
        {
            var cl = new Client();
            using (var context = new VisitsDatabaseEntities())
            {

                var cc = context.Clients.FirstOrDefault(x => x.Document == client.Document && x.DocumentType == client.DocumentType);

                if (cc == null)
                {
                    var c = new Client();
                    c = new Client();
                    c.Document = client.Document;
                    c.DocumentType = client.DocumentType;
                    c.ClientName = client.ClientName;
                    c.ContactName = client.ContactName;
                    c.Email = client.Email;
                    c.Phone = client.Phone;
                    c.Address = client.Address;
                    c.Position = client.Position;
                    c.Consumption = client.Consumption;
                    c.Fabric = client.Fabric;

                    context.Clients.Add(c);

                    context.SaveChanges();

                    cl = c;
                }
                else
                {
                    cc.ClientName = client.ClientName;
                    cc.ContactName = client.ContactName;
                    cc.Email = client.Email;
                    cc.Phone = client.Phone;
                    cc.Address = client.Address;
                    cc.Position = client.Position;
                    cc.Consumption = client.Consumption;
                    cc.Fabric = client.Fabric;

                    context.SaveChanges();

                    cl = cc;
                }
              
            }

            return cl;
        }
    }
}
