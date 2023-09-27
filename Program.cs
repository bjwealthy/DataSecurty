
class Program{       
    static void Main(string[] args){
        
        Console.WriteLine("What is your name?");
        
        var name = Console.ReadLine();

        EncryptDecrypt encDec = new EncryptDecrypt();

        string strIn64 = encDec.encryptInot64(name);

        string byteInString = encDec.decryptFrom64(strIn64);

        Console.WriteLine("Encrypted Date: "+ strIn64);

        Console.WriteLine("Decrypted Data: "+ byteInString);
    }   
}
