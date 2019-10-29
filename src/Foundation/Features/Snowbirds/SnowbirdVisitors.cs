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
                    var resultApi = int.Parse("10");
                    var temp = int.Parse(Model.Criteria.Substring(1));

                    return (Model.Criteria.Contains("<") && resultApi <= temp)
                           || (Model.Criteria.Contains(">") && resultApi >= temp);

                case "Sports":

                    break;
            }
                       
            return false;
        }
    }
}