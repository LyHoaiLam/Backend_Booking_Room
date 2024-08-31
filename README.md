Backend cho Project Next bài test website Booking phòng khách sạn
Sử dụng .NET 8, SQL Server, Table Room vs Table Booking.
Sử dụng vs Visual Stuio Code
gõ: cd api (Để vào Folder api)
gõ: dotnet watch run (để chạy swagger)

Để chạy local Project trong UI Call API được thì để port là 5120 (http://localhost:5102)
http://localhost:5102/swagger/index.html


Chuỗi data kết nối tới Database
"DefaultConnect": "Data Source=LAPTOP-LQSIG9GU;Initial Catalog=hotelbooking;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

Có thể sửa chuỗi để chạy cd api để vào Folder api, sau đ1o gõ dotnet ef migrations add init -> để update databse gõ: dotnet ef databse update
