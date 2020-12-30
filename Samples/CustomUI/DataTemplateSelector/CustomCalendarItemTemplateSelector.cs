using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomUI
{
    public class CustomCalendarItemTemplateSelector : DataTemplateSelector
    {
        public CustomCalendarItemTemplateSelector()
        {
            SpecialDates = new Dictionary<DateTimeOffset, string>();
            SpecialDates.Add(DateTimeOffset.Now.AddMonths(-1).AddDays(1), "BirthDay");
            SpecialDates.Add(DateTimeOffset.Now.AddMonths(-1).AddDays(5), "Gift");
            SpecialDates.Add(DateTimeOffset.Now.AddMonths(-1).AddDays(-2), "Award");
            SpecialDates.Add(DateTimeOffset.Now.AddDays(1), "Gift");
            SpecialDates.Add(DateTimeOffset.Now.AddDays(9), "BirthDay");
            SpecialDates.Add(DateTimeOffset.Now.AddDays(-4), "Award");
            SpecialDates.Add(DateTimeOffset.Now.AddMonths(1).AddDays(1), "Award");
            SpecialDates.Add(DateTimeOffset.Now.AddMonths(1).AddDays(3), "BirthDay");
            SpecialDates.Add(DateTimeOffset.Now.AddMonths(1).AddDays(-5), "Gift");
        }
        private Dictionary<DateTimeOffset, string> SpecialDates { get; set; }

        public DataTemplate DefaultTemplate { get; set; }
        public DataTemplate BirthdayTemplate { get; set; }
        public DataTemplate GiftTemplate { get; set; }
        public DataTemplate AwardTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            if (item != null)
            {
                DateTimeOffset calendarItem = (DateTimeOffset)item;
                DateTimeOffset dateTimeOffset = SpecialDates.Keys.FirstOrDefault(x => x.Date == calendarItem.Date);

                if (dateTimeOffset != DateTimeOffset.MinValue)
                {
                    string template = this.SpecialDates[dateTimeOffset];

                    switch (template)
                    {
                        case "BirthDay":
                            return BirthdayTemplate;
                        case "Gift":
                            return GiftTemplate;
                        case "Award":
                            return AwardTemplate;
                    }
                }
                return DefaultTemplate;
            }
            return base.SelectTemplateCore(item, container);
        }
    }

}
