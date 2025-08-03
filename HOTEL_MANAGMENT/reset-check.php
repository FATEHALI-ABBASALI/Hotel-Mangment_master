<?php
include 'db.php';
?>
<!DOCTYPE html>
<html>
<head>
    <title>Forgot Password</title>
    <style>
        body {
            margin: 0;
            padding: 0;
            font-family: 'Segoe UI', sans-serif;
            background: #f1f1f1;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        .box {
            background: white;
            padding: 30px 40px;
            border-radius: 15px;
            box-shadow: 0 10px 25px rgba(0,0,0,0.2);
            width: 350px;
            text-align: center;
        }

        h2 {
            margin-bottom: 20px;
            color: #333;
        }

        input[type="email"], input[type="password"], input[type="text"] {
            width: 100%;
            padding: 12px;
            margin: 10px 0;
            border: 1px solid #ccc;
            border-radius: 8px;
            box-shadow: inset 0 1px 3px rgba(0,0,0,0.1);
        }

        input[type="submit"] {
            width: 100%;
            padding: 12px;
            background-color: #007bff;
            color: white;
            border: none;
            border-radius: 8px;
            cursor: pointer;
            transition: 0.3s;
        }

        input[type="submit"]:hover {
            background-color: #0056b3;
        }

        p {
            margin-top: 10px;
        }
    </style>
</head>
<body>
<div class="box">
<?php
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    // STEP 2: Update password
    if (isset($_POST['new_password']) && isset($_POST['email'])) {
        $email = $_POST['email'];
        $new_password = password_hash($_POST['new_password'], PASSWORD_DEFAULT);

        $update = mysqli_query($conn, "UPDATE users SET password='$new_password' WHERE email='$email'");
        if ($update) {
            echo "<p style='color:green;'>✅ Password changed successfully! <a href='index.html'>Login Now</a></p>";
        } else {
            echo "<p style='color:red;'>❌ Password update failed!</p>";
        }

    } 
    // STEP 1: Check email and parent name
    else if (isset($_POST['email']) && isset($_POST['parent_name'])) {
        $email = $_POST['email'];
        $parent_name = $_POST['parent_name'];

        $check = mysqli_query($conn, "SELECT * FROM users WHERE email='$email' AND parent_name='$parent_name'");
        if (mysqli_num_rows($check) > 0) {
            // Email + parent name match → show new password form
            echo "<h2>🔐 Set New Password</h2>";
            echo "<form method='POST'>
                    <input type='hidden' name='email' value='" . htmlspecialchars($email) . "'>
                    <input type='password' name='new_password' placeholder='Enter new password' required><br>
                    <input type='submit' value='Change Password'>
                  </form>";
        } else {
            echo "<p style='color:red;'>❌ Email or Parent Name is incorrect. <a href='reset-check.php'>Try again</a></p>";
        }
    }
} else {
    // STEP 0: Ask email and parent name
    echo "<h2>🔒 Forgot Password</h2>
          <form method='POST'>
              <input type='email' name='email' placeholder='Enter your email' required><br>
              <input type='text' name='parent_name' placeholder='Enter Parent Name' required><br>
              <input type='submit' value='Next'>
          </form>";
}
?>
</div>
</body>
</html>
