namespace ESign_Desktop.models
{
    public class XmlDocToHash
    {
        public string DocumentId { get; set; }

        public string FileToSign { get; set; }

        public string Prefix { get; set; }

        public XmlSignatureInfoDto SignatureInfo { get; set; }
    }

    public class XmlDocToHashResult
    {
        public string DocumentId { get; set; }

        public string Document { get; set; }

        public string SignatureId { get; set; }

        public byte[] Digest { get; set; }

        public byte[] Sh { get; set; }
    }
}
