using EPiServer.Personalization.VisitorGroups;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Foundation.Features.EpiVisitor
{
    public class SnowbirdCriterionModel : CriterionModelBase
    {
        [Required]
        [DojoWidget(SelectionFactoryType = typeof(SnowbirdCriteriaSelectionFactory))]
        public string Event { get; set; }

        [Required]
        [DojoWidget]
        public string Criteria { get; set; }

        public override ICriterionModel Copy()
        {
            return ShallowCopy();
        }
    }
}