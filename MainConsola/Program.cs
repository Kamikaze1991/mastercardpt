using Mastercard.Developer.ClientEncryption.Core.Encryption;
using Mastercard.Developer.ClientEncryption.Core.Utils;
using Mastercard.Developer.OAuth1Signer.Core.Utils;
using Pbo.App.MastercardApi.Client.Client;
using static Mastercard.Developer.ClientEncryption.Core.Encryption.FieldLevelEncryptionConfig;
using System.Security.Cryptography.X509Certificates;
using Pbo.App.MastercardApi.Client.Api;
using Pbo.App.MastercardApi.Client.Model;

internal class Program
{
    private const string ConsumerKey = "FqEiSwF90tXB7_THzHCJ_YRyzIdQE13MR9IX4CCr0b6dfd08!dcb45a1364a14dc4a87bf64331db79d10000000000000000";
    private const string SigningKeyAlias = "ProdubancoSandbox";
    private const string SigningKeyPassword = "ProdubancoSandbox123";
    private const string SigningKeyPkcs12FilePath = "c:\\certificados\\produbancosandbox-sandbox.p12";
    private const string BasePath = "https://sandbox.api.mastercard.com/mdes/";

    private static ApiClient _client;

    // Encryption keys to be used in Sandbox (see: https://mstr.cd/2T53Ltv)
    private const string EncryptionCertificateFilePath = "c:\\certificados\\pwr.crt";
    private const string DecryptionKeyFilePath = "c:\\certificados\\pwr.key";


    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var signingKey = AuthenticationUtils.LoadSigningKey(SigningKeyPkcs12FilePath, SigningKeyAlias,
                SigningKeyPassword, X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.Exportable);
        var encryptionCertificate = EncryptionUtils.LoadEncryptionCertificate(EncryptionCertificateFilePath);
        var decryptionKey = EncryptionUtils.LoadDecryptionKey(DecryptionKeyFilePath);

        var config = FieldLevelEncryptionConfigBuilder.AFieldLevelEncryptionConfig()
            .WithEncryptionPath("$", "$")
            .WithDecryptionPath("$", "$")
            .WithEncryptionCertificate(encryptionCertificate)
            .WithDecryptionKey(decryptionKey)
            .WithOaepPaddingDigestAlgorithm("SHA-512")
            .WithEncryptedValueFieldName("encryptedData")
            .WithEncryptedKeyFieldName("encryptedKey")
            .WithIvFieldName("iv")
            .WithOaepPaddingDigestAlgorithmFieldName("oaepHashingAlgorithm")
            .WithEncryptionCertificateFingerprintFieldName("publicKeyFingerprint")
            .WithValueEncoding(FieldValueEncoding.Hex)
            .Build();

        _client = new ApiClient(signingKey, BasePath, ConsumerKey, config);

        var tokenizeApi = new UserApi { Client = _client };
        UserEnrollRequest usuario = new UserEnrollRequest();
        UserAddress direccion = new UserAddress();
        AccountBase cuenta = new AccountBase();
        cuenta.Status = "activa";
        cuenta.AccountId = "1312312";
        cuenta.AccruePoints = true;
        cuenta.ProgramIdentifier = "3123";
        cuenta.AccountIdType = "koko";
        cuenta.EnrollmentDate = DateTime.Now;
        cuenta.HouseholdToken = "2123123123123";
        cuenta.OpenDate = DateTime.Now;
        cuenta.PrimaryAccount = true;
        cuenta.ProductCode = "13123";

        direccion.AddressLine1 = "prueba";
        direccion.AddressLine2 = "prueba";
        direccion.AddressLine3 = "prueba";
        direccion.AddressLine4 = "prueba";
        direccion.City = "manta";
        direccion.CountryCode = "EC";
        direccion.PostalCode= "12345";
        direccion.StateProvinceCode = "12345";
        
        usuario.Address = direccion;
        usuario.AcceptEmails = true;
        usuario.EmailAddress = "lolte@gmail.com";
        usuario.FirstName = "luis";
        usuario.LastName = "borrer";
        usuario.AcceptSms = true;
        usuario.AcceptPromotionalInfo = true;
        usuario.Account = cuenta;


      
        var response = tokenizeApi.MrsUsersPost(usuario);
        

    }

  
}