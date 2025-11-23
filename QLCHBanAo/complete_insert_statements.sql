-- INSERT đã được sửa - Bổ sung các cột foreign key bắt buộc cho bảng BienThe

INSERT INTO CuaHang (TenCuaHang, DiaChi, SDT) VALUES
(N'Cửa Hàng A - Quận 1', N'123 Đường Nguyễn Huệ, Q.1, TP.HCM', '0901112222'),
(N'Cửa Hàng B - Thủ Đức', N'456 Đường Võ Văn Ngân, TP. Thủ Đức', '0903334444'),
(N'Cửa Hàng C - Hà Nội', N'789 Phố Hàng Bài, Hoàn Kiếm, Hà Nội', '0905556666'),
(N'Cửa Hàng D - Đà Nẵng', N'101 Đường Trần Phú, Hải Châu, Đà Nẵng', '0907778888'),
(N'Cửa Hàng E - Cần Thơ', N'202 Đường 30 Tháng 4, Ninh Kiều, Cần Thơ', '0909990000'),
(N'Cửa Hàng F - Hải Phòng', N'303 Đường Lạch Tray, Ngô Quyền, Hải Phòng', '0910101010'),
(N'Cửa Hàng G - Huế', N'404 Đường Lê Lợi, TP. Huế', '0911223344'),
(N'Cửa Hàng H - Bình Dương', N'505 Đại Lộ Bình Dương, Thuận An', '0912345678'),
(N'Cửa Hàng I - Nha Trang', N'606 Đường Trần Phú, Nha Trang', '0913579135'),
(N'Cửa Hàng K - Tây Hồ', N'707 Phố Tô Ngọc Vân, Tây Hồ, Hà Nội', '0914701470');

INSERT INTO NguoiDung (TaiKhoan, MatKhau, TenNguoiDung, Email, DiaChi, NgayTao, SoDienThoai, HoatDong, QuyenHan) VALUES
('admin01', '123', N'Nguyễn Văn A', 'admin01@aoshop.com', N'Quận 1, TP.HCM', '2023-01-15', '0912121212', 1, 0),
('quanlyb', 'hashed_pass_2', N'Trần Thị B', 'quanlyb@aoshop.com', N'Thủ Đức, TP.HCM', '2023-02-20', '0913131313', 1, 1),
('nhanvienc', 'hashed_pass_3', N'Lê Văn C', 'nhanvienc@aoshop.com', N'Hoàn Kiếm, Hà Nội', '2023-03-01', '0914141414', 1, 2),
('nhanviend', 'hashed_pass_4', N'Phạm Thị D', 'nhanviend@aoshop.com', N'Hải Châu, Đà Nẵng', '2023-04-10', '0915151515', 1, 2),
('quanlye', 'hashed_pass_5', N'Võ Văn E', 'quanlye@aoshop.com', N'Ninh Kiều, Cần Thơ', '2023-05-05', '0916161616', 1, 1),
('nhanvienf', 'pass_6', N'Nguyễn Thị F', 'nv_f@aoshop.com', N'Hải Phòng', '2024-01-01', '0921212121', 1, 2), 
('quanlyg', 'pass_7', N'Hoàng Văn G', 'ql_g@aoshop.com', N'TP. Huế', '2024-01-15', '0923434343', 1, 1), 
('nhanvienh', 'pass_8', N'Trần Văn H', 'nv_h@aoshop.com', N'Bình Dương', '2024-02-01', '0925656565', 1, 2), 
('nhanvienk', 'pass_9', N'Mai Thị K', 'nv_k@aoshop.com', N'Nha Trang', '2024-02-20', '0927878787', 1, 2), 
('quanlym', 'pass_10', N'Đỗ Văn M', 'ql_m@aoshop.com', N'Tây Hồ, HN', '2024-03-05', '0929090909', 1, 1); 

INSERT INTO SanPham (TenSanPham, MoTa, HinhAnh) VALUES
(N'Áo Thun Cổ Tròn Basic', N'Áo thun cotton 100%, thoáng mát, form regular fit.', 'anh11.jpg'),
(N'Quần Jeans Slim Fit', N'Áo thun chất liệu denim co giãn, phom ôm vừa.', 'anh12.jpg'),
(N'Áo Khoác Bomber', N'Áo thun chất liệu dù, chống nước nhẹ, có khóa kéo.', 'anh13.webp'),
(N'Váy Maxi Họa Tiết', N'Áo thun maxi chất liệu voan, phù hợp đi biển/dạo phố.', 'anh14.webp'),
(N'Áo Sơ Mi Oxford', N'Áo thun vải oxford, kiểu dáng classic, dễ ủi.', 'anh15.webp'),
(N'Áo Thun Dry Fit Cao Cấp', N'Vải công nghệ Dry Fit, siêu nhẹ, thấm hút mồ hôi nhanh, thích hợp chạy bộ.', 'anh16.webp'),
(N'Áo Tập Gym Compression', N'Áo thun bó cơ, chất liệu co giãn 4 chiều, hỗ trợ cơ bắp.', 'anh17.webp'),
(N'Áo Chạy Bộ Phản Quang', N'Vải Poly Mesh thoáng khí, có chi tiết phản quang an toàn khi chạy đêm.', 'anh18.webp'),
(N'Áo Polo Thể Thao Golf', N'Cổ bẻ Pique, chống tia UV, thoáng mát cho môn Golf/Tennis.', 'anh19.webp'),
(N'Áo Tank Top Thể Hình', N'Thiết kế không tay (sát nách), form rộng rãi, cotton pha spandex.', 'anh20.webp');

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
(4, 4, 3, 1, 4, 'anh13.webp',4,4,3,1,4),
(5, 5, 5, 2, 5, 'anh14.webp',5,5,5,2,5),
(3, 1, 5, 4, 3, 'anh15.webp',3,1,5,4,3),
(6, 3, 5, 4, 1, 'anh16.webp', 6, 3, 5, 4, 1), 
(7, 1, 4, 4, 2, 'anh17.webp', 7, 1, 4, 4, 2),
(8, 5, 3, 4, 3, 'anh18.webp', 8, 5, 3, 4, 3), 
(9, 2, 2, 4, 5, 'anh19.webp', 9, 2, 2, 4, 5), 
(10, 4, 1, 4, 1, 'anh20.webp', 10, 4, 1, 4, 1);

INSERT INTO TonKhoSP (CuaHang_ID, BienThe_ID, SoLuongTon, DonGia,CuaHangId,BienTheId) VALUES
(1, 1, 50, 199000,1,1),
(1, 2, 30, 199000,1,2),
(2, 3, 45, 450000,2,3),
(3, 4, 20, 780000,3,4),
(4, 5, 60, 399000,4,5),
(5, 6, 120, 259000, 5, 6),   
(4, 7, 80, 380000, 4, 7),    
(3, 8, 90, 299000, 3, 8),    
(2, 9, 40, 450000, 2, 9),    
(1, 10, 150, 189000, 1, 10), 
(2, 1, 30, 210000, 2, 1),    
(3, 2, 15, 205000, 3, 2),    
(4, 3, 25, 460000, 4, 3),    
(5, 4, 35, 790000, 5, 4),    
(1, 5, 50, 400000, 1, 5); 

select SP.*,BT.*,TK.* from [dbo].[SanPham] SP
INNER JOIN BienThe BT ON SP.Id = BT.SanPham_ID
INNER JOIN TonKhoSP TK ON BT.Id = TK.BienThe_ID
WHERE SP.Id = 1



