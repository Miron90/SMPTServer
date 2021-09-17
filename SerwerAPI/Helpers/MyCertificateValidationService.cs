using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SerwerAPI.Helpers
{
    public class MyCertificateValidationService
    {
        public bool ValidateCertificate(X509Certificate2 clientCertificate)
        {
            // add your child certificate thumbnail
            string[] allowedthumbprints = { "a5263c7831a264848b8f16e13269f47af9d1f5da","D533CA46EF84B401B980D8C40E57E5C4ABA0D831", "87a6e47a962c0e80a59517691ffa1d0500e3e548", "78a6e47a962c0e80a59517691ffa1d0500e3e548" };
            if (allowedthumbprints.Contains(clientCertificate.Thumbprint))
            {
                return true;
            }

            return false;
        }
    }
}
