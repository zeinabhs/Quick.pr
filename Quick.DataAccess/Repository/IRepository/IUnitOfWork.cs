using System.Threading.Tasks;

namespace Quick.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        IProductRepository Product { get; }
        // Add other repositories as needed

        void Save(); // Ensure this line has the correct casing
    }
}
