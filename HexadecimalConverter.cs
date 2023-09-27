public class HexadecimalConverter{
    public string StringToHex(string str){
        string hexString = "";
        
        foreach (char c in str){
            string hex = Convert.ToString(c,16).PadLeft(8, '0');
            hexString += hex + " ";
        }

        return hexString.Trim();
    }
}
