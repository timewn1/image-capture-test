using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace image_capture.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public class ImageDataType
        {
            public string image { get; set; }
        }

        [Route("api/[controller]")]
        [ApiController]
        public class ImageController : Controller
        {
            [HttpPost("[action]")]
            public void Send(ImageDataType json)
            {
                
            }
        }

    }
}
