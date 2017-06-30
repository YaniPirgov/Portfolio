<?php include "inc-files/before_content.code"; ?>
<div id="content">
<?php 
if ((!isset($_SESSION["username"])) || ($_SESSION["usertype"]!=1))
{
	echo "<span class='errMsg'> Нямате права!</span>";
	//exit;
}
$errMsg="";
if($_POST["id_make"]==0) $errMsg .="Не е избрана марка!<br>";
if(empty($_POST["price"]))
	$errMsg .="Не е въведена цена!<br>";
else 
	if (!is_numeric($_POST["price"])) $errMsg .="Некоректно въведена цена!<br>";
if ($errMsg)
{
	echo"<span class='errMsg'>" .$errMsg. "</span></br>";
	echo"<a href='insert_car.php'>Ново въвеждане</a>";
	}
else 
{
	$mysqli= new mysqli('localhost', 'root', '', dbName);
	$mysqli->set_charset('utf8');
	$str_query="INSERT INTO tbl_cars(id_make, price, moreinfo) VALUES('".$_POST["id_make"]."','".$_POST["price"]."','".$_POST["moreinfo"]."')";
	if ($mysqli->query($str_query))
		echo "Данните са записани в базата <br>";
	$fileErr=$_FILES["imgFile"]["error"]>0;
	if($fileErr)
	{
		echo "span class='errMsg>Не е зададена снимка.</span></br>";
	}
	else
	{
		$allowedExt= array("gif", "JPEG", "jpg", "png");
		$arrName=explode(".", $_FILES["imgFile"]["name"]);
		$ext=end($arrName);
		if (in_array($ext, $allowedExt)&&($_FILES["imgFile"]["size"]<200000000))
		{
			$idCar=$mysqli->insert_id;
			$PicName="Pic".$idCar.".".$ext;
			move_uploaded_file($_FILES["imgFile"]["tmp_name"],"pictures/".$PicName);
			$str_query="update tbl_cars set picture='".$PicName."' where id_car=".$idCar;
			if($mysqli->query($str_query))
				echo "Снимката е качена <br>";
		}
		else
		{
			echo "<span calss='errMsg'>Невалидно изображение!</span><br>";
		}
	}
	$mysqli->close();
}
?>
</div>
<?php include "inc-files/after_content.code";?>