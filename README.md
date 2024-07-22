Thực hiện tạo một ứng dụng Web Api theo chuẩn RESTfull api quản lý thông tin sinh viên. Thông tin sinh viên bao gồm: Id, tên sinh viên (tối đa 50 ký tự), mã số sinh viên, ngày tháng năm sinh (chỉ nhập ngày). Thông tin lớp môn học gồm: Id, tên lớp (tối đa 50 ký tự), mã lớp (tối thiểu 5 ký tự), số sinh viên tối đa (số lớn hơn 0). Danh sách quan hệ giữa sinh viên và lớp môn học: Id, Id sinh viên, Id lớp môn học.
Thêm sinh viên, thêm lớp môn học, thêm nhiều sinh viên cùng lúc vào lớp học (thêm dạng list, ràng buộc số lượng phần tử phải lớn hơn 0)
Cập nhật thông tin sinh viên theo id sinh viên, cập nhật thông tin lớp môn học theo id lớp môn học
Lấy thông tin chi tiết sinh viên theo id, lấy thông tin lớp môn học theo id
Lấy danh sách sinh viên, lấy danh sách lớp môn học
Lấy danh sách sinh viên trong lớp theo id lớp (dùng hàm Join hoặc từ khoá join trong linq)
Xoá sinh viên theo id, Xoá lớp môn học theo id (kèm theo xoá sinh viên trong lớp)
Xử lý các action trong controller bằng try catch, tổ chức code theo service layer. Danh sách sinh viên quản lý bằng collection List
Kiểm tra ràng buộc dữ liệu trong các class model thêm, cập nhật.
