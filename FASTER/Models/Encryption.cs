﻿using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace FASTER.Models
{
    public class Encryption
    {
        private static readonly TripleDESCryptoServiceProvider TripleDes = new TripleDESCryptoServiceProvider();
        private static Encryption _instance;


        public static Encryption Instance => _instance ??= new Encryption();

        private static byte[] TruncateHash(string key, int length)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            // Hash the key.
            byte[] keyBytes = System.Text.Encoding.Unicode.GetBytes(key);
            byte[] hash = sha1.ComputeHash(keyBytes);
            var oldHash = hash;
            hash = new byte[length - 1 + 1];

            // Truncate or pad the hash.
            Array.Copy(oldHash, hash, Math.Min(length - 1 + 1, oldHash.Length));
            return hash;
        }

        private Encryption()
        {
            // Initialize the crypto provider.
            string key = Environment.UserName + SystemSerialNumber();
            TripleDes.Key = TruncateHash(key, TripleDes.KeySize / 8);
            TripleDes.IV = TruncateHash("", TripleDes.BlockSize / 8);
        }

        public string EncryptData(string plaintext)
        {
            try
            {
                // Convert the plaintext string to a byte array.
                byte[] plaintextBytes = System.Text.Encoding.Unicode.GetBytes(plaintext);

                // Create the stream.
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                // Create the encoder to write to the stream.
                CryptoStream encStream = new CryptoStream(ms, TripleDes.CreateEncryptor(), CryptoStreamMode.Write);

                // Use the crypto stream to write the byte array to the stream.
                encStream.Write(plaintextBytes, 0, plaintextBytes.Length);
                encStream.FlushFinalBlock();

                // Convert the encrypted stream to a printable string.
                return Convert.ToBase64String(ms.ToArray());
            }
            catch
            {
                return null;
            }
        }

        public string DecryptData(string encryptedtext)
        {
            try
            {
                // Convert the encrypted text string to a byte array.
                byte[] encryptedBytes = Convert.FromBase64String(encryptedtext);

                // Create the stream.
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                // Create the decoder to write to the stream.
                CryptoStream decStream = new CryptoStream(ms, TripleDes.CreateDecryptor(), CryptoStreamMode.Write);

                // Use the crypto stream to write the byte array to the stream.
                decStream.Write(encryptedBytes, 0, encryptedBytes.Length);
                decStream.FlushFinalBlock();

                // Convert the plaintext stream to a string.
                return System.Text.Encoding.Unicode.GetString(ms.ToArray());
            }
            catch
            {
                return null;
            }
        }

        private static string SystemSerialNumber()
        {
            //var sn = Windows.System.Profile.SystemManufacturers.SmbiosInformation.SerialNumber;

            try
            {
                var powershell = Process.Start(new ProcessStartInfo
                {
                    UseShellExecute = false,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    FileName = "powershell",
                    Arguments = "Get-WmiObject Win32_BaseBoard | select SerialNumber"
                });
                powershell?.WaitForExit();
                var output = powershell?.StandardOutput.ReadToEnd();
                return output?.Replace("\r", "").Split('\n')[3];
                //ManagementObjectSearcher searcher =
                //    new ManagementObjectSearcher("root\\CIMV2",
                //                                 "SELECT * FROM Win32_BaseBoard");

                //foreach (var o in searcher.Get())
                //{
                //    var queryObj = (ManagementObject) o;
                //    return $"{queryObj["SerialNumber"]}";
                //}
            }
            catch (Exception) { return "EXCEPTION_ON_QUERY"; }
            
        }
    }
}
