namespace webapi.Models
{
    public class CategoryInsertRequest
    {
        public string? CategoryName { get; set; }
        public int? CategoryId { get; set; }
        public string? CategoryDescription { get; set; }
        public string? ImmagineCategoria { get; set; }
        public DateTime? CategoryCreationDate { get; set; }
    }
}
