class Program
{
    static void Main(string[] args)
    {

        //The FirstOrDefault methods returns the first element that satisfies the given condition, if there is no element that 
        //meets the condition it returns a default value.
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var firstOrDefaultValue=numbers.FirstOrDefault(x => x %2==0 && x>4);
        Console.WriteLine($"firstOrDefaultValue :{firstOrDefaultValue}");

        try
        {
            var singleOrDefualtValue = numbers.SingleOrDefault(x => x % 2 == 0 && x > 4);
            Console.WriteLine($"SingleOrDefault :{singleOrDefualtValue}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error : {e.Message}");

        }
        //in case of SingleOrDefault method, the methods returns a value if only if there is one element satisfying the condtion, or default 
        //value if there is no element meeting the given condition.However, unlike FirstOrDefault method, it throws an exception if there 
        //are more than one element satisfying the given condition, such as in this example, where there are more than a number which are 
        //even and greater than 4.Therefore, the chosen method should be SingleOrDefault method.
    }
}
