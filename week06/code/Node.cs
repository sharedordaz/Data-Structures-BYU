public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // Start Problem 1
        // Check if the value is less than the current node's data
        if (value == Data)
        {
            // Value already exists in the tree, do not insert duplicates
            return;
        }
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // Check if the current node contains the value
    if (value == Data)
    {
        return true;
    }

    // Recursively search in the left subtree if the value is less than the current node's data
    if (value < Data && Left is not null)
    {
        return Left.Contains(value);
    }

    // Recursively search in the right subtree if the value is greater than the current node's data
    if (value > Data && Right is not null)
    {
        return Right.Contains(value);
    }

    // If the value is not found in the current node or its subtrees
    return false;
    }

public int GetHeight()
{
    // Recursively calculate the height of the left and right subtrees
    int leftHeight = Left?.GetHeight() ?? 0;
    int rightHeight = Right?.GetHeight() ?? 0;

    // The height of the current node is 1 plus the maximum height of its subtrees
    return 1 + Math.Max(leftHeight, rightHeight);
}
}