using AutoMapper;
using QLNV.Employees;

namespace QLNV;

public class QLNVApplicationAutoMapperProfile : Profile
{
    public QLNVApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<NhanVien, NhanVienDto>();
        CreateMap<NhanVienDto, NhanVien>();
        CreateMap<CreateUpdateNhanVienDto, NhanVien>();
    }
}
