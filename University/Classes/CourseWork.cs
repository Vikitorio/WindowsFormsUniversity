using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace University.Classes
{
    public class CourseWork
    {
        private String _title;
        private DateTime _startDate;
        private DateTime _deadLine;
        public CourseWork() {
            _title = "Programuvanie";
            _startDate = new DateTime(2022,12,19);
            _deadLine = new DateTime(2023, 1, 19);
        }
        public CourseWork(String title, DateTime start , DateTime deadLine)
        {
            _title = title;
            _startDate = start;
            _deadLine = deadLine;

        }
        public Boolean isDeadlineFailed() {
            return true;
        }
        public String Title {
            get { return _title; }
            set { _title = value; }
        }
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }
        public DateTime DeadLine
        {
            get { return _deadLine; }
            set { _deadLine = value; }
        }


    }
}
