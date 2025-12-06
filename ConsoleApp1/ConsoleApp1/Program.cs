using System;
using System.Linq;
using System.Xml.Linq;

namespace XMLParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load the XML file
            XDocument doc = XDocument.Load("library.xml");

            // Query the XML to find the book with id="3"
            var book = doc.Descendants("book")
                          .Where(b => (string)b.Attribute("id") == "3")
                          .FirstOrDefault();

            // Check if the book exists
            if (book != null)
            {
                // Extract book details
                string title = book.Element("title").Value;
                string author = book.Element("author").Value;
                int year = int.Parse(book.Element("year").Value);

                // Display book details
                Console.WriteLine($"Title: {title}");
                Console.WriteLine($"Author: {author}");
                Console.WriteLine($"Year: {year}");
            }
            else
            {
                Console.WriteLine("Book with id='3' not found.");
            }

            Console.ReadLine(); // Keep console window open
        }
    }
}
