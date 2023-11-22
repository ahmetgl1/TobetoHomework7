# Amaç

Bu proje, .NET Core tabanlı uygulamalarda birden fazla Object-Relational Mapping (ORM) aracı kullanımını soyutlamayı hedefler. Özellikle Entity Framework ve Dapper gibi farklı ORM'leri kullanmak isteyen geliştiricilere esneklik sağlamak amaçlanmıştır.

## Proje Hedefleri

- Farklı ORM araçlarını (örneğin, Entity Framework, Dapper) destekleme.
- ORM kullanımını soyutlayarak, uygulama kodlarını belirli bir ORM'e bağlı kalmadan yazabilme.
- Geliştiricilere, projede tercih ettikleri ORM aracını kolayca değiştirme esnekliği sunma.

Bu proje, farklı ORM araçlarını denemek, karşılaştırmak ve projelerde kullanmak isteyen geliştiricilere rehberlik etmeyi amaçlamaktadır.

## Proje Yapısı

### Business Katmanı
- **CategoryManager.cs:** Kategori işlemleri için iş mantığı.
- **ProductManager.cs:** Ürün işlemleri için iş mantığı.

### DataAccess Katmanı
- **EFCategoryDal.cs:** Kategori veritabanı işlemleri için Entity Framework implementasyonu.
- **EFProductDal.cs:** Ürün veritabanı işlemleri için Entity Framework implementasyonu.
- **InMemoryProductDal.cs:** Ürün veritabanı işlemleri için InMemory implementasyonu.

### Entities
- **Category.cs:** Kategori nesnesi.
- **Product.cs:** Ürün nesnesi.
- **ProductDetailsDto.cs:** Ürün detayları veri transfer nesnesi.

### Core
- **IEntity.cs:** Tüm varlık nesneleri için temel arayüz.
- **IDto.cs:** Data Transfer Object (DTO) arayüzü.
- **IEntityRepository.cs:** Genel veritabanı işlemleri için arayüz.

### ConsoleUI
- **Program.cs:** Konsol uygulamasının giriş noktası.
