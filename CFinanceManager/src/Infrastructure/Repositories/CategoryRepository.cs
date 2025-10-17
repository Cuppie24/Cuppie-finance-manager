using Application.Interfaces.Repositories;
using CFinanceManager.Application.Dto;

namespace Infrastructure.Repositories;

public class CategoryRepository : ICategoryRepository
{
    public CategoryDto AddCategory(CategoryDto categoryDto)
    {
        throw new NotImplementedException();
    }

    public CategoryDto UpdateCategory(CategoryDto categoryDto)
    {
        throw new NotImplementedException();
    }

    public CategoryDto DeleteCategory(int id)
    {
        throw new NotImplementedException();
    }

    public List<CategoryDto> GetCategories(CategoryFilterDto filter)
    {
        throw new NotImplementedException();
    }
}