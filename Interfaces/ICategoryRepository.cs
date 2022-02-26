public interface ICategoryRepository{
    Category AddCategory(Category category);
    Category UpdateCategory(int id, Category category);
    void DeleteCategory(Category category);
    List<Category> GetAllCategory();
    Category GetByCategoryId(int categoryId);
    List<Category> GetAllCategoryByName(string categoryName);
    
}