<?php
session_start();
if (!isset($_SESSION['admin_logged_in']) || $_SESSION['admin_logged_in'] !== true) {
    header("Location: admin_login.php");
    exit();
}

include 'db.php';
$result = mysqli_query($conn, "SELECT * FROM bookings ORDER BY id DESC");
?>

<!DOCTYPE html>
<html>
<head>
    <title>Admin Dashboard</title>
    <style>
        table { border-collapse: collapse; width: 100%; margin-top: 20px; }
        th, td { border: 1px solid #ccc; padding: 10px; text-align: left; }
        th { background-color: #f0f0f0; }
        body { font-family: Arial; padding: 20px; }
        .logout { text-align: right; margin-bottom: 10px; }
    </style>
</head>
<body>
    <div class="logout"><a href="index.html">🚪 Logout</a></div>
    <h2>📋 Booking Management - Admin Dashboard</h2>
    <table>
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Email</th>
            <th>Room Type</th>
            <th>Guests</th>
            <th>Date</th>
            <th>Time</th>
            <th>Total</th>
            <th>Receipt</th>
        </tr>
        <?php while ($row = mysqli_fetch_assoc($result)) { ?>
        <tr>
            <td><?= $row['id'] ?></td>
            <td><?= $row['name'] ?></td>
            <td><?= $row['email'] ?></td>
            <td><?= $row['package_type'] ?></td>
            <td><?= $row['num_of_guests'] ?></td>
            <td><?= $row['booking_date'] ?></td>
            <td><?= $row['booking_time'] ?></td>
            <td>₹<?= $row['total_amount'] ?></td>
            <td><a href="booking_success.php?id=<?= $row['id'] ?>" target="_blank">🖨️ View</a></td>
        </tr>
        <?php } ?>
    </table>
</body>
</html>
