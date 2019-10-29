using EPiServer.Personalization.VisitorGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Foundation.Features.EpiVisitor
{
    public class SnowbirdCriteriaSelectionFactory : ISelectionFactory
    {
        public IEnumerable<SelectListItem> GetSelectListItems(Type propertyType)
        {
            var list = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Value = "Meteo",
                    Text = "Meteo"
                },
                new SelectListItem()
                {
                    Value = "Sports",
                    Text = "Sports"
                },
                new SelectListItem()
                {
                    Value = "Stock Trends",
                    Text = "Stock Trends"
                },
                new SelectListItem()
                {
                    Value = "Snow birds",
                    Text = "Snow birds"
                },               
                new SelectListItem()
                {
                    Value = "Ascend is cool!",
                    Text = "Ascend is cool!"
                },
                new SelectListItem()
                {
                    Value = "Epi is cool!",
                    Text = "Epi is cool!"
                },
            };

            return list;
        }
    }
}