﻿using BUS.ViewModels;
using DAL.Models;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class HoaDonChiTietServices
    {
        HoaDonChiTietRepos hoaDonChiTietRepos = new HoaDonChiTietRepos();

        HoaDonRepos hoaDonRepos = new HoaDonRepos();
        SanPhamRepos sanPhamRepos = new SanPhamRepos();
        LoaiSanPhamRepos loaiSanPhamRepos = new LoaiSanPhamRepos();
        TaiKhoanRepos taiKhoanRepos = new TaiKhoanRepos();
        AppDbContext _context;
       
        public HoaDonChiTietServices()
        {
            sanPhamRepos = new SanPhamRepos();
            taiKhoanRepos = new TaiKhoanRepos();
            hoaDonRepos = new HoaDonRepos();
            hoaDonChiTietRepos = new HoaDonChiTietRepos();
            loaiSanPhamRepos = new LoaiSanPhamRepos();
            _context = new AppDbContext();
        }
        public List<HoaDonChiTiet> GetAllHDCT()
        {
            return hoaDonChiTietRepos.GetAllHDCT();
        }
        public string CreateHDCT(HoaDonChiTiet hdct)
        {
            if (hoaDonChiTietRepos.CreateHDCT(hdct))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }
        public List<HoaDonVm> GetHD_HDCT()
        {
            var hd =( from hoadon in _context.HoaDons
                     join HDCT in _context.HoaDonChiTiets on hoadon.Id equals HDCT.IdHoaDon
                     join sp in _context.sanPhams on HDCT.IdSanPham equals sp.Id
                     join tk in _context.TaiKhoans on hoadon.IdTaiKhoan equals tk.Id
                     join lsp in _context.loaiSanPhams on sp.IdLoaiSp equals lsp.Id
                      select new HoaDonVm
                     {
                         IdHd = hoadon.Id,
                         IdSp = sp.Id,
                         TenSp = sp.TenSanPham,
                         Gia=sp.GiaSanPham,
                         Thue = Convert.ToInt32(hoadon.Thue),
                         SoLuong = sp.SoLuong,   
                         ThanhTien = Convert.ToString(sp.SoLuong * sp.GiaSanPham - int.Parse(hoadon.Thue)),
                         MoTa = lsp.MoTa,
                     }).ToList();
            return hd;
        }
    }
}
