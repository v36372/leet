public bool IsValid(string s)
{
    Stack<char> stack = new Stack<char>();

    foreach (var curr in s)
    {
        switch (curr)
        {
            case '(':
                stack.Push(')');
                break;
            case '[':
                stack.Push(']');
                break;
            case '{':
                stack.Push('}');
                break;
            case ')':

            case ']':

            case '}':

                if (stack.Count == 0 || stack.Pop() != curr)
                    return false;
                break;

        }
    }

    return stack.Count == 0;
}