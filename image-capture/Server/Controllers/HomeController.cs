using Microsoft.AspNetCore.Mvc;
using IronPdf;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;

namespace blazor_test_app.Server.Controllers
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
            byte[] imageData = Convert.FromBase64String(json.image.Split(',')[1]);

            FileStream fs = new FileStream(@"upload/cam.jpg", FileMode.OpenOrCreate);
            fs.Write(imageData, 0, imageData.Length);
            fs.Close();
            ImageToPdfConverter.ImageToPdf(@"upload/cam.jpg").SaveAs(@"upload/composite.pdf");
        }
    }
}