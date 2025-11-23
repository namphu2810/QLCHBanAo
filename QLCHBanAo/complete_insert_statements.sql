-- INSERT đã được sửa - Bổ sung các cột foreign key bắt buộc cho bảng BienThe

INSERT INTO CuaHang (TenCuaHang, DiaChi, SDT) VALUES
(N'Cửa Hàng A - Quận 1', N'123 Đường Nguyễn Huệ, Q.1, TP.HCM', '0901112222'),
(N'Cửa Hàng B - Thủ Đức', N'456 Đường Võ Văn Ngân, TP. Thủ Đức', '0903334444'),
(N'Cửa Hàng C - Hà Nội', N'789 Phố Hàng Bài, Hoàn Kiếm, Hà Nội', '0905556666'),
(N'Cửa Hàng D - Đà Nẵng', N'101 Đường Trần Phú, Hải Châu, Đà Nẵng', '0907778888'),
(N'Cửa Hàng E - Cần Thơ', N'202 Đường 30 Tháng 4, Ninh Kiều, Cần Thơ', '0909990000');

INSERT INTO NguoiDung (TaiKhoan, MatKhau, TenNguoiDung, Email, DiaChi, NgayTao, SoDienThoai, HoatDong, QuyenHan) VALUES
('admin01', '123', N'Nguyễn Văn A', 'admin01@aoshop.com', N'Quận 1, TP.HCM', '2023-01-15', '0912121212', 1, 0),
('quanlyb', 'hashed_pass_2', N'Trần Thị B', 'quanlyb@aoshop.com', N'Thủ Đức, TP.HCM', '2023-02-20', '0913131313', 1, 1),
('nhanvienc', 'hashed_pass_3', N'Lê Văn C', 'nhanvienc@aoshop.com', N'Hoàn Kiếm, Hà Nội', '2023-03-01', '0914141414', 1, 2),
('nhanviend', 'hashed_pass_4', N'Phạm Thị D', 'nhanviend@aoshop.com', N'Hải Châu, Đà Nẵng', '2023-04-10', '0915151515', 1, 2),
('quanlye', 'hashed_pass_5', N'Võ Văn E', 'quanlye@aoshop.com', N'Ninh Kiều, Cần Thơ', '2023-05-05', '0916161616', 1, 1);

INSERT INTO SanPham (TenSanPham, MoTa, HinhAnh) VALUES
(N'Áo Thun Cổ Tròn Basic', N'Áo thun cotton 100%, thoáng mát, form regular fit.', 'anh11.jpg'),
(N'Quần Jeans Slim Fit', N'Áo thun chất liệu denim co giãn, phom ôm vừa.', 'anh12.jpg'),
(N'Áo Khoác Bomber', N'Áo thun chất liệu dù, chống nước nhẹ, có khóa kéo.', 'anh13.webp'),
(N'Váy Maxi Họa Tiết', N'Áo thun maxi chất liệu voan, phù hợp đi biển/dạo phố.', 'anh14.webp'),
(N'Áo Sơ Mi Oxford', N'Áo thun vải oxford, kiểu dáng classic, dễ ủi.', 'anh15.webp');

INSERT INTO KichThuoc (TenKichThuoc) VALUES
('S'),
('M'),
('L'),
('XL'),
('XXL'),
('XXXL');

INSERT INTO MauSac (TenMau) VALUES
(N'Đen'),
(N'Trắng'),
(N'Xanh Navy'),
(N'Đỏ Đô'),
(N'Xám Tro');

INSERT INTO ChatLieu (TenChatLieu) VALUES
(N'Cotton 100%'),
(N'Denim Co Giãn'),
(N'Vải Dù'),
(N'Voan Lụa'),
(N'Oxford');

INSERT INTO ThuongHieu (TenThuongHieu, DiaChi, HinhAnh) VALUES
(N'Local Brand X', N'TP.HCM, Việt Nam', ''),
(N'Fashion House Y', N'Hà Nội, Việt Nam', ''),
(N'Urban Style Z', N'Đà Nẵng, Việt Nam', ''),
(N'Sport Gear W', N'Bình Dương, Việt Nam', ''),
(N'Elegant Clothes V', N'Long An, Việt Nam', '');

INSERT INTO BienThe (SanPham_ID, Color_ID, Size_ID, ThuongHieu_ID, ChatLieu_ID, BienTheHinhAnh, 
                      SanPhamId, MauSacId, KichThuocId, ThuongHieuId, ChatLieuId) VALUES
(1, 1, 4, 5, 1, 'anh11.jpg',1,1,4,5,1),
(2, 2, 3, 3, 2, 'anh12.jpg',2,2,3,3,2),
(4, 4, 3, 1, 4, 'anh13.jpg',4,4,3,1,4),
(5, 5, 5, 2, 5, 'anh14.jpg',5,5,5,2,5),
(3, 1, 5, 4, 3, 'anh15.jpg',3,1,5,4,3);

INSERT INTO TonKhoSP (CuaHang_ID, BienThe_ID, SoLuongTon, DonGia,CuaHangId,BienTheId) VALUES
(1, 1, 50, 199000,1,1),
(1, 2, 30, 199000,1,2),
(2, 3, 45, 450000,2,3),
(3, 4, 20, 780000,3,4),
(4, 5, 60, 399000,4,5);


select SP.*,BT.*,TK.* from [dbo].[SanPham] SP
INNER JOIN BienThe BT ON SP.Id = BT.SanPham_ID
INNER JOIN TonKhoSP TK ON BT.Id = TK.BienThe_ID
WHERE SP.Id = 1



