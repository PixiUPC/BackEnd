using Lawyeed.API.Lawyeed.Persistence.Contexts;

namespace Lawyeed.API.Lawyeed.Persistence.Repositories;

public class BaseRepository
{
    protected readonly AppDbContext _context;

    public BaseRepository(AppDbContext context)
    {
        _context = context;
    }
}