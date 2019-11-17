using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    public class HashService
    {
        public virtual PasswordVerificationResult VerifyHashedPassword(TUser user, string hashedPassword, string providedPassword)
        {
            // Convert the stored Base64 password to bytes
            byte[] decodedHashedPassword = Convert.FromBase64String(hashedPassword);

            // The first byte indicates the format of the stored hash
            switch (decodedHashedPassword[0])
            {
                case 0x00:
                    if (VerifyHashedPasswordV2(decodedHashedPassword, providedPassword))
                    {
                        // This is an old password hash format - the caller needs to rehash if we're not running in an older compat mode.
                        return (_compatibilityMode == PasswordHasherCompatibilityMode.IdentityV3)
                            ? PasswordVerificationResult.SuccessRehashNeeded
                            : PasswordVerificationResult.Success;
                    }
                    else
                    {
                        return PasswordVerificationResult.Failed;
                    }

                case 0x01:
                    if (VerifyHashedPasswordV3(decodedHashedPassword, providedPassword))
                    {
                        return PasswordVerificationResult.Success;
                    }
                    else
                    {
                        return PasswordVerificationResult.Failed;
                    }

                default:
                    return PasswordVerificationResult.Failed; // unknown format marker
            }
        }
    }
}
