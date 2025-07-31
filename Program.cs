namespace PNZ
{
    public class PNZ

    {
        int num;
        public PNZ()
        {
            num = 2;
        }
        public PNZ(int num)
        {
            this.num = num;
        }
        public void check()
        {
            if (num == 0)
            {
                Console.WriteLine("the number is zero.");
            }
            else if (num > 0)
            {
                Console.WriteLine("the number is positive.");
            }
            else
            {
                Console.WriteLine("the number is negative.");
            }
        }
    }
}
                
