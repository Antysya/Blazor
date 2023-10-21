using BlazorLesson1.Models;
using System.Threading;

namespace BlazorLesson1.Models
{
    public class InMemoryProductsCatalog: IProductsCatalog
    {
        private readonly List<Product> _products = new()
        {
            new("Чистый код", 500m, "image/1.jpg"),
            new("Код, который умещается в голове", 1000m, "image/2.jpg"),
            new("Рефакторинг",  100m, "image/3.jpg")
        };

        public IReadOnlyList<Product> GetProducts()
        {
            return _products.AsReadOnly();
        }
    }
}