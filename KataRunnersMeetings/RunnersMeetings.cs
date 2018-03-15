﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

            var meetingCardinality = 1;

            while (Continue(runners))
            {
                runners.ForEach( r=> r.Position += Math.Round(r.Speed/60, 2) );
                var samePositionRunnerCount = runners.GroupBy(r => r.Position).Max(g => g.Count());
                meetingCardinality = Math.Max(meetingCardinality, samePositionRunnerCount);
            }

            //runners.ForEach( x => Console.WriteLine(x.Position) );


            return meetingCardinality == 1 ? -1 : meetingCardinality;
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
        public decimal Position { set; get; }
        public decimal Speed { set; get; }
    }
}
