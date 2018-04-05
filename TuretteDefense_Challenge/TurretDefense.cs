using System;

/*
Incoming! Fire the defense turrets at these coordinates! Go go go!"

You have been given a list of incoming targets that must be shot down in the order they are given. 
Assuming your turret is aimed at some location, it will take time to move the turret and fire at a different location. 
If you are currently aimed at point (a,b), and you must move to aim at point (c,d), the time required is the absolute difference 
in first coordinates plus the absolute difference in second coordinates.
For example, starting at (3,7) it will take 4 seconds to aim at point (5,5). Along with the coordinates of each incoming target, 
you are also given their arrival times. The turret must be fired precisely at the arrival time in the direction of the target. 
Immediately after firing, the turret can be moved to aim at the next location (no time is lost firing). 
Your method will return the index of the earliest target that cannot be shot down. For example, let's assume
    xs    = {3,5,6}
    ys    = {7,5,6}
    times = {11,15,16}.
Your turret always begins aimed at (0,0) at time 0. Since the first target is arriving at location (3,7) at time 11 you have 11 seconds 
to move there and fire. This is 1 second more than is needed. At time 11 you fire the turret, and immediately start moving to aim at (5,5).
Since the second target arrives at time 15, you have 4 seconds to aim. This is exactly enough time. At time 15, you fire at the second target.
Unfortunately, the third target will arrive before you can shoot it down. 
You would return 2 since target 2 (third target) is the earliest one you couldn't shoot down. If you could shoot them all down, return -1.
As shown above, xs[i],ys[i] are the coordinates, and times[i] is the arrival time of target i.
*/


namespace TuretteDefense_Challenge
{
	public class TurretDefense
	{
		public int FirstMiss(int[] xs, int[]ys, int[] times)
		{
			if (!CanShootTarget(0, xs[0], 0, ys[0], times[0]))
				return 0;

			for (var i = 0; i < times.Length - 1; i++)
				if (!CanShootTarget(xs[i], xs[i + 1], ys[i], ys[i + 1], times[i + 1] - times[i]))
					return i + 1;

			return -1;
		}

		private bool CanShootTarget(int x1, int x2, int y1, int y2, int time)
		{
			return Math.Abs(x1 - x2) + Math.Abs(y1 - y2) <= time;
		}
	}
}