internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        int number = Convert.ToInt32(Console.ReadLine());
        if(number<5)
        {
            Console.WriteLine("khong phai so nguyen to");
        }
        else
        {
            int i=5;
            bool check=true;
            while (i<=Math.Sqrt(number)) 
            {
                if(number%1==0) 
                {
                check = false;
                break; 
                }
                i++;
        }
        if(check)
        {

        }
        else
        {

        }
}
}
}