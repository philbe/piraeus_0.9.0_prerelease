﻿using System.Configuration;

namespace Piraeus.Configuration.Channels
{
    public class TcpChannelElement : ConfigurationElement
    {
        [ConfigurationProperty("useLengthPrefix", DefaultValue =true)]
        public bool UseLengthPrefix
        {
            get { return (bool)base["useLengthPrefix"]; }
            set { base["useLengthPrefix"] = value; }
        }

        

        [ConfigurationProperty("blockSize", IsRequired =false)]
        public int? BlockSize
        {
            get { return (int)base["blockSize"]; }
            set { base["blockSize"] = value; }
        }

        [ConfigurationProperty("maxBufferSize", IsRequired = false)]
        public int? MaxBufferSize
        {
            get { return (int)base["maxBufferSize"]; }
            set { base["maxBufferSize"] = value; }
        }

        [ConfigurationProperty("presharedkey", IsRequired = false)]
        public PskElement PSK
        {
            get { return (PskElement)base["presharedkey"]; }
            set { base["presharedkey"] = value; }
        }

        [ConfigurationProperty("certificate", IsRequired =false)]
        public X509Element Certificate
        {
            get { return (X509Element)base["certificate"]; }
            set { base["certificate"] = value; }
        }


       
    }
}
