public class EncryptDecrypt{
    public string encryptInot64(string someStr){

      byte[] encrypted

            = System.Text.ASCIIEncoding.ASCII.GetBytes(someStr);

      string encryptedIntoString

            = System.Convert.ToBase64String(encrypted);

      return encryptedIntoString;
    }

    public string decryptFrom64(string someByte){

      byte[] decrypted

          = System.Convert.FromBase64String(someByte);

      string decryptedIntoString =

         System.Text.ASCIIEncoding.ASCII.GetString(decrypted);

      return decryptedIntoString;

    }
}