using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myAspMiniProject.Interface;
using myAspMiniProject.ViewModel;
using System.Threading.Tasks;

namespace myAspMiniProject.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        private readonly IPublisher _publisher;

        public PublisherController(IPublisher publisher)
        {
            _publisher = publisher;
        }

        [HttpPost]
        public async Task<IActionResult> AddPublisher(AddPublisherViewModel vm)
        {
            var AddPublisher = await _publisher.AddPublisher(vm);
            switch (AddPublisher)
            {
                case Enum.Result.Error:
                    return BadRequest("خطایی رخ داده است");
                case Enum.Result.NotFound:
                    return BadRequest("موضوع پیدا نشد");
                case Enum.Result.Dpplicated:
                    return BadRequest("موضوع تکراری است");
                case Enum.Result.Success:
                    return Ok("عملیات موفقیت امیز بود");
                default:
                    return null;

            }
        }

        [HttpPut]

        public async Task<IActionResult> UpdatePublisher(UpdatePublisherViewModel vm)
        {
            var UpdatePublisher = await _publisher.UpdatePublisher(vm);
            switch (UpdatePublisher)
            {
                case Enum.Result.Error:
                    return BadRequest("خطایی رخ داده است");
                case Enum.Result.NotFound:
                    return BadRequest("موضوع پیدا نشد");
                case Enum.Result.Dpplicated:
                    return BadRequest("موضوع تکراری است");
                case Enum.Result.Success:
                    return Ok("عملیات موفقیت امیز بود");
                default:
                    return null;

            }

        }

        [HttpDelete("id")]
        public async Task<IActionResult> DeletePublisher(int id)
        {
            var DeletePublisher = await _publisher.DeletePunlisher(id);
            switch (DeletePublisher)
            {
                case Enum.Result.Error:
                    return BadRequest("خطایی رخ داده است");
                case Enum.Result.NotFound:
                    return BadRequest("موضوع پیدا نشد");
                case Enum.Result.Dpplicated:
                    return BadRequest("موضوع تکراری است");
                case Enum.Result.Success:
                    return Ok("عملیات موفقیت امیز بود");
                default:
                    return null;

            }
        }

    }
}
