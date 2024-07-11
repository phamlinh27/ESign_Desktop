using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace ProjectESignDemo.models
{
    public class XmlSignatureInfoDto
    {
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        [DataMember(Name = "nodeToSign", IsRequired = true, EmitDefaultValue = false)]
        public List<string> NodeToSign { get; set; }

        [DataMember(Name = "signatureLocation", EmitDefaultValue = true)]
        public string SignatureLocation { get; set; }

        [DataMember(Name = "showSigningTime", EmitDefaultValue = true)]
        public bool ShowSigningTime { get; set; }

        [DataMember(Name = "TimeNodeId", EmitDefaultValue = true)]
        public string TimeNodeId { get; set; }

        [DataMember(Name = "HashAlgorithm", EmitDefaultValue = true)]
        public string HashAlgorithm { get; set; }

        public XmlSignatureInfoDto(string id = null, List<string> nodeToSign = null, string signatureLocation = null, bool showSigningTime = false, string timeNodeId = null, string hashAlgorithm = "SHA-256")
        {
            NodeToSign = nodeToSign ?? throw new ArgumentNullException("nodeToSign is a required property for XmlSignatureInfoDto and cannot be null");
            Id = id;
            SignatureLocation = signatureLocation;
            HashAlgorithm = hashAlgorithm;
            ShowSigningTime = showSigningTime;
            TimeNodeId = timeNodeId;
        }
    }
}
