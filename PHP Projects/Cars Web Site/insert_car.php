<?php include "inc-files/before_content.code"?>
<div id="content">
<table align="center"><tr><td>
<form action="exec_insert_car.php" method="post" enctype="multipart/form-data">
<u>Въвеждане на данни за нова кола:</u></br><br>
марка:
<?php
$mysqli = new mysqli('localhost', 'root', '', dbName);
$mysqli->set_charset('utf8');
$result=$mysqli->query("SELECT * FROM tbl_makes order by make");
echo "<select name='id_make'>";
echo "<option value='0'>Изберете...</opttion>";
while($row=$result->fetch_assoc())
{
	echo "<option value='". htmlspecialchars(stripslashes($row['id_make']))
	. "'>". htmlspecialchars(stripslashes($row['make'])). "</option>";
}
echo "</select>";
$mysqli->close();
?>
цена:<input type="text" name="price" value="">лв.<br>
др. информация: <br><textarea name="moreinfo" rows="10" cols="40">
инфо... </textarea><br>
снимка:<input type="file" name="imgFile"><br><br>
<input type="submit" value="Добави">
</form>
</table>
</div>
<?php include "inc-files/after_content.code"; ?>