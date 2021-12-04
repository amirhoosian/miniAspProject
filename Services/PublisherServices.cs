using Microsoft.EntityFrameworkCore;
using myAspMiniProject.Enum;
using myAspMiniProject.Interface;
using myAspMiniProject.Models;
using myAspMiniProject.ViewModel;
using System.Linq;
using System.Threading.Tasks;

namespace myAspMiniProject.Services
{
    public class PublisherServices : IPublisher
    {
        private readonly miniApiContext _context;

        public PublisherServices(miniApiContext context)
        {
            _context = context;
        }

        public async Task<Result> AddPublisher(AddPublisherViewModel vm)
        {
            Publisher newPublisher = new() {
                Title = vm.Title,
                Logo = vm.Logo
            
            };
            await _context.AddAsync(newPublisher);
            await _context.SaveChangesAsync();
            return Result.Success;
            
        }

        public async Task<Result> DeletePunlisher(int id)
        {
            var publisher = await _context.Publishers.FindAsync(id);
            _context.Publishers.Remove(publisher);
            await _context.SaveChangesAsync();
            return Result.Success;
        }

        public async Task<Result> UpdatePublisher(UpdatePublisherViewModel vm)
        {
            var publisher = await _context.Publishers.FirstOrDefaultAsync(c => c.Id == vm.Id);
            publisher.Title = vm.Title;
            publisher.Logo = vm.Logo;
            _context.Update(publisher);
            await _context.SaveChangesAsync();
            return Result.Success;

        }
    }
}
