<form> <input  type ="text" name = "luku">
<button type ="submit" id = "button" name =button> </form>
<?php  
 function laskeSummakertyma($numero) {
    $summa = 0; // Alustetaan summa nollaksi
    $i = 0; // Alustetaan laskuri nollaksi
    
    // while-silmukka laskee summakertymän
    while ($i < $numero) {
        $summa += $i; // Lisätään luku summaan
        $i++; // Kasvatetaan laskuria
    }
    
    return $summa; // Palautetaan summakertymä
}
$tulosviesti = '$summa';


// Pyydetään käyttäjältä syöte
if (isset($_POST['luku'])) {
    $syote = intval($_POST['luku']); // Otetaan luku lomakkeelta
    $summakertyma = laskeSummakertyma($syote); // Lasketaan summakertymä
    echo "Summakertymä luvulle {$syote} on {$summakertyma}."; // Tulostetaan tulos
    $tulosviesti = "Summakertymä luvulle {$syote} on {$summakertyma}."; // Tallennetaan tulostettava viesti
} else {
    // Jos luku ei ole lähetetty lomakkeella, näytetään lomake pyytäen syötettä
    echo '
    <form method="post" action="">
        Syötä luku: <input type="text" name="luku">
        <input type="submit" value="Laske summakertymä">
    </form>';
}


?>
 <div>'.$tulosviesti.'</div>