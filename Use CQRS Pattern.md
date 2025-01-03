**PHẦN I: CÁC ENTITY NÊN CÂN NHẮC SỬ DỤNG CQRS**

*   **Lý do:** Các entity này có nghiệp vụ phức tạp, liên quan đến nhiều thao tác, nhiều use case, hoặc có yêu cầu cao về hiệu năng, khả năng mở rộng, cần đảm bảo tính toàn vẹn dữ liệu.

1. **Order (Đơn hàng):**
    *   Command: Tạo đơn hàng, cập nhật trạng thái, hủy đơn hàng, xử lý thanh toán, ...
    *   Query: Lấy danh sách đơn hàng, xem chi tiết đơn hàng, thống kê đơn hàng, ...
2. **Product (Sản phẩm):**
    *   Command: Thêm, sửa, xóa sản phẩm, cập nhật số lượng tồn kho, ...
    *   Query: Tìm kiếm sản phẩm, lấy thông tin sản phẩm, lấy danh sách sản phẩm liên quan, ...
3. **Customer (Khách hàng):**
    *   Command: Thêm, sửa thông tin khách hàng, ...
    *   Query: Lấy thông tin khách hàng, lấy danh sách khách hàng theo tiêu chí, ...
4. **InventoryTransaction (Giao dịch kho):**
    *   Command: Cập nhật số lượng tồn kho (nhập/xuất/điều chỉnh).
    *   Query: Xem lịch sử giao dịch kho, xem số lượng tồn kho.
5. **Review (Đánh giá sản phẩm):**
    *   Command: Tạo đánh giá, ẩn/hiện đánh giá.
    *   Query: Lấy danh sách đánh giá sản phẩm, tính điểm đánh giá trung bình.
6. **User (Người dùng):** (Nếu có nghiệp vụ phức tạp)
    *   Command: Thêm, sửa, xóa người dùng, phân quyền, ...
    *   Query: Lấy thông tin người dùng, kiểm tra quyền truy cập, ...
7. **Payment (Thanh toán):**
    *   Command: Xử lý thanh toán, cập nhật trạng thái thanh toán, hoàn tiền
    *   Query: Lấy danh sách thanh toán, lấy thông tin chi tiết thanh toán

**PHẦN II: CÁC ENTITY CÓ THỂ KHÔNG CẦN SỬ DỤNG CQRS**

*   **Lý do:** Các entity này thường có nghiệp vụ đơn giản (CRUD), ít thay đổi, không có yêu cầu cao về hiệu năng, hoặc thứ tự ưu tiên triển khai CQRS thấp hơn.

1. **Category (Danh mục)**
2. **Supplier (Nhà cung cấp)**
3. **Role (Vai trò)**
4. **ProductAttribute (Thuộc tính sản phẩm)**
5. **ProductAttributeValue (Giá trị thuộc tính)**
6. **Product_Attribute_Mapping (Ánh xạ sản phẩm - thuộc tính)**
7. **Wishlist (Danh sách yêu thích)**
8. **Cart (Giỏ hàng):** (Có thể cân nhắc dùng CQRS nếu giỏ hàng cần lưu lâu dài phiên của khách hàng)
9. **CartItem (Sản phẩm trong giỏ hàng)**
10. **ShippingMethod (Phương thức vận chuyển)**
11. **Promotion (Khuyến mãi)**
12. **SocialMediaPost (Bài đăng mạng xã hội)**
13. **AdCampaign (Chiến dịch quảng cáo)**
14. **AdCampaignResult (Kết quả chiến dịch)**
15. **CustomerAddress (Địa chỉ khách hàng)**
16. **CustomerGroup (Nhóm khách hàng)**
17. **Customer_CustomerGroup_Mapping (Ánh xạ KH - nhóm KH)**
18. **Tax (Thuế)**
19. **ProductTax (Thuế sản phẩm)**
20. **Discount (Giảm giá)**
21. **Discount_AppliedTo_Products (Ánh xạ giảm giá - sản phẩm)**
22. **Discount_AppliedTo_Categories (Ánh xạ giảm giá - danh mục)**
23. **GiftCard (Thẻ quà tặng)**
24. **GiftCardUsageHistory (Lịch sử sử dụng thẻ quà tặng)**
25. **ReturnRequest (Yêu cầu trả hàng)**
26. **BlogPost (Bài đăng blog)**
27. **BlogComment (Bình luận blog)**
28. **NewsletterSubscription (Đăng ký nhận bản tin)**
29. **Affiliate (Cộng tác viên)**
30. **OrderAffiliate (Đơn hàng từ cộng tác viên)**
31. **Vendor (Nhà bán hàng)**
32. **VendorProduct (Sản phẩm từ nhà bán hàng)**
33. **User_Customer_Mapping (Ánh xạ người dùng - khách hàng)**
34. **OrderDetail (Chi tiết đơn hàng):** (Có thể cân nhắc nếu cần tối ưu hoá cao)