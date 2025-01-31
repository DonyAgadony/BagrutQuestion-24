class BinNode<T>
{
    T Value;
    BinNode<T>? Left;

    BinNode<T>? Right;

    public BinNode(T value)
    {
        Value = value;
    }

    public BinNode(T value, BinNode<T> Left, BinNode<T> Right)
    {
        value = Value;
        this.Left = Left;
        this.Right = Right;
    }
    public void SetValue(T info)
    {
        Value = info;
    }

    public T GetValue()
    {
        return Value;
    }
    public void SetRight(T info)
    {
        Right.SetValue(info);
    }
    public void SetLeft(T info)
    {
        Left.SetValue(info);
    }
    public BinNode<T> GetRight()
    {
        return Right;
    }

    public BinNode<T> GetLeft()
    {
        return Left;
    }
    public void SetRight(BinNode<T> info)
    {
        Right = info;
    }
    public void SetLeft(BinNode<T> info)
    {
        Left = info;
    }
}

class Program
{
    public static bool Contains(BinNode<int> root, int value)
    {
        if (root == null) { return false; }
        if (root.GetValue() == value) { return true; }
        if (root.GetValue() < value) { return Contains(root.GetRight(), value); }
        if (root.GetValue() > value) { return Contains(root.GetLeft(), value); }
        return false;
    }
}