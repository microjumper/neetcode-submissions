public class MinStack
{
    private List<int> list;
    private List<int> mins;

    public MinStack()
    {
        list = new();
        mins = new();
    }
    
    public void Push(int val)
    {
        list.Add(val);

        if (mins.Count == 0)
        {
            mins.Add(val);
        }
        else
        {
            mins.Add(Math.Min(mins[mins.Count - 1], val));
        }
    }
    
    public void Pop()
    {
        list.RemoveAt(list.Count -  1);
        mins.RemoveAt(mins.Count -  1);
    }
    
    public int Top()
    {
        return list[list.Count -  1];    
    }
    
    public int GetMin()
    {
        return mins[mins.Count -  1];
    }
}
