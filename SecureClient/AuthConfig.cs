using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace SecureClient
{
    class AuthConfig
    {
        public string Instance { get; set; }
        public string TenantId { get; set; }
        public string ClientId{ get; set; }
        public string Authority 
        {
            get
            {

                return string.Format(CultureInfo.InvariantCulture, Instance, TenantId);
            }
        
        }
        public string ClientSecret { get; set; }
        public string BaseAddress { get; set; }
        public string ResourceId { get; set; }

        public static AuthConfig ReadJsonFromFile(string path)
        {
            IConfiguration configuration;

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(path);
            configuration = builder.Build();

            return configuration.Get<AuthConfig>();
            
        }
    }
}
