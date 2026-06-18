public class Solution
{
    public int CarFleet(int target, int[] position, int[] speed)
    {
        (int p, int s)[] cars = new(int, int)[position.Length];

        for (int i = 0; i < cars.Length; i++)
        {
            cars[i] = (position[i], speed[i]);
        }

        Array.Sort(cars, (c1, c2) => c2.p.CompareTo(c1.p));

        int fleets = 0;
        float timeToTarget = 0;

        foreach (var c in cars)
        {
            float time = (float)(target - c.p) / c.s;
            if (time > timeToTarget)
            {
                fleets++;
                timeToTarget = time;
            }
        }

        return fleets;
    }
}
