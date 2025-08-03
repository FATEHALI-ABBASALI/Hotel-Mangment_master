<?php
// booking_success.php
session_start();
if (!isset($_SESSION['booking_data'])) {
    header("Location: booking.html");
    exit;
}
$booking = $_SESSION['booking_data'];
?>

<!DOCTYPE html>
<html>
<head>
    <title>Booking Receipt</title>
    <style>
        body { font-family: Arial, sans-serif; padding: 20px; }
        .receipt { border: 1px solid #ccc; padding: 20px; max-width: 500px; margin: auto; }
        h2 { color: green; }
        button { margin-top: 20px; }
    </style>
</head>
<body>
    							<a href="index.html"><i class="fas fa-sign-out-alt"></i> Logout</a>

    <div class="receipt">
        <h2>✅ Booking Successful</h2>
        <p><strong>Name:</strong> <?= $booking['name'] ?></p>
        <p><strong>Email:</strong> <?= $booking['email'] ?></p>
        <p><strong>Room Type:</strong> <?= $booking['room_type'] ?></p>
        <p><strong>Guests:</strong> <?= $booking['guests'] ?></p>
        <p><strong>Date:</strong> <?= $booking['date'] ?></p>
        <p><strong>Time:</strong> <?= $booking['time'] ?></p>
        <p><strong>Total Price:</strong> ₹<?= $booking['price'] ?></p>
        <button onclick="window.print()">🖨️ Print Receipt</button>
    </div>
</body>
</html>
