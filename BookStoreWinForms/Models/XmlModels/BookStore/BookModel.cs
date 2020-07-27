using System.Collections.Generic;
using System.Xml.Serialization;

namespace BookstoreWinForms.Models.XmlModels.BookStore
{
	/// <summary>
	/// Represents book in root XML element
	/// </summary>
    [XmlRoot(ElementName = "book")]
    public class BookModel
    {
		[XmlElement(ElementName = "title")]
		public TitleModel Title { get; set; }

		[XmlElement(ElementName = "author")]
		public List<string> Authors { get; set; }

		[XmlElement(ElementName = "year")]
		public int Year { get; set; }

		[XmlElement(ElementName = "price")]
		public decimal Price { get; set; }

		[XmlAttribute(AttributeName = "category")]
		public string Category { get; set; }

	}
}
