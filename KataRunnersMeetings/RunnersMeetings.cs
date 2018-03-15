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
            
            var runners = new List<Runner>();
            for (int i = 0; i < startPosition.Length; i++)
            {
                runners.Add(new Runner()
                {
                    Position = startPosition[i],
                    Speed = speed[i],
                });
            }

            var meetingCardinality = -1;
            var firstOrderRunner = runners.Find(r => r.Position.Equals(runners.Max(y => y.Position)));
            var secondOrderRunner = runners.Find(r => r.Position.Equals(runners.Min(y => y.Position)));
            if (firstOrderRunner.Speed >= secondOrderRunner.Speed)
            {
                meetingCardinality = -1;
            }
            else
            {
                meetingCardinality = 2;
            }


            return meetingCardinality;
        }
    }

    public class Runner
    {
        public float Position { set; get; }
        public float Speed { set; get; }
    }
}
