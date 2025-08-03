<?php
include 'db.php';
session_start();

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $name      = $_POST['name'];
    $email     = $_POST['email'];
    $room_type = $_POST['room_type'];
    $guests    = $_POST['guests'];
    $date      = $_POST['date'];
    $time      = $_POST['time'];
    $price     = $_POST['price'];

    $sql = "INSERT INTO bookings (name, email, hotel_venue, package_type, num_of_rooms, num_of_guests, booking_date, booking_time, parking, tax_amount, total_amount, instructions)
            VALUES ('$name', '$email', 'N/A', '$room_type', 1, '$guests', '$date', '$time', 'No', 0, '$price', '')";

    if (mysqli_query($conn, $sql)) {
        $_SESSION['booking_data'] = [
            'name' => $name,
            'email' => $email,
            'room_type' => $room_type,
            'guests' => $guests,
            'date' => $date,
            'time' => $time,
            'price' => $price
        ];
        header("Location: booking_success.php");
    } else {
        echo "<script>alert('❌ Booking failed.'); window.history.back();</script>";
    }
}
?>
