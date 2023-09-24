
class Program{       
    static void Main(string[] args){
            //step 1:
        Console.WriteLine("What is your name?");
        
        var name = Console.ReadLine();

        BinaryConverter bc = new BinaryConverter();

        string nameInBin = bc.StringToBinary(name);

        Console.WriteLine(nameInBin);
    }
    
        
}
