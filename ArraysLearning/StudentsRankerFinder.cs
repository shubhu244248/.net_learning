class StudentsRankerFinder
{

    public static int[] FindStudentsRank(int[,] stdMarks)
    {
        int noStd = stdMarks.GetLength(0);
        int sum = 0;
        int[] totalMarks = new int[noStd];
        int[] ranks = new int[noStd];

        for (int i = 0; i < noStd; i++)
        {
            for (int j = 0; j < 5; j++) 
            {
                sum += stdMarks[i, j];
            }
            totalMarks[i] = sum;
        }

        for (int i = 0; i < noStd; i++)
        {
            int rank = 1;
            for (int j = 0; j < noStd; j++)
            {
                if (totalMarks[j] > totalMarks[i])
                {
                    rank++; 
                }
            }
            ranks[i] = rank;
        }
        return ranks;
    }
    public static void Main(string[] args)
    {

        int noStd = int.Parse(Console.ReadLine());

        int[,] stdMakrs = new int[noStd, 5];

        for (int i = 0; i < noStd; i++)
        {
            i += 1;
            for (int j = 0; j < 5; j++)
            {
                stdMakrs[i, j] = int.Parse(Console.ReadLine());
            }
        }


        int[] result = FindStudentsRank(stdMakrs);
        foreach (int rank in result)
        {
            Console.WriteLine(rank);
        }

    }
} 