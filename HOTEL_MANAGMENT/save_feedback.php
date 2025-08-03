<?php
include 'db.php'; // connect to database

// Check if form is submitted
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $email = $_POST['email'];
    $message = $_POST['message'];

    // Escape values to prevent SQL injection
    $email = mysqli_real_escape_string($conn, $email);
    $message = mysqli_real_escape_string($conn, $message);

    // Insert into DB
    $sql = "INSERT INTO feedback (email, message) VALUES ('$email', '$message')";

    if (mysqli_query($conn, $sql)) {
        echo "<script>alert('Feedback submitted successfully!'); window.location.href='gallery.html';</script>";
    } else {
        echo "<script>alert('Error saving feedback.'); window.history.back();</script>";
    }
}
?>
