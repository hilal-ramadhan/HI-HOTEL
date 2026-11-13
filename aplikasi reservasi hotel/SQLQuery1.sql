-- Membuat Database
CREATE DATABASE HotelDB;
GO

USE HotelDB;
GO

-- =========================================
-- 1. TABEL USERS
-- =========================================
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(100) NOT NULL,
    Role VARCHAR(20) NOT NULL
);
GO

-- Data akun Admin dan Resepsionis
INSERT INTO Users (Username, Password, Role)
VALUES
('admin', 'admin123', 'Admin'),
('resep01', '12345', 'Resepsionis');
GO


-- =========================================
-- 2. TABEL TAMU
-- =========================================
CREATE TABLE Tamu (
    TamuID INT IDENTITY(1,1) PRIMARY KEY,
    Nama VARCHAR(100) NOT NULL,
    NoHP VARCHAR(20) NOT NULL,
    Alamat VARCHAR(200)
);
GO


-- =========================================
-- 3. TABEL KAMAR
-- =========================================
CREATE TABLE Kamar (
    KamarID INT IDENTITY(1,1) PRIMARY KEY,
    NoKamar VARCHAR(10) NOT NULL UNIQUE,
    TipeKamar VARCHAR(30) NOT NULL,
    Harga DECIMAL(12,2) NOT NULL,
    Status VARCHAR(20) NOT NULL DEFAULT 'Tersedia'
);
GO


-- =========================================
-- 4. TABEL RESERVASI
-- =========================================
CREATE TABLE Reservasi (
    ReservasiID INT IDENTITY(1,1) PRIMARY KEY,
    TamuID INT NOT NULL,
    KamarID INT NOT NULL,
    CheckIn DATE NOT NULL,
    CheckOut DATE NOT NULL,
    TotalBayar DECIMAL(12,2) NOT NULL,
    Status VARCHAR(20) NOT NULL DEFAULT 'Booking',

    CONSTRAINT FK_Reservasi_Tamu
        FOREIGN KEY (TamuID) REFERENCES Tamu(TamuID),

    CONSTRAINT FK_Reservasi_Kamar
        FOREIGN KEY (KamarID) REFERENCES Kamar(KamarID)
);
GO


-- =========================================
-- DATA CONTOH KAMAR
-- =========================================
INSERT INTO Kamar (NoKamar, TipeKamar, Harga, Status)
VALUES
('101', 'Standard', 300000, 'Tersedia'),
('102', 'Standard', 300000, 'Tersedia'),
('201', 'Deluxe', 500000, 'Tersedia'),
('202', 'Deluxe', 500000, 'Tersedia'),
('301', 'Suite', 800000, 'Tersedia');
GO


-- =========================================
-- CEK DATA
-- =========================================
SELECT * FROM Users;
SELECT * FROM Tamu;
SELECT * FROM Kamar;
SELECT * FROM Reservasi;