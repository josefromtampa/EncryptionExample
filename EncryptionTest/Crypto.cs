using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
class ManagedAesSample
{
  //public static void Main()
  //{
  //  Console.WriteLine("Enter text that needs to be encrypted..");
  //  string data = Console.ReadLine();
  //  EncryptAesManaged(data);
  //  Console.ReadLine();
  //}
  
  public static string EncryptToString(string plainText, string key)
  {
    string enc = "";
    using (AesManaged aes = new AesManaged())
    {
      // Encrypt string    
      //aes.Key = SHA256.Create().ComputeHash(System.Text.Encoding.UTF8.GetBytes(key));
      aes.Key = System.Text.Encoding.ASCII.GetBytes(key);
      //aes.IV = new byte[16] { 1, 1, 1, 1 , 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1};
      aes.IV = new byte[16];
      // aes.IV = aes.Key.Skip(0).Take(16).ToArray();
      byte[] encrypted = Encrypt(plainText, aes.Key, aes.IV);
      enc = Convert.ToBase64String(encrypted);

    }
    return enc;
  }
  public static string DecryptFromString(string cipherText, string key)
  {
    string decrypted = "";
    using (AesManaged aes = new AesManaged())
    {
      aes.GenerateKey();
      //aes.Key = SHA256.Create().ComputeHash(System.Text.Encoding.UTF8.GetBytes(key));
      aes.Mode = CipherMode.ECB;
      aes.Key = System.Text.Encoding.ASCII.GetBytes(key); // System.Text.Encoding.UTF8.GetBytes(key.Substring(0, aes.Key.Length));
      // aes.IV = new byte[16] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
      aes.IV = new byte[16];


      // aes.IV = aes.Key.Skip(0).Take(16).ToArray();
      byte[] dec = Convert.FromBase64String(cipherText);

      ////
      ///
      string keyback = Convert.ToBase64String(aes.Key);
      byte[] keyBytesback = Convert.FromBase64String(keyback);
      ////


      string plaintext = null;

      // Create a decryptor    
      var decryptor = aes.CreateDecryptor(keyBytesback, new byte[16]);
      byte[] decryptedBytes = decryptor.TransformFinalBlock(dec, 0, dec.Length);

      string decstr = System.Text.Encoding.UTF8.GetString(decryptedBytes);
      return decstr;
    }

    //// Create the streams used for decryption.    
    //using (MemoryStream ms = new MemoryStream(dec))
    //  {
    //    // Create crypto stream    
    //    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
    //    {
    //      // Read crypto stream    
    //      using (StreamReader reader = new StreamReader(cs))
    //        plaintext = reader.ReadToEnd();
    //    }
    //  }
    //}
    //return decrypted;
  }
  public static byte[] Encrypt(string plainText, byte[] Key, byte[] IV)
  {
    byte[] encrypted;
    // Create a new AesManaged.    
    using (AesManaged aes = new AesManaged())
    {
      // Create encryptor    
      ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);
      // Create MemoryStream    
      using (MemoryStream ms = new MemoryStream())
      {
        // Create crypto stream using the CryptoStream class. This class is the key to encryption    
        // and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream    
        // to encrypt    
        using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
        {
          // Create StreamWriter and write data to a stream    
          using (StreamWriter sw = new StreamWriter(cs))
            sw.Write(plainText);
          encrypted = ms.ToArray();
        }
      }
    }
    // Return encrypted data    
    return encrypted;
  }
  public static string Decrypt(byte[] cipherText, byte[] Key, byte[] IV)
  {
    string plaintext = null;
    // Create AesManaged    
    using (AesManaged aes = new AesManaged())
    {
      // Create a decryptor    
      ICryptoTransform decryptor = aes.CreateDecryptor(Key, IV);
      // Create the streams used for decryption.    
      using (MemoryStream ms = new MemoryStream(cipherText))
      {
        // Create crypto stream    
        using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
        {
          // Read crypto stream    
          using (StreamReader reader = new StreamReader(cs))
            plaintext = reader.ReadToEnd();
        }
      }
    }
    return plaintext;
  }
}