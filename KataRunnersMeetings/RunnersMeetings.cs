using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataRunnersMeetings
{
    public class RunnersMeetings
    {
        public int CalculateRunningsMeetings(int[] startPosition, int[] speed)
        {
            var meetingCardinality = -1;
            if (startPosition[0] < startPosition[1] )
            {
                if (speed[0] <= speed[1])
                {
                    meetingCardinality = -1;
                }
                else
                {
                    meetingCardinality = 2;
                }
            }
            

            return meetingCardinality;
        }
    }
}
