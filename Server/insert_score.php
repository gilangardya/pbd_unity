<?php
	// kalau di web hosting
	$con = mysqli_connect("localhost","id5119757_unity","unity","id5119757_unity");

	// kalau di lokal
	// $con=mysqli_connect("localhost","root","","fitness");

	if (mysqli_connect_errno($con)) {
		echo "Failed to connect to MySQL: ".mysqli_connect_error();
	}

	$nama = $_GET["nama"];
	$score = $_GET["score"];

	$query = "INSERT INTO highscore (nama, score)
			  VALUES ('$nama', '$score')";

	mysqli_query($con, $query);

	mysqli_close($con);