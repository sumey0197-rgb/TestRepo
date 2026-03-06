using Microsoft.AspNetCore.Mvc;
using TestRepo.BasicCrud.Models;

namespace TestRepo.BasicCrud.ActionProcessor
{
    public class BasicCrudLoadActionProcessors
    {
        public static ActionResult<StudentListResponseDto> Process()
        {
            return new StudentListResponseDto
            {
                Students = new List<StudentDto>
                {
                    new StudentDto { Id = 1, Name = "Alice", Age = 14, Class = 9, Grade = "A" },
                    new StudentDto { Id = 2, Name = "Bob", Age = 15, Class = 10, Grade = "B" },
                    new StudentDto { Id = 3, Name = "Sumey", Age = 18, Class = 12, Grade = "Science"}
                }
            };
        }
    }
}
