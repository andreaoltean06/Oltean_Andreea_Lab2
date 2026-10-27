using System.Collections.Generic;
using Oltean_Andreea_Lab2.Models;

namespace Oltean_Andreea_Lab2.ViewModels
{
    public class CategoryIndexData
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
