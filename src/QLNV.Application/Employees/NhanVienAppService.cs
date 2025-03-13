using AutoMapper.Internal.Mappers;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace QLNV.Employees
{
    public class NhanVienAppService : QLNVAppService, INhanVienAppService
    {
        private readonly IRepository<NhanVien, string> _nhanVienRepository;

        public NhanVienAppService(IRepository<NhanVien, string> nhanVienRepository)
        {
            _nhanVienRepository = nhanVienRepository;
        }

        public async Task<List<NhanVienDto>> GetListAsync()
        {
            var nhanViens = await _nhanVienRepository.GetListAsync();
            return ObjectMapper.Map<List<NhanVien>, List<NhanVienDto>>(nhanViens);
        }

        public async Task<NhanVienDto> GetAsync(string id)
        {
            var nhanVien = await _nhanVienRepository.GetAsync(id);
            return ObjectMapper.Map<NhanVien, NhanVienDto>(nhanVien);
        }

        public async Task<NhanVienDto> CreateAsync(CreateUpdateNhanVienDto input)
        {
            var nhanVien = ObjectMapper.Map<CreateUpdateNhanVienDto, NhanVien>(input);
            var createdNhanVien = await _nhanVienRepository.InsertAsync(nhanVien);
            return ObjectMapper.Map<NhanVien, NhanVienDto>(createdNhanVien);
        }

        public async Task<NhanVienDto> UpdateAsync(string id, CreateUpdateNhanVienDto input)
        {
            var nhanVien = await _nhanVienRepository.GetAsync(id);
            ObjectMapper.Map(input, nhanVien);
            var updatedNhanVien = await _nhanVienRepository.UpdateAsync(nhanVien);
            return ObjectMapper.Map<NhanVien, NhanVienDto>(updatedNhanVien);
        }

        public async Task<bool> DeleteAsync(string id)
        {
            await _nhanVienRepository.DeleteAsync(id);
            return await Task.FromResult(true);
        }
    }
}
