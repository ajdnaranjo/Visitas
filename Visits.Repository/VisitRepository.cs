using System;
using System.Configuration;

namespace Visits.Repositories
{
    [Serializable]
    public class VisitRepository
    {
        string cnn = ConfigurationManager.ConnectionStrings["VisitsDatabaseEntities"].ToString();
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



    }
}
