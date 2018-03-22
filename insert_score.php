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

	if ($nama == NULL || $score == NULL) {
		$response = array(
			"message" => "request parameter have to be complete"
		);

		echo json_encode($response);		
	} else {
		$query = "INSERT INTO `highscore` (`id`, `nama`, `score`) VALUES (NULL, '$nama', '$score')";

		mysqli_query($con, $query);	
		
		$response = array(
			"message" => "success",
			"query" => $query,
			"data" => array(
				"nama" => $nama,
				"score" => $score,				
			)
		);

		echo json_encode($response);
	}
	mysqli_close($con); 