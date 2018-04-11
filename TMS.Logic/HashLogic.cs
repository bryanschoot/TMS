namespace TMS.Logic
{
    using System;
    using System.Text;

    public class HashLogic
    {
        /// <summary>
        /// The size.
        /// </summary>
        private int Size = 11;

        /// <summary>
        /// The generate salt.
        /// </summary>
        /// <param name="size">
        /// The size.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GenerateSalt()
        {
            try
            {
                var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
                var buff = new byte[this.Size];
                rng.GetBytes(buff);

                return Convert.ToBase64String(buff);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }

        /// <summary>
        /// The generate sha 256.
        /// </summary>
        /// <param name="input">
        /// The input.
        /// </param>
        /// <param name="salt">
        /// The salt.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GenerateSha256(string input, string salt)
        {
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
                System.Security.Cryptography.SHA256Managed sha256Hash = new System.Security.Cryptography.SHA256Managed();
                byte[] hash = sha256Hash.ComputeHash(bytes);

                return Convert.ToBase64String(hash);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }
    }
}