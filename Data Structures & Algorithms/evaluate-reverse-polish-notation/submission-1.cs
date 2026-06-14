public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();

        foreach (var t in tokens)
        {
            if (int.TryParse(t, out int o))
            {
                stack.Push(o);
            }
            else
            {
                if (stack.TryPop(out int op2) && stack.TryPop(out int op1))
                {
                    switch (t)
                    {
                        case "+":
                            stack.Push(op1 + op2);
                            break;
                        case "-":
                            stack.Push(op1 - op2);
                            break;
                        case "*":
                            stack.Push(op1 * op2);
                            break;
                        case "/":
                            stack.Push(op1 / op2);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        return stack.Pop();
    }
}
