<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    $servername = "localhost";
    $username = "root";
    $password = "";
    $database = "tilaus";
    $conn = new mysqli($servername, $username, $password, $database);

    if ($conn ->connect_error){
        die("Yhteys epäonnistui" . $conn->connect_error);
    }else{
        echo "Yhteys otettu tietokantaan";
    }

    if ($_SERVER["REQUEST_METHOD"] == "POST"){
    
    $name = $_POST["nimi"];
    $sukunimi = $_POST["sukunimi"];
    $osoite = $_POST["osoite"];
    $postinumero = $_POST["postinumero"];
    $postitoimipaikka = $_POST["postitoimipaikka"];
    $puhelinnumero = $_POST["puhelinnumero"];
    $tilausm = $_POST["tilausm"];
    
    $sql = "INSERT INTO `tilausjakso`(`nimi`, `sukunimi`, `osoite`, `postinumero`, `postitoimipaikka`, `puhelinnumero`, `tilausm`) VALUES ('$name','$sukunimi','$osoite','$postinumero','$postitoimipaikka','$puhelinnumero','$tilausm')";

    if($conn->query($sql) === TRUE){
        echo "Tiedot tallennettu onnistuneesti.";
    }else{
        echo "Virhe: " . $sql . "<br>" . $conn->error;
    }
    }
    $conn->close();

    header("Location: kiitos.php");
    exit;
    ?>
</body>
</html>