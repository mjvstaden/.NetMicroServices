using PlatformService.Models;

namespace PlatformService.Data 
{
    public class PlatformRepo(AppDbContext context) : IPlatformRepo
    {
        private AppDbContext _context = context;

        public void CreatePlatform(Platform platform)
        {
            if (platform == null)
            {
                throw new ArgumentNullException(nameof(platform));
            }

            _context.Platforms.Add(platform);
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _context.Platforms.ToList();
        }

        public bool SaveChanges()
        {
          return (_context.SaveChanges() >= 0);
        }

        Platform IPlatformRepo.GetPlatfromById(int id)
        {
            return _context.Platforms.FirstOrDefault(p => p.Id == id);
        }
    }
}