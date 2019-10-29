using EPiServer.Personalization.VisitorGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace Foundation.Features.EpiVisitor
{
    [VisitorGroupCriterion(Category = "Life Events", Description = "Real Time Life Events", DisplayName = "Real Time Life Events")]
    public class SnowbirdVisitors : CriterionBase<SnowbirdCriterionModel>
    {
        public override bool IsMatch(IPrincipal principal, HttpContextBase httpContext)
        {
            switch (Model.Event)
            {
                case "Meteo":
                    // get the service call api to find out the meteo
                    var resultApi = "10";
                    if(Model.Criteria == resultApi)
                        return true;
                    break;

                case "Sports":

                    break;
            }
                       
            return false;
        }
    }
}