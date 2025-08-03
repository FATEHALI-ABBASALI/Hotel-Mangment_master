<?php
include 'db.php';

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $name        = $_POST['name'];
    $email       = $_POST['email'];
    $password    = password_hash($_POST['password'], PASSWORD_DEFAULT);
    $parent_name = $_POST['parent_name'];

    $check = mysqli_query($conn, "SELECT * FROM users WHERE email='$email'");
    if (mysqli_num_rows($check) > 0) {
        echo "User already exists!";
    } else {
        $insert = mysqli_query($conn, "INSERT INTO users (name, email, password, parent_name) VALUES ('$name', '$email', '$password', '$parent_name')");
        if ($insert) {
            header("Location: home.html");
            exit();
        } else {
            echo "Signup failed!";
        }
    }
}
?>
