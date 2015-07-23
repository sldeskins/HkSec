using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Tokens;

namespace Tokens
{
    public class JWT_Example
    {

        public string produce_JSONWebTokenString ()
        {
            var token = new JwtSecurityToken(
            issuer: "http://myIssuere",
            audience: "http://myIssuere",
            claims: GetClaims(),
            signingCredentials: GetKey(),
            notBefore: DateTime.UtcNow,
            expires: DateTime.UtcNow.AddHours(1));

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public void consume_JSONWebTokenString ()
        {
            string tokenString = "";//produce_JSONWebTokenString(); //get from somewhere
            var token = new JwtSecurityToken(tokenString);
            var validationParams = new TokenValidationParameters
            {
                ValidIssuer = "http://myIssuer",
                ValidAudiences = new List<String>() { "HttpStyleUriParser://myResource" },
                IssuerSigningToken = GetSigningKey()
            };


            var handler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principat = handler.ValidateToken(tokenString, validationParams, out securityToken);
        }

        private SecurityToken GetSigningKey ()
        {
            throw new NotImplementedException();
        }



        private System.IdentityModel.Tokens.SigningCredentials GetKey ()
        {
            var mySecuirytKey = new MySecurityKey();
            string signatureAlgorithm = "something";
            string digestAlgorithm = "digest";
            return new System.IdentityModel.Tokens.SigningCredentials(mySecuirytKey, signatureAlgorithm, digestAlgorithm, new SecurityKeyIdentifier());
        }

        private IEnumerable<System.Security.Claims.Claim> GetClaims ()
        {
            return new List<System.Security.Claims.Claim>() { };
        }

        class MySecurityKey : SecurityKey
        {
            public override byte[] DecryptKey ( string algorithm, byte[] keyData )
            {
                throw new NotImplementedException();
            }

            public override byte[] EncryptKey ( string algorithm, byte[] keyData )
            {
                throw new NotImplementedException();
            }

            public override bool IsAsymmetricAlgorithm ( string algorithm )
            {
                throw new NotImplementedException();
            }

            public override bool IsSupportedAlgorithm ( string algorithm )
            {
                throw new NotImplementedException();
            }

            public override bool IsSymmetricAlgorithm ( string algorithm )
            {
                throw new NotImplementedException();
            }

            public override int KeySize
            {
                get { throw new NotImplementedException(); }
            }
        }

    }
}
