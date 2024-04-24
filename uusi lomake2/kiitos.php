<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
<h1>Kiitos palautteestasi!</h1>
    <p>Tiedot on tallennettu onnistuneesti</p>
    <?php
$servername = "localhost";
$username = "root";
$password = "";
$database = "tilaus";
$conn = new mysqli($servername, $username, $password, $database);

if ($conn ->connect_error){

    die("Yhteys epäonnistui" . $conn->connect_error);
}else{
    echo "Seuraavat tiedot tallennettu:<br>";
}

$sql = "SELECT * FROM tilausjakso ORDER BY id DESC LIMIT 1";

$result = $conn->query($sql);

if($result->num_rows > 0){

    while($row = $result->fetch_assoc()){
        echo "ID: " . $row["id"]. "<br> Nimi:". $row["nimi"].  "<br> sukunimi: " . $row["sukunimi"]. "<br> osoite: " . $row["osoite"]. "<br> postinumero: " . $row["postinumero"]. "<br> postitoimipaikka: " . $row["postitoimipaikka"]. "<br> tilaus: " . $row["tilausm"]. "<br>" ;
    }
}else {
    echo "Ei tuloksia";
}

$conn->close();
?>
</body>
</html>