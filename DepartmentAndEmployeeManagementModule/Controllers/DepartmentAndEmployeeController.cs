using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace DepartmentAndEmployeeManagementModule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentAndEmployeeController : ControllerBase
    {
        private readonly DepartmentAndEmployeeService _service;

        public DepartmentAndEmployeeController(DepartmentAndEmployeeService service)
        {
            _service = service;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEmployees(CancellationToken cancellationToken)
        {
            return Ok(await _service.GetAllEmployees(cancellationToken));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetDepartmentsHierarchy(CancellationToken cancellationToken)
        {
            return Ok(await _service.GetDepartmentsHierarchy(cancellationToken));
        }
    }
}