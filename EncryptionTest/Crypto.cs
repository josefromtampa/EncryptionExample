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
  private static string EncryptAesManaged(string raw)
  {
    string decrypted = "";

    try
    {
      // Create Aes that generates a new key and initialization vector (IV).    
      // Same key must be used in encryption and decryption    
      using (AesManaged aes = new AesManaged())
      {
        // Encrypt string    
        byte[] encrypted = Encrypt(raw, aes.Key, aes.IV);
        string enc = Convert.ToBase64String(encrypted);
        // Print encrypted string    
        Console.WriteLine($"Encrypted data: {System.Text.Encoding.UTF8.GetString(encrypted)}");
        // Decrypt the bytes to a string.    
        byte[] dec = Convert.FromBase64String(enc);
        decrypted = Decrypt(dec, aes.Key, aes.IV);
        // Print decrypted string. It should be same as raw data    
        Console.WriteLine($"Decrypted data: {decrypted}");
      }
    }
    catch (Exception exp)
    {
     // Console.WriteLine(exp.Message);
    }
    //Console.ReadKey();
    return decrypted;

  }
  public static string EncryptToString(string plainText, string key)
  {
    string enc = "";
    using (AesManaged aes = new AesManaged())
    {
      // Encrypt string    
      aes.Key = SHA256.Create().ComputeHash(System.Text.Encoding.UTF8.GetBytes(key));
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
      aes.Key = SHA256.Create().ComputeHash(System.Text.Encoding.UTF8.GetBytes(key));
      // aes.IV = new byte[16] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
      aes.IV = new byte[16];
      // aes.IV = aes.Key.Skip(0).Take(16).ToArray();
      byte[] dec = Convert.FromBase64String(cipherText);
      decrypted = Decrypt(dec, aes.Key, aes.IV);

    }
    return decrypted;
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