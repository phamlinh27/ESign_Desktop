using System.Collections.Generic;

namespace ProjectESignDemo.models
{
    public class AttachSignatureData_Api
    {
        public DocumentType DocumentType { get; set; }

        public List<AttachSignaturePdfData_Api> PdfDocs { get; set; }

        public List<AttachSignatureXmlData_Api> XmlDocs { get; set; }

        public List<AttachSignatureExcelData_Api> ExcelDocs { get; set; }

        public List<AttachSignatureWordData_Api> WordDocs { get; set; }

        public byte[] Certificate { get; set; }

        public List<string> CertificateChain { get; set; }

        public string HashAlgorithm { get; set; }
    }

    public class AttachSignaturePdfData_Api : PdfDocToHashResult
    {
        public string Signature { get; set; }
    }

    public class AttachSignatureXmlData_Api : XmlDocToHashResult
    {
        public string Signature { get; set; }
    }

    public class AttachSignatureExcelData_Api : ExcelDocToHashResult
    {
        public string Signature { get; set; }
    }

    public class AttachSignatureWordData_Api : WordDocToHashResult
    {
        public string Signature { get; set; }
    }
}
