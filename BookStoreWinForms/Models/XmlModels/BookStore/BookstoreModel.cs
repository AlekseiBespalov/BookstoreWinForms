using System.Collections.Generic;
using System.Xml.Serialization;

namespace BookstoreWinForms.Models.XmlModels.BookStore
{
    /// <summary>
    /// Root XML element
    /// </summary>
    [XmlRoot(ElementName = "bookstore")]
    public class BookstoreModel
    {
        [XmlElement(ElementName = "book")]
        public List<BookModel> Books { get; set; }
    }
}
