﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV.Employees
{
    public class CreateUpdateNhanVienDto
    {
        public string Id { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public DateOnly NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string CapBac { get; set; }
        public string PhongBanId { get; set; }
        public string QuanLyId { get; set; }
    }
}
