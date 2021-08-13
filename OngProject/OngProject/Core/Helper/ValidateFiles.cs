using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.Helper
{
    public class ValidateFiles
    {
     //   private readonly IFileSignature _fileSignature;
      /*  public static string GetImageExtensionFromFile(byte[] file)
        {
            MemoryStream stream = new MemoryStream(file);
            using (var reader = new BinaryReader(stream))
            {
                Dictionary<string, List<byte[]>>.KeyCollection keyColl = _fileSignature.Keys;
                foreach (var ext in keyColl)
                {
                    var signatures = _fileSignature[ext];
                    var headerBytes = reader.ReadBytes(signatures.Max(m => m.Length));
                    bool verification = signatures.Any(signature => headerBytes.Take(signature.Length).SequenceEqual(signature));
                    if (verification)
                    {
                        reader.Close();
                        stream.Close();
                        return ext;
                    }
                    stream.Seek(0, SeekOrigin.Begin);
                }
            }
            stream.Close();
            throw new InvalidDataException();
        }
      */
        public static bool ValidateImage(IFormFile image)
        {
            var postedFileExtension = Path.GetExtension(image.FileName);
            if (!string.Equals(postedFileExtension, ".jpg", StringComparison.OrdinalIgnoreCase)
                && !string.Equals(postedFileExtension, ".png", StringComparison.OrdinalIgnoreCase)
                && !string.Equals(postedFileExtension, ".jpeg", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
            return true;
        }
    }
}