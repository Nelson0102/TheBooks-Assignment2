using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace TheBooks.Pages
{
    // This is the Razor Page class for the "Index" page of "The Books" website.
    public class IndexModel : PageModel
    {
        // Inject the IWebHostEnvironment service to access the hosting environment information.
        private readonly IWebHostEnvironment _webHostEnvironment;

        // A list of books to be displayed on the "Index" page.
        public List<Book> Books { get; set; }

        // Constructor with dependency injection of IWebHostEnvironment.
        public IndexModel(IWebHostEnvironment webHostEnvironment)
        {
            // Initialize the _webHostEnvironment field with the injected value.
            _webHostEnvironment = webHostEnvironment;
        }

        // This method is executed when the "Index" page is requested (HTTP GET).
        public void OnGet()
        {
            // Get the path to the JSON file containing book data using _webHostEnvironment.
            string jsonFilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Data", "Books.json");

            // Read the JSON data from the file into a string.
            string jsonData = System.IO.File.ReadAllText(jsonFilePath);

            // Deserialize the JSON data into a list of Book objects using Newtonsoft.Json.
            Books = JsonConvert.DeserializeObject<List<Book>>(jsonData);
        }
    }

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
