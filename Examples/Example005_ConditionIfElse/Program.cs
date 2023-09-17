class Program{
    static void Main(string[] args){
        Console.Write("Input user name: ");
        string username = Console.ReadLine();

        if(username.ToLower() == "Mary"){
            Console.WriteLine("Hooray, this is Mary!!!");
        }
        else{
            Console.Write("Hello, ");
            Console.Write(username);
            Console.WriteLine("!!!");
        }

    }
}