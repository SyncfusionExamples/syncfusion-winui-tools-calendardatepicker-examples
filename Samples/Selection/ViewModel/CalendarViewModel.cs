using Syncfusion.UI.Xaml.Calendar;
using Syncfusion.UI.Xaml.Core;
using Syncfusion.UI.Xaml.Editors;
using System;

namespace Selection
{
    class CalendarViewModel : NotificationObject
    {
        private CalendarItemHighlightMode todayHighlightMode = CalendarItemHighlightMode.FilledRectangle;
        private CalendarItemHighlightMode selectionHighlightMode = CalendarItemHighlightMode.Rectangle;
        private DayOfWeek firstDayOfWeek =  DayOfWeek.Sunday;
        private int numberOfWeeksInView =  6;
        private bool allowNullValue = true;
        private DateTimeEditMode editMode = DateTimeEditMode.Mask;
        private string placeHolderText = "No Date is Selected";

        public DateTimeEditMode EditMode
        {
            get
            {
                return editMode;
            }
            set
            {
                if (editMode != value)
                {
                    editMode = value;
                    this.RaisePropertyChanged(nameof(this.EditMode));
                }
            }
        }

        public bool AllowNullValue
        {
            get
            {
                return allowNullValue;
            }
            set
            {
                if (allowNullValue != value)
                {
                    allowNullValue = value;
                    this.RaisePropertyChanged(nameof(this.AllowNullValue));
                }
            }
        }

        public string PlaceHolderText
        {
            get
            {
                return placeHolderText;
            }
            set
            {
                if (placeHolderText != value)
                {
                    placeHolderText = value;
                    this.RaisePropertyChanged(nameof(this.PlaceHolderText));
                }
            }
        }

        public CalendarItemHighlightMode TodayHighlightMode
        {
            get
            {
                return todayHighlightMode;
            }
            set
            {
                todayHighlightMode = value;
                this.RaisePropertyChanged(nameof(TodayHighlightMode));
            }
        }
        public CalendarItemHighlightMode SelectionHighlightMode
        {
            get
            {
                return selectionHighlightMode;
            }
            set
            {
                selectionHighlightMode = value;
                this.RaisePropertyChanged(nameof(SelectionHighlightMode));
            }
        }
        
        public DayOfWeek FirstDayOfWeek
        {
            get
            {
                return firstDayOfWeek;
            }
            set
            {
                firstDayOfWeek = value;
                this.RaisePropertyChanged(nameof(FirstDayOfWeek));
            }
        }
        
        public int NumberOfWeeksInView
        {
            get
            {
                return numberOfWeeksInView;
            }
            set
            {
                numberOfWeeksInView = value;
                this.RaisePropertyChanged(nameof(NumberOfWeeksInView));
            }
        }
    }
}
