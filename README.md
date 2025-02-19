# 🎟️ EventGo

**EventGo** adalah aplikasi manajemen acara yang memungkinkan pengguna untuk mengelola event, mengatur tiket, dan mencatat transaksi secara real-time.

## 📌 Fitur Utama

✅ **Manajemen Event** - Tambah, edit, dan lihat informasi detail event.\
✅ **Manajemen Tiket** - Pantau jumlah stok tiket yang tersedia dan tiket yang terjual.\
✅ **Manajemen Sponsor** - Catat pendapatan dari sponsor acara.\
✅ **Ringkasan Keuangan** - Hitung total pendapatan dari penjualan tiket dan sponsorship.\
✅ **Analisis Data** - Lihat persentase penjualan tiket dan kontribusi sponsor terhadap total pendapatan.

## 🛠️ Teknologi yang Digunakan

- **C#** - Backend utama menggunakan .NET Framework.
- **Windows Forms** - UI berbasis Windows Forms untuk kemudahan penggunaan.
- **Entity Framework Core** - ORM untuk menghubungkan aplikasi dengan database.
- **SQL Server** - Database utama untuk menyimpan data acara, tiket, transaksi, dan sponsor.

## 📂 Struktur Proyek

```
EventGo/
│── EventGo.sln         # File solusi utama
│── EventGo/            # Folder utama aplikasi
│   │── Models/         # Model untuk database
│   │── Forms/          # Form UI aplikasi
│   │── DataContext.cs  # Koneksi ke database
│   │── Program.cs      # Entry point aplikasi
│   └── App.config      # Konfigurasi aplikasi
│── README.md           # Dokumentasi proyek
└── ...
```

## 📸 Preview Tampilan



## 🚀 Cara Menjalankan Aplikasi

1. **Clone repositori** ini:
   ```sh
   git clone https://github.com/username/EventGo.git
   cd EventGo
   ```
2. **Buka di Visual Studio** dan jalankan `EventGo.sln`.
3. **Pastikan database tersedia**, lalu jalankan migrasi jika diperlukan:
   ```sh
   dotnet ef database update
   ```
4. **Jalankan aplikasi** dengan menekan tombol ▶️ di Visual Studio.

## 🤝 Kontribusi

1. Fork proyek ini.
2. Buat branch baru: `git checkout -b fitur-baru`.
3. Commit perubahan: `git commit -m "Menambahkan fitur baru"`.
4. Push ke branch: `git push origin fitur-baru`.
5. Buat pull request!

## 📜 Lisensi

MIT License © 2025 EventGo Developers.

---

✨ **Dibuat dengan ❤️ oleh Tim EventGo** ✨

