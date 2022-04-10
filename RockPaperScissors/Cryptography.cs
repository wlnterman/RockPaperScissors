using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace RockPaperScissors
{
    class Cryptography
    {
        public byte[] GenerateCryptoKey()
        {
            byte[] cryptoKey = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(cryptoKey);
            }
            return cryptoKey;
        }

        public byte[] GenerateHMAC(byte[] key, byte[] ComputerMove )
        {
            // Initialize the keyed hash object.
            using (HMACSHA256 hmac = new HMACSHA256(key))
            {
                // Compute the hash of the input file.
                byte[] hashValue = hmac.ComputeHash(ComputerMove);
                return hashValue;
            }
        }
    }
}
