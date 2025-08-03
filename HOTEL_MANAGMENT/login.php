<?php
session_start();
include 'db.php';

$email       = $_POST['email'];
$password    = $_POST['password'];
$parent_name = $_POST['parent_name'];

$sql = "SELECT * FROM users WHERE email='$email' AND parent_name='$parent_name'";
$result = mysqli_query($conn, $sql);

if (mysqli_num_rows($result) === 1) {
    $user = mysqli_fetch_assoc($result);
    if (password_verify($password, $user['password'])) {
        $_SESSION['user'] = $user;
        header("Location: home.html");
        exit();
    } else {
        echo "<script>alert('❌ Incorrect password'); window.history.back();</script>";
    }
} else {
    echo "<script>alert('❌ Invalid email or parent name'); window.history.back();</script>";
}
?>
