using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrifindoToys
{
    internal class Setting
    {
        private int noOfLeaves;
        private int cycleDayCount;
        private DateTime cycleStartDate;
        private DateTime cycleEndDate;

        public Setting(int noOfLeaves, int cycleDayCount, DateTime cycleStartDate, DateTime cycleEndDate)
        {
            this.noOfLeaves = noOfLeaves;
            this.cycleDayCount = cycleDayCount;
            this.cycleStartDate = cycleStartDate;
            this.cycleEndDate = cycleEndDate;
        }

        public Setting()
        {
        }

        public int getNoOfLeaves()
        { 
            return noOfLeaves;
        }
        public int getCycleDayCount()
        {
            return cycleDayCount;
        }
        public DateTime getCycleStartDate()
        {
            return cycleStartDate;
        }
        public DateTime getCycleEndDate()
        {
            return cycleEndDate;
        }

        public void setNoOfLeaves(int noOfLeaves)
        {
            this.noOfLeaves= noOfLeaves;
        }

        public void setCycleDayCount(int cycleDayCount)
        {
            this.cycleDayCount = cycleDayCount;
        }

        public void setCycleStartDate(DateTime startDate)
        {
            this.cycleStartDate = startDate;
        }

        public void setCycleEndDate(DateTime endDate)
        {
            this.cycleEndDate = endDate;
        }

    }
}
