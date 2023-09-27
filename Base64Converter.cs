public class Base64Converter{
    public string encode64(string nameStr){

      byte[] toEncodeAsBytes

            = System.Text.ASCIIEncoding.ASCII.GetBytes(nameStr);

      string final

            = System.Convert.ToBase64String(toEncodeAsBytes);

      return final;

    }
}