# SignalRProject

Bu proje, Murat Yücedağ'ın Udemy'de bulunan "Asp.Net Core Api SignalR ile QR Kodlu Sipariş Yönetimi" kursunda yapmış olduğum bir projedir. Proje, hem kullanıcı dostu bir arayüz hem de güçlü bir admin paneli sunar.


## 🚀 Proje Özellikleri  

### **Restoran Arayüzü**  
Admin paneli ve SignalR sayesinde dinamik bir şekilde güncellenebilir bilgiler ile kullanıcı dostu bir arayüz tasarlanmıştır.
- Slider ve görsellerle bilgilendirici açıklamalar
- İndirimler
- Başlıca menüdeki ürünler
- Hakkımızda bölümü
- İletişim formu ve harita
- Müşteri yorumları
- Masa seçimi yapılabilir ve QR ile ulaşılabilir
- Menüden sepete ekleme işlemi yapılabilir
- Sepetteki ürünler ve fiyat görüntülenebilir
- Anlık mesaşlaşma sayfasından iletişime geçilebilir
- Tarifler sayfası ile bazı tarif detaylarına ve videosuna erişilebilir
- Rezervasyon formu ve haritalar


### **Admin Paneli**  
Admin paneli, restoranımızı yönetmek için kapsamlı bir kontrol sağlar. Panelde **CRUD (Create, Read, Update, Delete)** işlemleri yapılabilir.
- **Giriş Sayfası:** Sisteme kullanıcı adı ve şifre ile girmeyi sağlar.
- **Kayıt Sayfası:** Sisteme kayıt olmayı sağlar.
- **Siteye Git:** Kullanıcı arayüzüne geçiş yapar.
- **Durum Çubuğu:** SignalR ile anlık istatistikler görüntülenir.
- **Menüyü Gör:** Menü sayfasına geçiş yapar.
- **Kategoriler:** Kategorileri düzenleyebilirsiniz.
- **Ürünler:** Ürünleri ve durumlarını(var-yok) düzenleyebilirsiniz.
- **Rezervasyonlar:** SignalR ile Rezervasyonlar görüntülenir, düzenleyebilirsiniz.
- **Masalar:** Masa ekleme düzenleme yapılabilir. Masaların durumu SignalR ile görüntülenir.
- **Hakkımızda:** Restoran bilgilerini düzenleyebilirsiniz.  
- **İndirimler:** İndirimleri ekleyebilir, düzenleyebilirsiniz. Aktif-Pasif yaparak görünürlüğünü değiştirebilirsiniz.
- **İletişim Bilgileri:** Telefon, e-posta ve adres bilgilerinizi düzenleyebilirsiniz.  
- **Mesaj Sayfası:** Anlık mesajlaşma sayfasına yönlendirir.
- **Öne Çıkanlar:** Slider düzenlenir.
- **Bildirimler:** Okunmayan bildirimler Navbarda görüntülenir. Tüm bildirim düzenlemeleri buradan yapılır.
- **Referanslar:** Müşteri yorumları görüntülenir, düzenlenir. 
- **Sosyal Medya:** Sosyal medya hesaplarınızı ekleyebilir, düzenleyebilirsiniz.
- **İstatistikler:** Mevcut istatistikleri SignalR ile dinamik olarak takip edebilirsiniz.  
- **Ayarlar:** Giriş bilgilerini düzenleyebilirsiniz.
- **Mail İşlemleri:** Mevcut mail adresinizden mail gönderebilirsiniz.
- **QR Oluşturma:** QR kod oluşturarak masa takibi yapabilirsiniz.
- **Çıkış Yap:** Sistemden çıkış yapabilirsiniz.


## 🛠️ Kullanılan Teknolojiler  

- **ASP.NET Core 8:** Projenin temel çatısını oluşturur.  
- **Entity Framework (Code-First Yaklaşımı):** Veritabanı işlemleri için kullanılmıştır.  
- **MSSQL:** Veritabanı yönetimi için tercih edilmiştir.  
- **View Components:** Projede dinamik içerik oluşturmak için kullanılmıştır.  
- **HTML, CSS, Bootstrap:** Kullanıcı arayüzü için modern ve duyarlı tasarım.  
- **JavaScript:** Arayüzdeki dinamik etkileşimler için kullanılmıştır.  
- **SignalR:** Dinamik verilerin anlık görüntülenmesinde kullanılmıştır.
- **Swagger:** API işlemlerinde kullanılmıştır.  


## 📸 Ekran Görüntüleri  

### Kullanıcı Arayüzü  
![](SignalRWebUI/EkranGoruntuleri/localhost_7088_Default_Index.png)
![](SignalRWebUI/EkranGoruntuleri/localhost_7088_Menu_Index_.png)
![](SignalRWebUI/EkranGoruntuleri/localhost_7088_CustomerTable_CustomerTableList_.png)
![](SignalRWebUI/EkranGoruntuleri/localhost_7088_FoodRapidApi_Index_.png)
![](SignalRWebUI/EkranGoruntuleri/localhost_7088_Message_Index_.png)
![](SignalRWebUI/EkranGoruntuleri/localhost_7088_Baskets_Index_14.png)
![](SignalRWebUI/EkranGoruntuleri/localhost_7088_BookATable_Index_.png)




### Admin Paneli  
![](SignalRWebUI/EkranGoruntuleri/localhost_7088_Register_Index_.png)
![](SignalRWebUI/EkranGoruntuleri/localhost_7088_Login_Index.png)
![](SignalRWebUI/EkranGoruntuleri/localhost_7088_ProgressBars_Index_.png)
![](SignalRWebUI/EkranGoruntuleri/localhost_7088_Category_Index_.png)
![](SignalRWebUI/EkranGoruntuleri/localhost_7088_Product_Index_.png)
![](SignalRWebUI/EkranGoruntuleri/localhost_7088_Booking.png)
![](SignalRWebUI/EkranGoruntuleri/localhost_7088_MenuTables_Index_.png)
![](SignalRWebUI/EkranGoruntuleri/localhost_7088_MenuTables_TableListByStatus_.png)
![](SignalRWebUI/EkranGoruntuleri/localhost_7088_About_Index_.png)
![](SignalRWebUI/EkranGoruntuleri/localhost_7088_Discount_Index_.png)
![](SignalRWebUI/EkranGoruntuleri/localhost_7088_Slider_Index_.png)
![](SignalRWebUI/EkranGoruntuleri/localhost_7088_Notifications_Index_.png)
![](SignalRWebUI/EkranGoruntuleri/localhost_7088_Testimonial_Index_.png)
![](SignalRWebUI/EkranGoruntuleri/localhost_7088_SocialMedia_Index_.png)
![](SignalRWebUI/EkranGoruntuleri/localhost_7088_Statistic_Index_.png)
![](SignalRWebUI/EkranGoruntuleri/localhost_7088_Setting_Index_.png)
![](SignalRWebUI/EkranGoruntuleri/localhost_7088_Mail_Index_.png)
![](SignalRWebUI/EkranGoruntuleri/localhost_7088_QRCode.png)




### Swagger  
![](SignalRWebUI/EkranGoruntuleri/localhost_44321_swagger_index.html.png)






