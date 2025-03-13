using Microsoft.AspNetCore.Mvc;
using QLNV.Employees;
using QLNV.Localization;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;
using static QLNV.Controllers.QLNVController;

namespace QLNV.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class QLNVController : AbpControllerBase
{
    protected QLNVController()
    {
        LocalizationResource = typeof(QLNVResource);
    }
    [Route("api/nhanviens")]
    [ApiController]
    public class NhanVienController : QLNVController
    {
        private readonly INhanVienAppService _nhanVienAppService;

        public NhanVienController(INhanVienAppService nhanVienAppService)
        {
            _nhanVienAppService = nhanVienAppService;
        }

        [HttpGet]
        public async Task<ActionResult<List<NhanVienDto>>> GetListAsync()
        {
            return await _nhanVienAppService.GetListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<NhanVienDto>> GetAsync(string id)
        {
            return await _nhanVienAppService.GetAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<NhanVienDto>> CreateAsync(CreateUpdateNhanVienDto input)
        {
            return await _nhanVienAppService.CreateAsync(input);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<NhanVienDto>> UpdateAsync(string id, CreateUpdateNhanVienDto input)
        {
            return await _nhanVienAppService.UpdateAsync(id, input);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(string id)
        {
            await _nhanVienAppService.DeleteAsync(id);
            return NoContent();
        }
    }
}
