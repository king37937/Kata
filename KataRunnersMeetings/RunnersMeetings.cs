using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KataRunnersMeetings
{
    public class RunnersMeetings
    {
        public int CalculateRunnersMeetings(int[] startPosition, int[] speed)
        {
            var runners = new List<Runner>();
            for (int i = 0; i < startPosition.Length; i++)
            {
                runners.Add(new Runner()
                {
                    Position = ConvertToPositionPerMinute(startPosition[i]),
                    Speed = speed[i],
                });
            }

            var meetingCardinality = 1;
            while (Continue(runners))
            {
                UpdatePosition(runners);
                var samePositionRunnerCount = CountSamePositionRunners(runners);
                meetingCardinality = Math.Max(meetingCardinality, samePositionRunnerCount);
            }

            return meetingCardinality == 1 ? -1 : meetingCardinality;
        }

        private int CountSamePositionRunners(List<Runner> runners)
        {
            return runners.GroupBy(r => r.Position).Max(g => g.Count());
        }

        private void UpdatePosition(List<Runner> runners)
        {
            runners.ForEach(r => r.Position += r.Speed);
        }

        private int ConvertToPositionPerMinute(int startPosition)
        {
            return startPosition * 60;
        }

        private bool Continue(List<Runner> runners)
        {
            runners.Sort((x, y) => x.Position.CompareTo(y.Position));
            for (var i = 0; i < runners.Count-1; i++)
            {
                for (var j = i+1; j < runners.Count; j++)
                {
                    if ( runners[i].Speed > runners[j].Speed)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }

    public class Runner
    {
        public int Position { set; get; }
        public int Speed { set; get; }
    }
}
