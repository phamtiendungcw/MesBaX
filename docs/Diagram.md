Trong Clean Architecture, các project được tổ chức theo các lớp (layers) có sự phụ thuộc được định hướng rõ ràng để đảm bảo tính độc lập, dễ bảo trì, và dễ kiểm thử. Dưới đây là mô tả sự liên kết (reference) giữa các project `Application`, `Infrastructure`, `Persistence`, `Domain`, và `Server` trong một ứng dụng .NET Core sử dụng Clean Architecture:

**1. Domain (Lớp lõi - Core):**

*   **Độc lập:** Domain layer là lớp độc lập nhất, **không phụ thuộc vào bất kỳ project nào khác**. Nó chứa các entities, value objects, domain services, và các interfaces (repositories, ...).
*   **Chỉ chứa logic nghiệp vụ cốt lõi:** Không chứa logic liên quan đến database, UI, framework, hay các yếu tố bên ngoài.

**2. Application (Lớp ứng dụng):**

*   **Phụ thuộc vào:** `Domain`.
*   **Chứa:**
    *   **Use Cases (Application Services):** Triển khai các use cases của hệ thống, điều phối luồng xử lý, gọi các entities và domain services trong `Domain`.
    *   **Interfaces (Abstractions):** Định nghĩa các interfaces cho các services sẽ được triển khai ở các lớp bên ngoài (ví dụ: `IProductRepository`, `IEmailService`).
    *   **DTOs (Data Transfer Objects):**  Định nghĩa các DTOs để truyền dữ liệu giữa các lớp.
    *   **Command & Query Handlers:** Triển khai các handlers cho các commands và queries (nếu sử dụng CQRS).
*   **Không phụ thuộc vào:** `Infrastructure`, `Persistence`, `Server` (các lớp bên ngoài).

**3. Infrastructure (Lớp cơ sở hạ tầng):**

*   **Phụ thuộc vào:** `Application` (để triển khai các interfaces), `Domain` (để sử dụng các entities dùng chung).
*   **Chứa:**
    *   **Triển khai các interfaces của `Application`:** Các services liên quan đến các yếu tố bên ngoài (email, caching, message queue, ...).
    *   **Các adapters:** Để giao tiếp với các hệ thống bên ngoài.
    *   **Các services:** Cụ thể để gọi các lớp bên ngoài
    *   Có thể chứa các **module riêng** cho từng loại infrastructure (ví dụ: `Infrastructure.Email`, `Infrastructure.Caching`, `Infrastructure.SMS`, ...).
*   **Không phụ thuộc vào:** `Persistence`, `Server`.

**4. Persistence (Lớp persistence - ORM):**

*   **Phụ thuộc vào:** `Application` (để triển khai các interfaces repositories), `Domain` (để map các entities).
*   **Chứa:**
    *   **Entity Framework Core DbContext:** Định nghĩa `DbContext` để tương tác với database.
    *   **Entity Configurations:** Cấu hình mapping giữa các entities và bảng trong database (sử dụng Fluent API).
    *   **Repositories:** Triển khai các repositories interfaces được định nghĩa trong `Application` (ví dụ: `ProductRepository`).
    *   **Migrations:** Chứa các migration files để tạo và cập nhật database schema.
*   **Không phụ thuộc vào:** `Infrastructure`, `Server`.

**5. Server (Presentation - Lớp trình bày - API):**

*   **Phụ thuộc vào:** `Application` (để gọi các use cases/application services), có thể dùng thêm `Infrastructure`
*   **Chứa:**
    *   **Controllers:** Định nghĩa các API controllers.
    *   **ViewModels:** Có thể sử dụng ViewModels để định dạng dữ liệu trả về cho client.
    *   **Startup:** Cấu hình dependency injection, routing, middleware, ...
    *   **Program:** Điểm khởi chạy ứng dụng.
*   **Không phụ thuộc vào:** `Domain`, `Persistence`, `Infrastructure` (trực tiếp).

**Sơ đồ tham khảo:**

```
                                    +-----------------+
                                    |      Server     |  <-- UI (Angular)
                                    +-----------------+
                                          ^      |
                                          |      | (References)
                                          |      v
                    +-----------------+   |   +-----------------+
                    |   Application   |---+---|  Infrastructure |
                    +-----------------+       +-----------------+
                             ^                         ^
                             |                         |
                             | (References)            | (References)
                             |                         |
                    +-----------------+       +-----------------+
                    |     Domain      |       |   Persistence   |
                    +-----------------+       +-----------------+
```

**Mô tả:**

*   UI (ví dụ: Angular) sẽ gọi các API endpoints của `Server`.
*   `Server` gọi các use cases/application services trong `Application`.
*   `Application` sử dụng các entities và domain services trong `Domain`, đồng thời gọi các repositories trong `Persistence` hoặc các services trong `Infrastructure` thông qua các interfaces.
*   `Persistence` triển khai các repositories để tương tác với database.
*   `Infrastructure` triển khai các services để tương tác với các hệ thống bên ngoài (email, caching, ...).
*   `Domain` độc lập, không phụ thuộc vào bất kỳ project nào.