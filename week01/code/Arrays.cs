public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
       public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1
    
        // Step 1: I will start by creating an empty array with the size I want.
        double[] result = new double[length];
    
        // Step 2: Then, I will go through the array one spot at a time.
        for (int i = 0; i < length; i++)
        {
            // Step 3: I will put the multiple of the number in the current spot.
            // I will multiply the number by (i + 1) to get the first, second, third multiple, and so on.
            result[i] = number * (i + 1);
        }
    
        // Step 4: Finally, I will return the completed array of multiples.
        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// For example, if the data is List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  
    /// The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
      public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2
    
        // Step 1: I will start by identifying the last 'amount' of elements in the list.
        // These elements need to be moved to the front of the list.
        // I will use the GetRange method to extract these elements.
        List<int> lastPart = data.GetRange(data.Count - amount, amount);
    
        // Step 2: Next, I will remove these identified elements from their current position.
        // This is done to make space for them at the beginning of the list.
        // I will use the RemoveRange method to achieve this.
        data.RemoveRange(data.Count - amount, amount);
    
        // Step 3: Finally, I will insert the removed elements at the beginning of the list.
        // This will complete the rotation of the list to the right by the specified amount.
        // I will use the InsertRange method to place the elements at the start.
        data.InsertRange(0, lastPart);
    }
}
