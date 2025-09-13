CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL,
    Role NVARCHAR(20) NOT NULL -- Admin, Reception, Customer
);

INSERT INTO Users (Username, Password, Role) VALUES
('admin', 'admin123', 'Admin'),
('reception', 'recept123', 'Reception'),
('customer', 'cust123', 'Customer');

-- Booking Table
CREATE TABLE Booking (
    BookingID INT PRIMARY KEY IDENTITY,
    CustomerName NVARCHAR(100),
    RoomNo INT,
    CheckInDate DATE,
    CheckOutDate DATE
);

-- Food Orders
CREATE TABLE FoodOrder (
    OrderID INT PRIMARY KEY IDENTITY,
    CustomerName NVARCHAR(100),
    FoodItem NVARCHAR(100),
    Quantity INT
);

-- Staff Review
CREATE TABLE StaffReview (
    ReviewID INT PRIMARY KEY IDENTITY,
    StaffName NVARCHAR(100),
    Rating INT,
    Comments NVARCHAR(255)
);
