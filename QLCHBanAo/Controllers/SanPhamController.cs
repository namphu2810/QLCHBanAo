using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QLCHBanAo.Models;

namespace QLCHBanAo.Controllers
{
    public class SanPhamController : Controller
    {
        private readonly QlbaDbContext _context;

        public SanPhamController(QlbaDbContext context)
        {
            _context = context;
        }

        // GET: SanPham
        public async Task<IActionResult> Index()
        {
            var sanPhamList = await _context.SanPham
                .Include(s => s.BienThe)
                    .ThenInclude(b => b.TonKhoSP)
                        .ThenInclude(t => t.CuaHang)
                .ToListAsync();
            var spMau = sanPhamList.FirstOrDefault(s => s.Id == 1);

            if (spMau != null)
            {
                var giaThapNhatList = spMau.BienThe?
            .SelectMany(b => b.TonKhoSP ?? Enumerable.Empty<QLCHBanAo.Models.TonKhoSP>())
            .Where(t => t != null && t.DonGia > 0)
            .Select(t => t.DonGia)
            .ToList();

                var giaThapNhat = giaThapNhatList != null && giaThapNhatList.Any() ? giaThapNhatList.Min() : 0;

                // Lưu kết quả kiểm tra vào ViewBag
                ViewBag.DebugSoBienThe = spMau.BienThe?.Count ?? 0;
                ViewBag.DebugGiaThapNhat = giaThapNhat;
                ViewBag.DebugTenSP = spMau.TenSanPham;

            }
            return View(sanPhamList);
        }

        // GET: SanPham/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPham = await _context.SanPham
                .Include(s => s.BienThe)
                    .ThenInclude(b => b.MauSac)
                .Include(s => s.BienThe)
                    .ThenInclude(b => b.KichThuoc)
                .Include(s => s.BienThe)
                    .ThenInclude(b => b.ChatLieu)
                .Include(s => s.BienThe)
                    .ThenInclude(b => b.ThuongHieu)
                .Include(s => s.BienThe)
                    .ThenInclude(b => b.TonKhoSP)
                        .ThenInclude(t => t.CuaHang)
                .FirstOrDefaultAsync(m => m.Id == id);
            
            if (sanPham == null)
            {
                return NotFound();
            }

            return View(sanPham);
        }

        // GET: SanPham/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SanPham/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenSanPham,MoTa,HinhAnh")] SanPham sanPham)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sanPham);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sanPham);
        }

        // GET: SanPham/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPham = await _context.SanPham.FindAsync(id);
            if (sanPham == null)
            {
                return NotFound();
            }
            return View(sanPham);
        }

        // POST: SanPham/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenSanPham,MoTa,HinhAnh")] SanPham sanPham)
        {
            if (id != sanPham.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sanPham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SanPhamExists(sanPham.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(sanPham);
        }

        // GET: SanPham/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPham = await _context.SanPham
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sanPham == null)
            {
                return NotFound();
            }

            return View(sanPham);
        }

        // POST: SanPham/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sanPham = await _context.SanPham.FindAsync(id);
            if (sanPham != null)
            {
                _context.SanPham.Remove(sanPham);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SanPhamExists(int id)
        {
            return _context.SanPham.Any(e => e.Id == id);
        }
    }
}
