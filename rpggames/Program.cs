namespace rpggames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random=new Random();
            var player=new Player("essonani",100,10,false);
            var enemy=new Enemy("turtle",50,5,false);
            Console.WriteLine("enter \n 1 to attack\n2 to h3al");
            var playerInput=Console.ReadLine();
            while(!player.IsDead && !enemy.IsDead)
            {
                switch(playerInput)
                {
                    case "1":
                        Console.WriteLine("you chosen to atack");
                        enemy.GetsHits(random.Next(5,10)); break;
                        player.GetsHits(random.Next(1,5));break;
                        case "2":
                       player.GetsHealth(random.Next(5,10));break;
                        default: Console.WriteLine("choose other option");break;
                }
            }
        }
    }
}