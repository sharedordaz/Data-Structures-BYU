using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: A basic program where the user can assign priorities to items in a queue.
    // Expected Result: 10  
    // Defect(s) Found: 0
    public void TestPriorityQueue_1()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("low", 1);
        queue.Enqueue("medium", 5);
        queue.Enqueue("high", 10);

        //Check if the element with a higher priority is dequeued first
        Assert.AreEqual("high", queue.Dequeue());
    }

    [TestMethod]
    // Scenario: The user adds two items with the same priority to the queue. 
    // Expected Result: The second item added with the same priority is returned first.
    // Defect(s) Found: 0
    public void TestPriorityQueue_2()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("first", 10);
        queue.Enqueue("second", 10); // "second" has the same priority as "first"

        // It should return "second" first since it was added later
        Assert.AreEqual("second", queue.Dequeue());
    }


    // Add more test cases as needed below.
    public void TestPriorityQueue_EmptyDequeue()
    {
        var queue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => queue.Dequeue());
    }

    [TestMethod]
    public void TestPriorityQueue_MultipleSamePriority()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("A", 5);
        queue.Enqueue("B", 5);
        queue.Enqueue("C", 5);

        // "C" should be dequeued first, then "B", then "A"
        Assert.AreEqual("C", queue.Dequeue());
        Assert.AreEqual("B", queue.Dequeue());
        Assert.AreEqual("A", queue.Dequeue());
    }

[TestMethod]
public void TestPriorityQueue_ToString()
{
    var queue = new PriorityQueue();
    queue.Enqueue("A", 3);
    queue.Enqueue("B", 1);
    queue.Enqueue("C", 2);

    // Check the string representation of the queue
    Assert.AreEqual("[A (Pri:3), B (Pri:1), C (Pri:2)]", queue.ToString());
}

}