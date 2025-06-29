# 👨‍💼 Personel Kayıt Sistemi

Windows Forms ile geliştirilen bu uygulama, personel bilgilerini SQL Server veritabanında tutarak kullanıcıya; kayıt ekleme, silme, güncelleme, listeleme, grafiksel analiz ve istatistiksel bilgiler sunma imkânı verir.

## 🛠️ Kullanılan Teknolojiler
- C# (.NET Framework)
- Windows Forms
- SQL Server (MSSQL)
- ADO.NET (SqlConnection, SqlCommand)
- DataGridView, RadioButton, ComboBox gibi Form bileşenleri

## 📸 Ekran Görüntüleri
> Görselleri buraya ekleyebilirsiniz  
> Örn: `![Ekran Görüntüsü](screenshots/form1.png)`

## 🚀 Başlangıç

Projeyi çalıştırmak için aşağıdaki adımları izleyin:

### 1. Projeyi Kopyalayın
```bash
git clone https://github.com/kullaniciadi/PersonelKayitSistemi.git
```

### 2. Visual Studio ile Açın
`PersonelKayitSistemi.sln` dosyasını çift tıklayarak Visual Studio ile açın.

### 3. SQL Server Veritabanı Ayarları
Aşağıdaki SQL komutları ile veritabanını oluşturun:
```sql
CREATE DATABASE PersonelVeriTabani;
GO
USE PersonelVeriTabani;

CREATE TABLE Tbl_Personel (
    Perİd INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    PerAd VARCHAR(30) NOT NULL,
    PerSoyad VARCHAR(30) NOT NULL,
    PerSehir VARCHAR(35) NOT NULL,
    PerMaas INT NOT NULL,
    PerDurum BIT NOT NULL,
    PerMeslek VARCHAR(40) NOT NULL
);

CREATE TABLE Tbl_Yonetici (
    KullaniciAd VARCHAR(30) NOT NULL,
    Sifre VARCHAR(30) NOT NULL
);

INSERT INTO Tbl_Yonetici (KullaniciAd, Sifre)
VALUES ('istediginiz giris parolasi', 'istediğiniz sifre');
```

### 4. Bağlantı Ayarları
`FrmAnaForm.cs` içinde bağlantı şu şekilde yapılandırılmıştır:
```csharp
SqlConnection baglanti = new SqlConnection(
    "Data Source=bilgisayar_adiniz\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True;TrustServerCertificate=True");
```
Kendi bilgisayarınıza göre `Data Source` kısmını düzenlemeyi unutmayın.

## 🧪 Özellikler
- [x] Giriş paneli (Yönetici adı ve şifre ile)
- [x] Personel ekleme
- [x] Personel silme
- [x] Güncelleme
- [x] Listeleme
- [x] Grafik gösterimi (`frmGrafik`)
- [x] İstatistik sayfası (`frmIstatistik`)

## 👥 Katkıda Bulunma
1. Fork'la 🍴  
2. Yeni bir dal (branch) oluştur 🌿  
3. Değişiklik yap ve commit et 💾  
4. Pull Request gönder 📩

## 📄 Lisans
Bu proje kişisel eğitim amaçlı oluşturulmuştur. Gönül rahatlığıyla inceleyebilir, geliştirebilir veya kaynak olarak kullanabilirsiniz.

---

**Hazırlayan:** [bawerzdmr02]  
**Proje:** Personel-Kayit-Otomasyonu
