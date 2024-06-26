namespace We_re_so_back
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // let's imagin we have a friend group of 4
            int friends = 4;

            // then that group had 2 more friends
            friends += 2;

            // then one friend left for to work in an other city
            friends -= 1;

            // then our group made a new friends wihch is a group of the same amount of them
            friends *= 2;

            // but every good story has a sad side and the group splet to half
            friends /= 2;

            Console.WriteLine("Our frinds group contins " + friends + " Friends");


        }
    }
}
