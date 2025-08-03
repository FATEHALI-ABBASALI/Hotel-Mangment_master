<?php
// Database connection settings
$host = "localhost";
$user = "root";     // your DB username
$pass = "";         // your DB password
$dbname = "db"; // your DB name

// Connect to MySQL
$conn = mysqli_connect($host, $user, $pass, $dbname);

// Check connection
if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}
?>
