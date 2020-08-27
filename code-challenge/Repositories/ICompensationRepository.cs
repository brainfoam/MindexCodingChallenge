//Written by Joseph Aquiare for the Mindex coding challenge.

using challenge.Models;
using System.Threading.Tasks;

namespace challenge.Repositories
{
    public interface ICompensationRepository
    {
        Compensation GetById(string _id);
        Compensation Add(Compensation _compensation);
        Compensation Remove(Compensation _compensation);
        Task SaveAsync();
    }
}