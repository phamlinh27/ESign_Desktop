using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectESignDemo.models
{
    public class StringDocToHash
    {
        public string StringToHash { get; set; }

        public string HashAlgorithm { get; set; }
    }

    public class StringDocToHashResult : StringDocToHash
    {
        public byte[] Digest { get; set; }
    }
}
