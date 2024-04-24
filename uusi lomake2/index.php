<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
<form action="vastaus.php" method="POST">
        <p>
        
             Etunimi:<input type="text" name="nimi"><br>            
             Sukunimi:<input type="text" name="sukunimi"><br>
             Osoite:<input type="text" name="osoite"><br>
             Postinumero:<input type="text" name="postinumero" maxlength="5" size="5"><br>
             Postitoimipaikka:<input type="text" name="postitoimipaikka"><br>
             Puhelinnumero:<input type="text" name="puhelinnumero"><br>
            
                <input type="radio" id="3kk" name="tilausm" VALUE=3kk required>3kk
                <input type="radio" id="6kk" name="tilausm" VALUE=6kk required>6kk
                <input type="radio" id="12kk" name="tilausm" VALUE=12kk required>12kk
                </SELECT>
                
             
    
                <button type="submit">Lähetä</button>
            <button type="reset">tyhjennä</button>
            
            
        </p>
    </form>
</body>
</html>