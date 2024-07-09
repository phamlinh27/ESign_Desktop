using System.Collections.Generic;


namespace ESign_Desktop.models
{
    public class CalculateLocalHashData
    {
        public DocumentType DocumentType { get; set; }

        public byte[] Certificate { get; set; }

        public List<string> CertificateChain { get; set; }

        public List<XmlDocToHash> XmlDocs { get; set; }

        public List<PdfDocToHash> PdfDocs { get; set; }

        public List<ExcelDocToHash> ExcelDocs { get; set; }

        public List<WordDocToHash> WordDocs { get; set; }

        public List<StringDocToHash> StringDocs { get; set; }
    }

    public class CalculateLocalHashData_Api
    {

        public string Certificate { get; set; }

        public List<string> CertificateChain { get; set; }

        public List<XmlDocToHash> XmlDocs { get; set; }

        public List<PdfDocToHash> PdfDocs { get; set; }

        public List<ExcelDocToHash> ExcelDocs { get; set; }

        public List<WordDocToHash> WordDocs { get; set; }

        public List<StringDocToHash> StringDocs { get; set; }
    }

    public class CalculateLocalHashResult
    {
        public DocumentType DocumentType { get; set; }

        public List<PdfDocToHashResult> PdfDocs { get; set; }

        public List<XmlDocToHashResult> XmlDocs { get; set; }

        public List<ExcelDocToHashResult> ExcelDocs { get; set; }

        public List<WordDocToHashResult> WordDocs { get; set; }

        public List<StringDocToHashResult> StringDocs { get; set; }
    }

    public enum DocumentType
    {
        Pdf,
        Xml,
        Hash,
        Excel,
        Word,
        XmlIVan,
        XmlIMTax,
        DecTaxReturn,
        SignString,
        PdfIVan
    }
}
