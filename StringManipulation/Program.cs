using System.Text;
using System.Text.RegularExpressions;

class Program

{

    static string ConvertCharToUpper1(string input, char target)
    {
        StringBuilder sb = new StringBuilder();

        int count = 0;

        foreach(char ch in input){
            if(ch == target && count < 1){
                sb.Append("Banana"); // str += "Banana";
                count+=1;
            } else{
                sb.Append(ch);
            }
        }

        return sb.ToString();
    }
    static string ConvertCharToUpper(string input, char target)
    {
        char upperTarget = char.ToUpper(target);
        char lowerTarget = char.ToLower(target);
        
        char[] result = input.ToCharArray();
        
        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] == lowerTarget || result[i] == upperTarget)
            {
                result[i] = upperTarget;
            }
        }
        
        return new string(result);
    }
    
    static void Main()
    {
        string input = "Apple";
        char targetChar = 'p';
        
        string output = ConvertCharToUpper1(input, targetChar);
        Console.WriteLine(output);
    }
    // static void Main()
    // {
    //     string str = "Nikita Patil !";
    //     string match = "Patil";

    //     if (string.IsNullOrEmpty(match))
    //     {
    //         Console.WriteLine("Enter Valid String");
    //         return;
    //     }

    //     if (!str.Contains(match))
    //     {
    //         Console.WriteLine("Word not found");
    //         return;
    //     }

    //     str = Regex.Replace(str, @"[^a-zA-Z0-9\s]", " ");
    //     str = Regex.Replace(str, match, match.ToUpper());

    //     Console.WriteLine(str);


        
    // }
}
