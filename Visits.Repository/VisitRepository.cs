using System;
using System.Linq;

namespace Visits.Repositories
{
    [Serializable]
    public class VisitRepository
    {        
        public int SaveVisit(Visit saveVisit)
        {
            int id = 0;
            using (var context = new VisitsDatabaseEntities())
            {
                var visit = new Visit();

                visit = new Visit();
                visit.ClientID = saveVisit.ClientID;               
                visit.SellerID= saveVisit.SellerID;                
                visit.Observations = saveVisit.Observations;
                visit.VistDate = saveVisit.VistDate;                

                context.Visits.Add(visit);
                context.SaveChanges();

                id = visit.VisitsID;          
            }
            return id;

        }

        public Visit GetVisitByID(int clientID)
        {
            var query = new Visit();
            using (var context = new VisitsDatabaseEntities())
            {
                query = context.Visits.FirstOrDefault(x => x.ClientID == clientID);
            }

            return query;

        }


    }
}
