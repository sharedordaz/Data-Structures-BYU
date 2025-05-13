public static class Arrays
{

 /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // PLAN:
        // Step 1: Create a new array of type double with size equal to 'length'
        // Step 2: Use a for loop that goes from 0 to length - 1
        // Step 3: For each index i in the loop, set the value of the array at that index to (number * (i + 1))
        //         This is because the first multiple is number * 1, not number * 0
        // Step 4: After the loop, return the array

        double[] multiples = new double[length]; // Step 1

        for (int i = 0; i < length; i++) // Step 2
        {
            multiples[i] = number * (i + 1); // Step 3
        }

        return multiples; // Step 4
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    /// <returns>Nothing</returns>
    public static void RotateListRight(List<int> data, int amount)
    {
        // PLAN:
        // Step 1: Identify the last 'amount' elements in the list.
        //         These are the elements that will move to the front.
        //         Use GetRange(startIndex, count) where startIndex = data.Count - amount
        // Step 2: Remove those last 'amount' elements from the end of the list.
        //         Use RemoveRange(startIndex, count)
        // Step 3: Insert the previously saved elements at the beginning of the list.
        //         Use InsertRange(0, elementsToMove)
        // Step 4: The original list 'data' is now modified to reflect the rotation.

        // Step 1
        List<int> tail = data.GetRange(data.Count - amount, amount);

        // Step 2
        data.RemoveRange(data.Count - amount, amount);

        // Step 3
        data.InsertRange(0, tail);
    }

}


