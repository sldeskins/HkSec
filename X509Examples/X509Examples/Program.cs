using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Thinktecture.IdentityModel;

namespace X509Examples
{
    class Program
    {
        static void Main ( string[] args )
        {
            //Part I - to access certificate
            ////example 1
            //var cert = new X509Certificate2("c:\\etc\\dropbox");


            //example 2
            var store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
            store.Open(OpenFlags.ReadOnly);


            //store.Certificates.Find();

            store.Close();

            //example 3
            //need to install nuget 
            //thinktecture.identity.model core

            var cert1 = X509.LocalMachine.My.SubjectDistinguishedName.Find("CN=serverdev").First();


            //part II - to validate certification
            //example 1
            var chain = new X509Chain();
            var policy = new X509ChainPolicy
            {
                RevocationFlag = X509RevocationFlag.EntireChain,
                RevocationMode = X509RevocationMode.Online
            };
            chain.ChainPolicy = policy;

            if (!chain.Build(cert1))
            {
                foreach (var element in chain.ChainElements)
                {
                    foreach (var status in element.ChainElementStatus)
                    {
                        Console.WriteLine(status.StatusInformation);
                    }
                }
            }

            //example 2
            var validator = X509CertificateValidator.ChainTrust;
            validator.Validate(cert1);

            //example 2B
            validator = X509CertificateValidator.PeerOrChainTrust;
            validator.Validate(cert1);

        }
    }
}
