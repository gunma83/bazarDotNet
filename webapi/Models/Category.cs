using System;
namespace webapi.Models
{
public class Category
    {
    public Category(int idCategory, string nameCategory, string descriptionCategory)
    {
        IdCategory = idCategory;
        NameCategory = nameCategory;
        DescriptionCategory = descriptionCategory;
        CreationDate = DateTime.Now; 
    }

    public int IdCategory { get; set; }
    public string NameCategory { get; set; }
    public string DescriptionCategory { get; set; }
    public DateTime CreationDate { get; set; }
    }
}