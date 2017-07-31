using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaBlaTest
{
    public class SearchModel
    {
        public string From { get; set; }
        public string Destinatiom { get; set; }
        public string WhenDate { get; set; }
        public int DaysFromNow { get; set; }

        public SearchModel() { }

        //public BlaBlaSearchModel(string from, string destinatiom, int daysFromNow)
        //{
        //    From = from;
        //    Destinatiom = destinatiom;
        //    DaysFromNow = daysFromNow;
        //    WhenDate = DateTime.Now.AddDays(DaysFromNow).ToString();
        //    // Configure();
        //}


            //public void Configure()
            //{
            //    var dateFormat = TestData.Get<string>(TestData.DateFormat);
            //var startTimeOrig = DateTime.Now.AddDays(daysFromNow).AddHours(hoursFromNow);
            //if (startTimeOrig.Date == DateTime.Today && startTimeOrig >= time6pm)
            //{
            //    startTimeOrig = DateTime.Today.AddDays(1).AddHours(8);
            //}
            //var endTimeOrig = startTimeOrig.AddDays(daysCount).AddHours(hoursCount);
            //StartDateTime = TestHelpers.GetNearestTimeTo(startTimeOrig).ToString("o");
            //EndDateTime = TestHelpers.GetNearestTimeTo(endTimeOrig).ToString("o");
            //StartDate = (startTimeOrig.Date == DateTime.Today) ? today : startTimeOrig.ToString(dateFormat);
            //StartTime = TestHelpers.GetNextTimeValue(startTimeOrig);
            //EndDate = StartDate.Equals(today) && DayDurations.Equals("0") ? StartDate : endTimeOrig.ToString(dateFormat);
            //EndTime = TestHelpers.GetNextTimeValue(endTimeOrig);         
           //}

    }
}
