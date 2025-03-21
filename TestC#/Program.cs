class Program
{
    static void Main()
    {
        string str = "Nikita Patil !";
        string match = "Patil";
        string[] arr = str.Split(" ");
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Equals("") || arr[i].Equals(" "))
            {
                Console.WriteLine("Enter Valid Input");
            }
            else if (arr[i].Equals(match))
            {
                arr[i] = arr[i].ToUpper();
            }
            else if (arr[i].Any(ch => !char.IsLetterOrDigit(ch)))
            {
                arr[i] = " ";
            }
        }
        string result = string.Join(" ", arr);
        Console.WriteLine(result);
    }
}