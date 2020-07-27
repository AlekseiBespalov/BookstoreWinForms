using System.Xml.Serialization;

namespace BookstoreWinForms.Models.XmlModels.BookStore
{
    /// <summary>
    /// Represents title in book XML element
    /// </summary>
    [XmlRoot(ElementName = "title")]
    public class TitleModel
    {
        [XmlAttribute(AttributeName = "lang")]
        public string Lang { get; set; } = string.Empty;

        [XmlText]
        public string Text { get; set; }
    }
}
