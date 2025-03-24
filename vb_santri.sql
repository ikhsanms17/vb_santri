-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versi server:                 8.0.30 - MySQL Community Server - GPL
-- OS Server:                    Win64
-- HeidiSQL Versi:               12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Membuang struktur basisdata untuk vb_santri
CREATE DATABASE IF NOT EXISTS `vb_santri` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `vb_santri`;

-- membuang struktur untuk table vb_santri.detail_perizinan
CREATE TABLE IF NOT EXISTS `detail_perizinan` (
  `id` int NOT NULL AUTO_INCREMENT,
  `perizinan_id` int NOT NULL,
  `hubungan` varchar(255) NOT NULL,
  `keperluan` text NOT NULL,
  `alamat_tujuan` text NOT NULL,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `deleted_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `perizinan_id` (`perizinan_id`),
  CONSTRAINT `detail_perizinan_ibfk_1` FOREIGN KEY (`perizinan_id`) REFERENCES `perizinan` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Membuang data untuk tabel vb_santri.detail_perizinan: ~0 rows (lebih kurang)

-- membuang struktur untuk table vb_santri.detail_transaksi
CREATE TABLE IF NOT EXISTS `detail_transaksi` (
  `id` int NOT NULL AUTO_INCREMENT,
  `transaksi_id` int NOT NULL,
  `setoran` decimal(15,2) DEFAULT '0.00',
  `penarikan` decimal(15,2) DEFAULT '0.00',
  `saldo` decimal(15,2) NOT NULL,
  `keterangan` text,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `deleted_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `transaksi_id` (`transaksi_id`),
  CONSTRAINT `detail_transaksi_ibfk_1` FOREIGN KEY (`transaksi_id`) REFERENCES `transaksi` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Membuang data untuk tabel vb_santri.detail_transaksi: ~0 rows (lebih kurang)

-- membuang struktur untuk table vb_santri.kelas
CREATE TABLE IF NOT EXISTS `kelas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nama` varchar(255) NOT NULL,
  `deskripsi` text,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `deleted_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Membuang data untuk tabel vb_santri.kelas: ~6 rows (lebih kurang)
INSERT INTO `kelas` (`id`, `nama`, `deskripsi`, `created_at`, `updated_at`, `deleted_at`) VALUES
	(1, 'Kelas 1 SD', 'Kelas untuk tingkat 1 SD', '2025-03-24 03:27:19', '2025-03-24 03:27:19', NULL),
	(2, 'Kelas 2 SD', 'Kelas untuk tingkat 2 SD', '2025-03-24 03:27:19', '2025-03-24 03:27:19', NULL),
	(3, 'Kelas 3 SD', 'Kelas untuk tingkat 3 SD', '2025-03-24 03:27:19', '2025-03-24 03:27:19', NULL),
	(4, 'Kelas 4 SD', 'Kelas untuk tingkat 4 SD', '2025-03-24 03:27:19', '2025-03-24 03:27:19', NULL),
	(5, 'Kelas 5 SD', 'Kelas untuk tingkat 5 SD', '2025-03-24 03:27:19', '2025-03-24 03:27:19', NULL),
	(6, 'Kelas 6 SD', 'Kelas untuk tingkat 6 SD', '2025-03-24 03:27:19', '2025-03-24 03:27:19', NULL);

-- membuang struktur untuk table vb_santri.metode_pembayaran
CREATE TABLE IF NOT EXISTS `metode_pembayaran` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nama_pembayaran` varchar(255) NOT NULL,
  `deskripsi` text,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `deleted_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Membuang data untuk tabel vb_santri.metode_pembayaran: ~0 rows (lebih kurang)

-- membuang struktur untuk table vb_santri.perizinan
CREATE TABLE IF NOT EXISTS `perizinan` (
  `id` int NOT NULL AUTO_INCREMENT,
  `no_izin` varchar(50) NOT NULL,
  `pengguna_id` int NOT NULL,
  `tanggal_izin` date NOT NULL,
  `nama_penjemput` varchar(255) NOT NULL,
  `tanggal_batas_izin` date NOT NULL,
  `tanggal_datang` date DEFAULT NULL,
  `status` enum('Dizinkan','Tidak Dizinkan') NOT NULL DEFAULT 'Tidak Dizinkan',
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `deleted_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `no_izin` (`no_izin`),
  KEY `pengguna_id` (`pengguna_id`),
  CONSTRAINT `perizinan_ibfk_1` FOREIGN KEY (`pengguna_id`) REFERENCES `users` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Membuang data untuk tabel vb_santri.perizinan: ~0 rows (lebih kurang)

-- membuang struktur untuk table vb_santri.roles
CREATE TABLE IF NOT EXISTS `roles` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nama` enum('santri','petugas','admin') NOT NULL,
  `deskripsi` text,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `deleted_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Membuang data untuk tabel vb_santri.roles: ~3 rows (lebih kurang)
INSERT INTO `roles` (`id`, `nama`, `deskripsi`, `created_at`, `updated_at`, `deleted_at`) VALUES
	(1, 'santri', 'Pengguna yang berstatus santri', '2025-03-24 03:27:19', '2025-03-24 03:27:19', NULL),
	(2, 'petugas', 'Pengguna yang berstatus petugas', '2025-03-24 03:27:19', '2025-03-24 03:27:19', NULL),
	(3, 'admin', 'Pengguna dengan hak admin', '2025-03-24 03:27:19', '2025-03-24 03:27:19', NULL);

-- membuang struktur untuk table vb_santri.transaksi
CREATE TABLE IF NOT EXISTS `transaksi` (
  `id` int NOT NULL AUTO_INCREMENT,
  `no_transaksi` varchar(50) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `tanggal_transaksi` date NOT NULL,
  `metode_pembayaran_id` int NOT NULL,
  `petugas_id` int NOT NULL,
  `pengguna_id` int NOT NULL,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `deleted_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `no_transaksi` (`no_transaksi`),
  KEY `metode_pembayaran_id` (`metode_pembayaran_id`),
  KEY `petugas_id` (`petugas_id`),
  KEY `pengguna_id` (`pengguna_id`),
  CONSTRAINT `transaksi_ibfk_1` FOREIGN KEY (`metode_pembayaran_id`) REFERENCES `metode_pembayaran` (`id`) ON DELETE CASCADE,
  CONSTRAINT `transaksi_ibfk_2` FOREIGN KEY (`petugas_id`) REFERENCES `users` (`id`) ON DELETE CASCADE,
  CONSTRAINT `transaksi_ibfk_3` FOREIGN KEY (`pengguna_id`) REFERENCES `users` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Membuang data untuk tabel vb_santri.transaksi: ~0 rows (lebih kurang)

-- membuang struktur untuk table vb_santri.users
CREATE TABLE IF NOT EXISTS `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nama` varchar(255) NOT NULL,
  `nama_pengguna` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `kata_sandi` varchar(255) NOT NULL,
  `nis` varchar(50) DEFAULT NULL,
  `kelas_id` int DEFAULT NULL,
  `jenis_kelamin` enum('Laki-laki','Perempuan') NOT NULL,
  `tanggal_lahir` date DEFAULT NULL,
  `nama_ayah` varchar(255) DEFAULT NULL,
  `nama_ibu` varchar(255) DEFAULT NULL,
  `alamat` text,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `deleted_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nama_pengguna` (`nama_pengguna`),
  UNIQUE KEY `email` (`email`),
  UNIQUE KEY `nis` (`nis`),
  KEY `kelas_id` (`kelas_id`),
  CONSTRAINT `users_ibfk_1` FOREIGN KEY (`kelas_id`) REFERENCES `kelas` (`id`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Membuang data untuk tabel vb_santri.users: ~3 rows (lebih kurang)
INSERT INTO `users` (`id`, `nama`, `nama_pengguna`, `email`, `kata_sandi`, `nis`, `kelas_id`, `jenis_kelamin`, `tanggal_lahir`, `nama_ayah`, `nama_ibu`, `alamat`, `created_at`, `updated_at`, `deleted_at`) VALUES
	(1, 'Haddad Hikmah M', 'haddadhikmahm', 'haddadhikmahm@gmail.com', 'ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f', NULL, NULL, 'Laki-laki', '1995-06-15', 'Bapak Haddad', 'Ibu Haddad', 'Bandung', '2025-03-24 03:27:19', '2025-03-24 03:27:19', NULL),
	(2, 'Ikhsan Maulana Saputra', 'ikhsanmaulanasaputra', 'ikhsanmaulanasaputra@gmail.com', 'ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f', NULL, NULL, 'Laki-laki', '1995-06-15', 'Bapak Ikhsan', 'Ibu Ikhsan', 'Bandung', '2025-03-24 03:27:19', '2025-03-24 03:27:19', NULL),
	(3, 'Muhammad Sofyan', 'muhmmadsofyan', 'muhmmadsofyan@gmail.com', 'ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f', NULL, NULL, 'Laki-laki', '1995-06-15', 'Bapak Sofyan', 'Ibu Sofyan', 'Bandung', '2025-03-24 03:27:19', '2025-03-24 03:27:19', NULL);

-- membuang struktur untuk table vb_santri.user_role
CREATE TABLE IF NOT EXISTS `user_role` (
  `id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `role_id` int NOT NULL,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `deleted_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `user_id` (`user_id`),
  KEY `role_id` (`role_id`),
  CONSTRAINT `user_role_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`) ON DELETE CASCADE,
  CONSTRAINT `user_role_ibfk_2` FOREIGN KEY (`role_id`) REFERENCES `roles` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Membuang data untuk tabel vb_santri.user_role: ~0 rows (lebih kurang)

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
