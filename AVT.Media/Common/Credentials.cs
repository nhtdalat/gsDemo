namespace AVT.Media.Common
{
    /// <summary>
    /// Authentication credentials.
    /// </summary>
    public class Credentials
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Credentials()
        {

        }
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="username">Credentials username</param>
        /// <param name="password">Credentials password</param>
        public Credentials(string username, string password)
        {
            Username = username;
            Password = password;
        }

        /// <summary>
        /// Gets the username.
        /// </summary>
        public string Username { get; }

        /// <summary>
        /// Gets the password
        /// </summary>
        public string Password { get; }
    }
}
