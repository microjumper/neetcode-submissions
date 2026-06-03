public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var frequencyCount = new Dictionary<int, int>();

        foreach (var n in nums)
        {
            frequencyCount[n] = frequencyCount.GetValueOrDefault(n) + 1;
        }

        var pq = new PriorityQueue<int, int>();

        foreach (var kvp in frequencyCount)
        {
            pq.Enqueue(kvp.Key, kvp.Value); // (element, priority)

            // If we exceed K, remove the element with the lowest frequency, to keep the queue short
            if (pq.Count > k)
            {
                pq.Dequeue();
            }
        }

        int[] topK = new int[k];

        for (int i = k - 1; i >= 0; i--)
        {
            topK[i] = pq.Dequeue();
        }

        return topK;
    }
}
