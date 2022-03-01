public class CategoryRepository : ICategoryRepository
{
    public Task<Category> AddCategory(Category category)
    {
        throw new NotImplementedException();
    }

    public Task DeleteCategory(Category category)
    {
        throw new NotImplementedException();
    }

    public Task<List<Category>> GetAllCategory()
    {
        throw new NotImplementedException();
    }

    public Task<List<Category>> GetAllCategoryByName(string categoryName)
    {
        throw new NotImplementedException();
    }

    public Task<Category> GetByCategoryId(int categoryId)
    {
        throw new NotImplementedException();
    }

    public Task<Category> UpdateCategory(int id, Category category)
    {
        throw new NotImplementedException();
    }
}