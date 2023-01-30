namespace Flows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //JumpForward();
            JumpBack();


        }

        private static void JumpBack()
        {
            int i = 0;
            // Je weet hoe vaak je iets moet uitvoeren.
            for (i = 0; i < 20; i++)
            {
                //Console.WriteLine(i);
            }

            //Console.WriteLine(i);

            // 0 of meer keer uitgevoerd.
            while(true)
            {

            }

            // Een of meer keer uitgevoerd. (User input)
            do
            {
            } 
            while(true);  
        }

        private static void JumpForward()
        {
            int age = 10;

            switch(age)
            {
                case 0:
                case 1:
                    Console.WriteLine("Eeen");
                    break;
                case 2:
                    Console.WriteLine("Tweee");
                    break;
                default:
                    Console.WriteLine("Whatever");
                    break;
            }


            // Range checks
            if(true)
            {

            }
            //else if()
            //{

            //}

        }
    }
}