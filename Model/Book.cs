// TheBooks.Model/Book.cs

namespace TheBooks.Model
{
    // This class represents a book entity with its properties.
    public class Book
    {
        // The title of the book.
        public string Title { get; set; }

        // The name of the author who wrote the book.
        public string Author { get; set; }

        // The International Standard Book Number (ISBN) of the book.
        public string ISBN { get; set; }

        // The number of pages in the book.
        public int Pages { get; set; }

        // The price of the book.
        public decimal Price { get; set; }

        // A brief description of the book's content or story.
        public string Description { get; set; }

        // The URL of the book's cover image.
        public string ImageUrl { get; set; }
    }
}
