public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        if (tokens == null || tokens.Length == 0)
        {
            throw new ArgumentException();
        }

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
                            throw new ArgumentException();;
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        if (stack.Count != 1)
        {
            throw new ArgumentException();
        }

        return stack.Pop();
    }
}
