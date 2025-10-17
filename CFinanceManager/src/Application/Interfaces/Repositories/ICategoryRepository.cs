using CFinanceManager.Application.Dto;

namespace Application.Interfaces.Repositories;

public interface ICategoryRepository
{
    public CategoryDto AddCategory(CategoryDto categoryDto);
    public CategoryDto UpdateCategory(CategoryDto categoryDto);
    public CategoryDto DeleteCategory(int id);
    public List<CategoryDto> GetCategories(CategoryFilterDto filter);
}