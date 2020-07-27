using BookstoreWinForms.Models.XmlModels.BookStore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;

/// <summary>
/// Main form which allows users to manipulate with XML and HTML files.
/// 
/// The class creates file dialogs to specify the file which we want to work on.
/// 
/// Implemented: 
/// 1. Opening XML files with specified format (for details click: https://github.com/AlekseiBespalov/BookstoreWinForms).
/// 2. Changing XML file through data grid view.
/// 3. Saving XML files in needed location.
/// 4. Saving and creating HTML report.
/// 
/// TODO: move XSLT string into another file, refactoring.
/// </summary>
namespace BookstoreWinForms
{
    public partial class Bookstore : Form
    {
        /// <summary>
        /// Dialog for saving XML file into necessary location.
        /// </summary>
        private readonly SaveFileDialog saveXMLFileDialog;

        /// <summary>
        /// Dialog for opening XML file.
        /// </summary>
        private readonly OpenFileDialog openXMLFileDialog;

        /// <summary>
        /// Common XML serializer for all serializing and 
        /// deserializing operations.
        /// </summary>
        private readonly XmlSerializer xmlSerializer;


        /// <summary>
        /// Dialog for saving HTML file into necessary location.
        /// </summary>
        private readonly SaveFileDialog saveHTMLFileDialog;

        /// <summary>
        /// XSLT string for specified format.
        /// </summary>
        readonly string xsltString = @"<?xml version='1.0' encoding='UTF-8'?>
            <xsl:stylesheet version = '1.0' xmlns:xsl='http://www.w3.org/1999/XSL/Transform'>
            	<xsl:template match = '/'>
                    <html>
                        <body>
                            <table border='1'>
            					<tr bgcolor = '#9acd32'>
                                    <th style = 'text-align:center'>title</th>
            						<th style = 'text-align:center'>author</th>
                                    <th style = 'text-align:center'>category</th>
            						<th style = 'text-align:center'>year</th>
                                    <th style = 'text-align:center'>price</th>
            					</tr>
            					<xsl:for-each select = 'bookstore/book'>
                                    <tr>
                                        <td>
                                            <xsl:value-of select = 'title'/>
                                        </td>
                                        <td>
                                            <xsl:value-of select = 'author'/>
                                        </td>
                                        <td>
                                            <xsl:value-of select = '@category'/>
                                        </td>
                                        <td>
                                            <xsl:value-of select = 'year'/>
                                        </td>
                                        <td>
                                            <xsl:value-of select = 'price'/>
                                        </td>
                                    </tr>
                                </xsl:for-each>
            				</table>
            			</body>
            		</html>
            	</xsl:template>
            </xsl:stylesheet>";


        /// <summary>
        /// Constructor initializes the form, common XML serializer,
        /// all file dialogs and their filters by mask.
        /// </summary>
        public Bookstore()
        {
            InitializeComponent();

            xmlSerializer = new XmlSerializer(typeof(BookstoreModel));

            saveXMLFileDialog = new SaveFileDialog
            {
                Filter = "XML files (*.xml)|*.xml"
            };

            openXMLFileDialog = new OpenFileDialog
            {
                Filter = "XML files (*.xml)|*.xml"
            };

            saveHTMLFileDialog = new SaveFileDialog
            {
                Filter = "HTML files (*.html)|*.html"
            };
        }

        /// <summary>
        /// Opens save XML file dialog and write
        /// data from the DataGridView into specified file.
        /// </summary>
        /// <param name="sender">Object which raised the event (button).</param>
        /// <param name="e">Event data.</param>
        private void SaveXml_Click(object sender, EventArgs e)
        {
            if (saveXMLFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using(TextWriter writer = new StreamWriter(saveXMLFileDialog.FileName))
                    {
                        xmlSerializer.Serialize(writer, GetBookstoreModelFromDataGridView());
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Файл занят другим приложением \n\nПолный текст ошибки: \n\n{ex.InnerException.Message}",
                                "Ошибка в файле!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Opens specified XML file,
        /// sets all data to DataGridView and 
        /// path to file into form header.
        /// </summary>
        /// <param name="sender">Object which raised the event (button).</param>
        /// <param name="e">Event data.</param>
        private void OpenXml_Click(object sender, EventArgs e)
        {
            if (openXMLFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string readXml = File.ReadAllText(openXMLFileDialog.FileName);

                    using(TextReader reader = new StringReader(readXml))
                    {
                        try 
                        {
                            BookstoreModel bookstoreModel = (BookstoreModel)xmlSerializer.Deserialize(reader);
                            SetDataToDataGridView(bookstoreModel);
                            this.Text = Text + $" {openXMLFileDialog.FileName}";
                        }
                        catch (InvalidOperationException ex)
                        {
                            MessageBox.Show($"В файле есть ошибка! \n\nПолный текст ошибки: \n\n{ex.InnerException.Message}", 
                                "Ошибка в файле!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Ошибка безопасности.\n\nПолный текст ошибки: {ex.Message}\n\n");
                }

                
            }
        }

        /// <summary>
        /// Creates new row in BookstoreDataGridView.
        /// </summary>
        /// <param name="sender">Object which raised the event (button).</param>
        /// <param name="e">Event data.</param>
        private void AddRecord_Click(object sender, EventArgs e)
        {
            BookstoreDataGridView.Rows.Add(new DataGridViewRow());
        }

        /// <summary>
        /// Deletes selected rows from BookstoreDataGridView.
        /// </summary>
        /// <param name="sender">Object which raised the event (button).</param>
        /// <param name="e">Event data.</param>
        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in BookstoreDataGridView.SelectedRows)
            {
                BookstoreDataGridView.Rows.RemoveAt(row.Index);
            }
        }

        /// <summary>
        /// Transforms XML file with specified XSLT
        /// into HTML and saves it in specified location.
        /// </summary>
        /// <param name="sender">Object which raised the event (button).</param>
        /// <param name="e">Event data.</param>
        private void HtmlReport_Click(object sender, EventArgs e)
        {
            if (saveHTMLFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StringWriter textWriter = new StringWriter())
                {
                    xmlSerializer.Serialize(textWriter, GetBookstoreModelFromDataGridView());
                    File.WriteAllText(saveHTMLFileDialog.FileName, TransformXMLToHTML(textWriter.ToString(), xsltString));
                    System.Diagnostics.Process.Start(saveHTMLFileDialog.FileName);
                }
            }
        }

        /// <summary>
        /// Parses and maps BookstoreDataGridView into BookstoreModel
        /// for further use.
        /// TODO: remove row index (use column names instead)
        /// </summary>
        /// <returns>Root object of XML document</returns>
        private BookstoreModel GetBookstoreModelFromDataGridView()
        {
            BookstoreModel bookStoreModel = new BookstoreModel
            {
                Books = new List<BookModel>()
            };

            foreach(DataGridViewRow dr in BookstoreDataGridView.Rows)
            {
                decimal price = 0;
                try
                {
                    price = decimal.Parse(dr.Cells[5].Value.ToString());
                }
                catch
                {
                    MessageBox.Show($"Неверный формат цены!",
                                "Ошибка формата цены", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                bookStoreModel.Books.Add(new BookModel
                {
                    Title = new TitleModel 
                    { 
                        Text = dr.Cells[0].Value.ToString(),
                        Lang = dr.Cells[2].Value?.ToString()
                    },
                    Year = dr.Cells[1].Value?.ToString(),
                    Authors = dr.Cells[3].Value.ToString().Split(';').ToList(),
                    Category = dr.Cells[4].Value.ToString(),
                    Price = price
                });
            }

            return bookStoreModel;
        }

        /// <summary>
        /// Transforms XML string into HTML string
        /// </summary>
        /// <param name="inputXML">XML string</param>
        /// <param name="xsltString">XSLT string</param>
        /// <returns>HTML string</returns>
        public static string TransformXMLToHTML(string inputXML, string xsltString)
        {
            XslCompiledTransform transform = new XslCompiledTransform();
            using (XmlReader reader = XmlReader.Create(new StringReader(xsltString)))
            {
                transform.Load(reader);
            }
            StringWriter results = new StringWriter();
            using (XmlReader reader = XmlReader.Create(new StringReader(inputXML)))
            {
                transform.Transform(reader, null, results);
            }
            return results.ToString();
        }

        /// <summary>
        /// Assigns all data from root XML element to
        /// BookStoreDataGridView
        /// </summary>
        /// <param name="bookstore">Root XML element</param>
        private void SetDataToDataGridView(BookstoreModel bookstore)
        {
            BookstoreDataGridView.Rows.Clear();

            foreach (BookModel book in bookstore.Books)
            {
                BookstoreDataGridView.Rows.Add(book.Title.Text, book.Year, book.Title.Lang, string.Join(";",book.Authors), book.Category, book.Price);
            }
        }
    }
}
