using System.Security.Cryptography;

namespace _420DA3_A24_Projet.Business.Services;



public class PasswordService {
    private const int saltSize = 16; 
    private const int keySize = 32; 
    private const int cryptographicIterations = 100000; 
    private const char hashSegmentDelimiter = ':'; 
    private static readonly HashAlgorithmName cryptographicAlgorithm = HashAlgorithmName.SHA256; 

    private static PasswordService? instance;

    private PasswordService() { }

    public static PasswordService GetInstance() {
        instance ??= new PasswordService();
        return instance;
    }


    
    /// Recoit le mot de passe en clair, non-encrypté, dans <paramref name="motDePasseNonEncrypte"/>.
    /// Retourne le mot de passe hashé sous forme de <see cref="string"/>.
    /// <param name="motDePasseNonEncrypte">Le mot de passe en clair, non-encrypté.</param>
    
    public string HashPassword(string motDePasseNonEncrypte) {
        byte[] salt = RandomNumberGenerator.GetBytes(saltSize);
        byte[] key = Rfc2898DeriveBytes.Pbkdf2(
            motDePasseNonEncrypte,
            salt,
            cryptographicIterations,
            cryptographicAlgorithm,
            keySize
        );
        return string.Join(
            hashSegmentDelimiter,
            Convert.ToHexString(key),
            Convert.ToHexString(salt),
            cryptographicIterations,
            cryptographicAlgorithm
        );
    }

    
    /// Recoit le mot de passe en clair, non-encrypté, dans <paramref name="motDePasseNonEncrypte"/> tel qu'entré
    /// dans la fenêtre d'authentification (login) par l'utilisateur.<br/>
    /// Recoit le hash du mot de passe de l'utilisateur dans <paramref name="motDePasseNonEncrypte"/> tel que 
    /// trouvé pour l'utilisateur correspondant dans la base de données.<br/>
    /// Retourne <see langword="true"/> si le mot de passe en clair concorde (est valide), <see langword="false"/> sinon.
    /// </remarks>
    /// <param name="motDePasseNonEncrypte"></param>
    /// <param name="hashDuMotDePasseDansLaBdD"></param>
    /// <returns>True si le mot de passe est valide.</returns>
    public bool ValidatePassword(string motDePasseNonEncrypte, string hashDuMotDePasseDansLaBdD) {
        string[] segments = hashDuMotDePasseDansLaBdD.Split(hashSegmentDelimiter);
        byte[] key = Convert.FromHexString(segments[0]);
        byte[] salt = Convert.FromHexString(segments[1]);
        int iterations = int.Parse(segments[2]);
        HashAlgorithmName algorithm = new HashAlgorithmName(segments[3]);
        byte[] inputSecretKey = Rfc2898DeriveBytes.Pbkdf2(
            motDePasseNonEncrypte,
            salt,
            iterations,
            algorithm,
            key.Length
        );
        return key.SequenceEqual(inputSecretKey);
    }
}
