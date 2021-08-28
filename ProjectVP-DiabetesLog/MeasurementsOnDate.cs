using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVP_DiabetesLog
{
    class MeasurementsOnDate
    {
        public DateTime date { get; private set; }
        public List<TimeMeasurement> timeMeasurements { get; private set; }

        public MeasurementsOnDate(DateTime date) {
            this.date = date;
            timeMeasurements = new List<TimeMeasurement>();
        }
        public MeasurementsOnDate(DateTime date, List<TimeMeasurement> timeMeasurements) {
            this.date = date;
            this.timeMeasurements = timeMeasurements;
        }

        public void addTimeMeasurement(TimeMeasurement measurementToAdd) {
            timeMeasurements.Add(measurementToAdd);
        }
    }
}
