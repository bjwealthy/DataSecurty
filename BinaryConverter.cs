public class BinaryConverter{
    public string StringToBinary(string str){
        string binaryString = ""; 
        foreach (char c in str){
            string binary = Convert.ToString(c, 2).PadLeft(8, '0');
            binaryString += binary + " ";
        }

        return binaryString.Trim();
    }
}
