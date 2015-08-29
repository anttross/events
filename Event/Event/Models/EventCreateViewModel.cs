using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Event.Models
{
    public class EventCreateViewModel
    {
        /// <summary>
        /// Event item
        /// </summary>
        public Events EventItem { get; set; }

        /// <summary>
        /// Custom event
        /// </summary>
        public string Other { get; set; }

        /// <summary>
        /// List of subjects
        /// </summary>
        public List<SelectListItem> Subjects { get; set; }


        public EventCreateViewModel()
        {
            this.EventItem = new Events();
            this.Subjects = GetSubjectsSelectedList();
        }

        /// <summary>
        /// Build LessonTime selected list
        /// </summary>
        /// <returns></returns>
        private List<SelectListItem> GetSubjectsSelectedList()
        {
            var items = new List<SelectListItem>();
            items.Add(new SelectListItem() { Text = "יומ הולדת", Value = "יומ הולדת" });
            items.Add(new SelectListItem() { Text = "ברית", Value = "ברית" });
            items.Add(new SelectListItem() { Text = "בר/בת מצווה", Value = "בר/בת מצווה" });
            items.Add(new SelectListItem() { Text = "מסיבת גיוס", Value = "מסיבת גיוס" });
            items.Add(new SelectListItem() { Text = "חתונה", Value = "חתונה" });
            items.Add(new SelectListItem() { Text = "לוויה", Value = "לוויה" });
            items.Add(new SelectListItem() { Text = "אחר", Value = "אחר" });
            return items;
        }
    }
}