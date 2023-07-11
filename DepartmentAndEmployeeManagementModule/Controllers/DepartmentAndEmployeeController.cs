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

        /// <summary>
        /// Получение всех сотрудников
        /// </summary>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns></returns>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEmployees(CancellationToken cancellationToken)
        {
            return Ok(await _service.GetAllEmployees(cancellationToken));
        }

        /// <summary>
        /// Получение иерархии отделов
        /// </summary>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns></returns>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetDepartmentsHierarchy(CancellationToken cancellationToken)
        {
            return Ok(await _service.GetDepartmentsHierarchyAsync(cancellationToken));
        }

        /// <summary>
        /// Обновление ФИО сотрудника
        /// </summary>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <param name="employeeId">Табельный номер сотрудника</param>
        /// <param name="newFio">Новое ФИО</param>
        /// <returns></returns>
        [HttpPut("[action]/{employeeId}/{newFio}")]
        public async Task<IActionResult> UpdateEmployeeFio(CancellationToken cancellationToken,
            [FromRoute] Guid employeeId,
            [FromRoute] string newFio)
        {
            try
            {
                return Ok(await _service.UpdateEmployeeFioAsync(cancellationToken, employeeId, newFio));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}