using Microsoft.AspNetCore.Mvc;
using TestRepo.BasicCrud.ActionProcessor;
using TestRepo.BasicCrud.Models;

namespace TestRepo.BasicCrud.Controller
{
    [ApiController]
    [Route("crud")]
    public class BasicCrudController: ControllerBase
    {
        [HttpGet]
        [Route("get")]
        public ActionResult<StudentListResponseDto> GetResult()
        {
            return BasicCrudLoadActionProcessors.Process();
        }
    }
}
