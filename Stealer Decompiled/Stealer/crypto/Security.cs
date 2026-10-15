using System;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;

namespace crypto
{
	// Token: 0x020004B7 RID: 1207
	public class Security
	{
		// Token: 0x060023AA RID: 9130 RVA: 0x000A99C0 File Offset: 0x000A7BC0
		public static string ComputeHash(string text, string salt)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			Sha512Digest sha512Digest = new Sha512Digest();
			Pkcs5S2ParametersGenerator pkcs5S2ParametersGenerator = new Pkcs5S2ParametersGenerator(sha512Digest);
			pkcs5S2ParametersGenerator.Init(bytes, Base64.Decode(salt), 2048);
			return Base64.ToBase64String(((KeyParameter)pkcs5S2ParametersGenerator.GenerateDerivedParameters(sha512Digest.GetDigestSize() * 8)).GetKey());
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x000A9A1C File Offset: 0x000A7C1C
		public static string Decrypt(string cipherText, string key, string iv)
		{
			IBufferedCipher bufferedCipher = Security.CreateCipher(false, key, iv);
			byte[] array = bufferedCipher.DoFinal(Base64.Decode(cipherText));
			return Encoding.UTF8.GetString(array, 0, array.Length);
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x000A9A54 File Offset: 0x000A7C54
		public static string Encrypt(string plainText, string key, string iv)
		{
			IBufferedCipher bufferedCipher = Security.CreateCipher(true, key, iv);
			return Base64.ToBase64String(bufferedCipher.DoFinal(Encoding.UTF8.GetBytes(plainText)));
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x000A9A84 File Offset: 0x000A7C84
		public static string GenerateText(int size)
		{
			byte[] array = new byte[size];
			SecureRandom instance = SecureRandom.GetInstance("SHA256PRNG", true);
			instance.NextBytes(array);
			return Base64.ToBase64String(array);
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x000A9AB8 File Offset: 0x000A7CB8
		private static IBufferedCipher CreateCipher(bool isEncryption, string key, string iv)
		{
			IBufferedCipher bufferedCipher = new PaddedBufferedBlockCipher(new CbcBlockCipher(new RijndaelEngine()), new ISO10126d2Padding());
			KeyParameter keyParameter = new KeyParameter(Base64.Decode(key));
			ICipherParameters parameters = (iv == null || iv.Length < 1) ? keyParameter : new ParametersWithIV(keyParameter, Base64.Decode(iv));
			bufferedCipher.Init(isEncryption, parameters);
			return bufferedCipher;
		}
	}
}
