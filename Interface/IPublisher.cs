using myAspMiniProject.Enum;
using myAspMiniProject.ViewModel;
using System.Threading.Tasks;

namespace myAspMiniProject.Interface
{
    public interface IPublisher
    {
        public Task<Result> AddPublisher(AddPublisherViewModel vm);
        public Task<Result> UpdatePublisher(UpdatePublisherViewModel vm);
        public Task<Result> DeletePunlisher(int id);
        
    }
}
