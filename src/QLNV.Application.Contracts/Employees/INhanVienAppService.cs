using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace QLNV.Employees
{
    public interface INhanVienAppService : IApplicationService
    {
        Task<List<NhanVienDto>> GetListAsync();
        Task<NhanVienDto> GetAsync(string id);
        Task<NhanVienDto> CreateAsync(CreateUpdateNhanVienDto input);
        Task<NhanVienDto> UpdateAsync(string id, CreateUpdateNhanVienDto input);
        Task<bool> DeleteAsync(string id);
    }
}
