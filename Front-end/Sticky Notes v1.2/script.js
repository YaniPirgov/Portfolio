//Function which runs on page load
$(document).ready(function(){

	
		if(localStorage.getItem('saved')){ // Проверяваме дали имаме запазени данни под име "saved"
			getFromstorage('saved','#sticky_notes'); // ако има ги извличаме от localStorage с нашата функция за извличане на данни
			//тя приема за параметри ( име на елемента който трябва да бъде извлечен, елемент към който да се прикрепи запазения html )
			//извикваме тази функция в началото на нашият документ, за да може първо да се генерират всички бележки които са били запазени в localStorage
		}

		// Add notes button click event // Добавяне на бележки при клик на бутона +
		$('#refreshNotes').click(function(){ // при клик на бутон с id= refreshNotes  Изпълняваме анонимна семоизвикваща се функция 
			AddNotes(); // Извикваме си функцията за добавяне на бележка т.е. добавяме си бележка
			$('#title').val('');  // изчистваме текстовата стойност от текстовото поле за заглавие
			$('#description').val('');  // изчистваме текстовата стойност от текстовото поле за описание

			//Mark after refresh // Маркиране на бележки след добавяне
			$('.sNote').click(function(){  // при клик на елемент с class= sNote  Изпълняваме анонимна семоизвикваща се функция 
				$(this).addClass("marked"); // добавяме клас marked ->"маркер" към елемент с клас sNote, в случая това ще важи за всяка новодобавена бележка
				//можем да маркираме без да презареждаме станицата, чрез този клас ще прилагаме останалите css Правила, само маркирани елементи ще могат да се стилизира чрез user interface-a
			}); // край на функцията и обработка на събитието
 
			//Unmark after refresh notes // отмаркиране на бележки след добавяне
			$('.sNote').dblclick(function(){  // при клик на елемент с class= sNote  Изпълняваме анонимна семоизвикваща се функция 
				$(this).removeClass("marked"); // премахване класа marked, отмаркираме елемента, важи за всяка новодобавена бележка, можем да отмаркираме без
				//да презареждаме страницата
			}); // край на функцията и обработка на събитието
		}); // край на функцията и обработка на събитието


		//Изтриване на бележки
		$("#delete").click(function(){  // при клик на бутон с class= sNote   Изпълняваме анонимна семоизвикваща се функция 
			$(".marked").remove(); //изтриваме маркиран елемент (s class = marked)
			 saveToStorage('saved','#sticky_notes' ); // запазваме промените в localStorage
		}); // край на функцията и обработка на събитието



		//Mark notes so we can style them as we want // Маркиране на бележките
		$('.sNote').click(function(){  // при двоен-клик на елемент с class= sNote   Изпълняваме анонимна семоизвикваща се функция 
			 $(this).addClass("marked"); // добавяме клас marked към елемент с клас sNote, важи за всички бележки генерирани от localStorage
			 saveToStorage('saved','#sticky_notes' ); // запазваме промените в localStorage
		}); // край на функцията и обработка на събитието


		//Unmark notes // отмаркиране на бележки
		$('.sNote').dblclick(function(){  // при двоен-клик на елемент с class=sNote  Изпълняваме анонимна семоизвикваща се функция 
			 $(this).removeClass("marked"); //премахване на клас marked от елемент с клас sNote, важи за всички бележки генерирани от localStorage
			 saveToStorage('saved','#sticky_notes' ); // запазваме промените в localStorage
		}); // край на функцията и обработка на събитието


		//Mark done to-does // Задраскване на бележки
		$("#done").click(function(){  // при клик на бутон с id=done  Изпълняваме анонимна семоизвикваща се функция 
			 addCss(".marked","text-decoration", "line-through"); // добавяме функционалност за задраскване чрез нашият метод addCss, прилага се само на маркирани бележки
			 saveToStorage('saved','#sticky_notes' ); // запазваме промените в localStorage
		}); // край на функцията и обработка на събитието


		//Unmark done to-does // премахване на бележки
		$("#taskRe").click(function(){  // при клик на бутон с id=taskRe Изпълняваме анонимна семоизвикваща се функция 
			 addCss(".marked","text-decoration", "none"); // премахване на задраскването, отново чрез addCss, прилага се само на маркирани бележки
			 saveToStorage('saved','#sticky_notes' ); // запазваме промените в localStorage
		}); // край на функцията и обработка на събитието


		//Change color via select field // Смяна на фон чрез select поле
		$('#colorchanger').click(function(){  // при клик на бутон с id=colorChanger  Изпълняваме анонимна семоизвикваща се функция 
			var colourMenu = $( "#colourMenu option:selected" ).text(); //взимаме стойност на цвят като текст от select поле с id = colourMenu и го запаваме в променлива
			addCss(".marked","background", ""); // премахваме фона на маркирания елемент, за да може да приложим новият фон
			$(".marked").removeClass().addClass('marked').addClass(colourMenu).addClass('sNote'); // премахваме всички класове на елемента с клас marked, за да не станат конфликти, след 
			//това наново добавяме класа marked, класа sNote и клас с име нашата променлива - colourMenu ( цветовете за тези класове са дефинирани в css файлът)
			 saveToStorage('saved','#sticky_notes' ); // запазваме промените в localStorage
		}); // край на функцията и обработка на събитието


		//Change color via text field // Смяна на фон чрез текстово поле
		$('#colorchanger2').click(function(){  // при клик на бутон с id=colorchanger2  Изпълняваме анонимна семоизвикваща се функция 
			var color = $('#colorValue').val();  // взимаме въведената стойност от текстовото поле с id = colorValue
			$('.marked').removeClass().addClass('marked').addClass('sNote'); // премахваме всички класове на елемента с клас marked, за да не станат конфликти, след 
			//това наново добавяме класа marked, класа sNote
			addCss(".marked","background-color", color) // Добавяме фон на маркирания елемент, чрез нашият метод addCss, като за стойност на background-color, поставяме 
			//нашата променлива color
			$('#colorValue').val(''); // изчистваме стойността от текстовото поле, за да е готово за въвеждане на следваща стойност
		    saveToStorage('saved','#sticky_notes' ); // запазваме промените в localStorage
		}); // край на функцията и обработка на събитието


		//Change color of the text  // Смяна на цвета на текста
		$('#colorchangerText').click(function(){  // при клик на бутон с id= colorchangerText Изпълняваме анонимна семоизвикваща се функция 
			var color = $('#colorValueText').val(); // взимаме въведената стойност от текстовото поле с id = colorValueText и я запазваме в променлива color
			addCss(".marked", "color", color);// Добавяме фон на маркирания елемент, чрез нашият метод addCss, като за стойност на "color", поставяме 
			//нашата променлива color
			$('#colorValueText').val('');  // изчистваме стойността от текстовото поле, за да е готово за въвеждане на следваща стойност
		     saveToStorage('saved','#sticky_notes' ); // запазваме промените в localStorage
		}); // край на функцията и обработка на събитието

		
		//Increase size of title font // Увеличаване на размера на шрифта на заглавието
		$('#incTitleFont').click(function(){  // при клик на бутон с id=incTitleFont  Изпълняваме анонимна семоизвикваща се функция 
			 fontSize(".marked h4", "increase"); // извикваме метода за промяна на размера на шрифта като подаваме за параметри 
			 //(заглавието на маркирана бележка и операция за увеличаване на размера на шрифта)
			 saveToStorage('saved','#sticky_notes' ); // запазваме промените в localStorage
		}); // край на функцията и обработка на събитието


		//Decrease size of title font  //Намаляване на размера на на шрифта заглавието
		$('#decrTitleFont').click(function(){  // при клик на бутон с id=decrTitleFont  Изпълняваме анонимна семоизвикваща се функция 
			 fontSize(".marked h4", "decrease"); // извикваме метода за промяна на размера на шрифта като подаваме за параметри 
			 //(заглавието на маркирана бележка и операция за намаляне на размера на шрифта)
			 saveToStorage('saved','#sticky_notes'); // запазваме промените в localStorage
		}); // край на функцията и обработка на събитието


		//Increase size of content font // Увеличаване на размера на шрифта на съдържанието
		$('#incContentFont').click(function(){  // при клик на бутон с id= incContentFont  Изпълняваме анонимна семоизвикваща се функция 
			 fontSize(".marked p", "increase");// извикваме метода за промяна на размера на шрифта като подаваме за параметри 
			 //(съдържанието на маркирана бележка и операция за увеличаване на размера на шрифта)
			 saveToStorage('saved','#sticky_notes'); // запазваме промените в localStorage
		}); // край на функцията и обработка на събитието


		//Increase size of content font //  Намаляване на размера на шрифта на съдържанието
		$('#decrContentFont').click(function(){  // при клик на бутон с id=decrContentFont  Изпълняваме анонимна семоизвикваща се функция 
			 fontSize(".marked p", "decrease");// извикваме метода за промяна на размера на шрифта като подаваме за параметри 
			 //(съдържанието на маркирана бележка и операция за намаляне на размера на шрифта)
			 saveToStorage('saved','#sticky_notes'); // запазваме промените в localStorage
		}); // край на функцията и обработка на събитието

		
		//Change font family // Смяна на семейството на шрифта
		$('#changeFont').click(function(){  // при клик на бутон с id= changeFont Изпълняваме анонимна семоизвикваща се функция 
			 changeFont(".marked"); //извикваме си функцията за смяна на семейството на шрифта и и подаваме маркиран елемент като параметър, т.е. 
			 //шрифта ще се сменя само на бележки с class marked
			 saveToStorage('saved','#sticky_notes'); // запазваме промените в localStorage
		}); // край на функцията и обработка на събитието

		//Bold the content // Болдване на съдържанието
		$('#boldIt').click(function(){  // при клик на бутон с id=boldIt  Изпълняваме анонимна семоизвикваща се функция 
			var boldMenu = $( "#boldMenu option:selected" ).text(); //взимаме стойност  за bold като текст от select поле с id = boldMenu и го запазваме в променлива
			addCss(".marked p","font-weight", boldMenu);// Правим текста на съдържанието на маркирания елемент bold, чрез нашият метод addCss, като за стойност на "font-weight", поставяме 
			//нашата променлива  boldMenu
		 	saveToStorage('saved','#sticky_notes'); // запазваме промените в localStorage
		}); // край на функцията и обработка на събитието


		//Italic the content // Италик на съдържанието
		$('#ItalicIt').click(function(){  // при клик на бутон с id=ItalicIt Изпълняваме анонимна семоизвикваща се функция 
			var italicMenu = $( "#italicMenu option:selected" ).text(); //взимаме стойност  за italic като текст от select поле с id = italicMenu и го запазваме в променлива
			addCss(".marked p","font-style", italicMenu);// Правим текста на съдържанието на маркирания елемент italic, чрез нашият метод addCss, като за стойност на "font-style", поставяме 
			//нашата променлива  italicMenu
		    saveToStorage('saved','#sticky_notes'); // запазваме промените в localStorage
		}); // край на функцията и обработка на събитието


		//Highlight the content // Наблягане на съдържанието с жълт цвят
		$('#highlight').click(function(){  // при клик на бутон с id= highlight Изпълняваме анонимна семоизвикваща се функция 
			addCss(".marked p", "background-color", "#FFFF00"); //променяме стила на съдържанието на маркирана бележка с нашият метод addCSs, като хардкодваме 
			//жълт цвят за маркиране.
			saveToStorage('saved','#sticky_notes'); // запазваме промените в localStorage
		}); // край на функцията и обработка на събитието


		//Unhighlight the content // Прамахване на жълтият цвят
		$('#unhighlight').click(function(){  // при клик на бутон с id= unhighlight Изпълняваме анонимна семоизвикваща се функция 
			addCss(".marked p", "background-color", "");//променяме стила на съдържанието на маркирана бележка с нашият метод addCSs, като премахваме
			//жълтият фонов цвят, така отмаркираме съдържанието.
			saveToStorage('saved','#sticky_notes'); // запазваме промените в localStorage
		}); // край на функцията и обработка на събитието

	
		//Add image to a note // Добавяне на изображение към бележка
		$('#addImg').click(function(){  // при клик на бутон с id=  Изпълняваме анонимна семоизвикваща се функция 
			var imgSrc = $('#imgSrc').val(); //взимаме стойноста от текстово поле с Id=imgSrc ( там се очаква да се напише пътя до изображението)
			$(".marked p").append("<img class='img' src='"+ imgSrc +"'/>"); // добавяне на изображението към съдържанието на маркирана бележка
			// като за src на изображението посочваме нашата променлива "imgSrc"
				saveToStorage('saved','#sticky_notes'); // запазваме промените в localStorage
		}); // край на функцията и обработка на събитието


		//Remove all images from a note // прамхване на всички изображения от бележките
		$("#removeImg").click(function(){  // при клик на бутон с id=  Изпълняваме анонимна семоизвикваща се функция 
			$(".marked p img").detach(); // премахване на всички изображения от съдържанието на маркирана бележка
			saveToStorage('saved','#sticky_notes'); // запазваме промените в localStorage
		}); // край на функцията и обработка на събитието

});

//Аdd notes
function AddNotes(){  //Функция чрез която ще добавяме бележки
	
		var title = $('input[id="title"]').val();  // променлива на която присвояваме стойноста от input поле с id = title
		var description = $('input[id="description"]').val();  // променлива на която присвояваме стойноста от input поле с id = description
		
		if(title != undefined && description != undefined){ // Правим проверка дали 2-те променливи не са undefined ( недефиниране )
			createNotes(title, description); // ако са дефинирани извикваме функцията за генериране на бележки, тя приема 2 параметър 
			//(title, description), който всъщност за заглавието и съдържанието на нашата бележка съдържанието на нашата бележка
		}	

		saveToStorage('saved','#sticky_notes'); //извикваме функцията, чрез която запазваме своите бележки в localStorage 
		//тя приема 2 параметъра (име на запазения елемент, и елемент на който да извлече и запази html-a)

		if(localStorage.getItem('saved')){ // Проверяваме дали имаме запазени данни под име "saved"
			getFromstorage('saved','#sticky_notes'); // ако има ги извличаме от localStorage с нашата функция за извличане на данни
			//тя приема за параметри ( име на елемента който трябва да бъде извлечен, елемент към който да се прикрепи запазения html )
		}
}

//Create notes
function createNotes(title, description){ //Функция за създаване на бележки, приема за параметри заглавие на бележката и съдържание на бележката

	var header = '<h4 class="title" contenteditable="true">'+title+'</h4>'; //Променлива html, която пази html-a за заглавието на всяка бележка
	var desc =   '<p class="description" contenteditable="true">'+description+'</p>'; //Променлива html, която пази html-a за съдържанието на всяка бележка
	
	if(title == "" && 	description == ""){ // Проверяваме ако се генерира бележка без заглавие и описание
			stickyNotes = '<li class="sNote"><h4 class="title" contenteditable="true">Default Header</h4><p class="description" contenteditable="true">Default Description</p></li>';
			//променлива с пълния html на default бележката, ако нямаме заглавие и описание
	}
	else{
			stickyNotes = '<li class="sNote">'+header+desc+'</li>';
			//променлива с пълния html на  бележката при дефинирани заглавие и описание
	}
	
	$('#sticky_notes').append(stickyNotes); // добавяме html-a към Unorderd list-a с id = sticky_notes, чрез метода append
}


//Font size function
function fontSize(elem, operation){ //Функция за промяна на размера на шрифта, приема за параметри (елемент на който ще променим размера на шрифра, операция(намаляне, увеличаване))
	if(operation == "increase"){ // при операция за увеличаване

		var fontSize = parseInt($(elem).css("font-size")) + 1; //запазваме в променлива текущия размер на шрифта, превръщаме го в Integer, и го увеличаваме с 1-ца
		$(elem).css({'font-size': fontSize}); //Добаваме направената промяна към даден елемент

	}else if(operation == "decrease"){ //при операция за намаляне
 
		var fontSize = parseInt($(elem).css('font-size')) - 1; //запазвамев променлива текущия размер на шрифта, превръщаме го в Integer, и го намаляме с 1-ца
		$(elem).css({'font-size': fontSize});	//Добаваме направената промяна към даден елемент	
	}
}

//Font family function
function changeFont(elem){ //функция за промяна на семейството на шрифта 
		var fontFamily = $( "#fontFamily option:selected" ).text() //  променлива в която запазваме селектирана стойност от select поле с id fontFamily като текст
		addCss(elem, "font-family", fontFamily); // добавяме css към съответен елемент, чрез който сменяме семейството на шрифта, като подаваме като css стойност нашата
		//променлива fontFamily
}

//Add css to an element function
function addCss(elem, key, value){ // функция за улеснено добавяне на css kъм даден елемент
		$(elem).css(key, value); // функцията приема за параметри елемент, css ключ и стойност
}

//Save data to the local storage
function saveToStorage(name, elem){ // функция за запазване на html-a на даден елемент В localStorage, приема за параметри
// (име под което ще се запази html-a, елемент от който ще се извлече html-a)
		localStorage.setItem(name, $(elem).html()); // запазваме данни с име=name и html= html-a на елемента който сме посочили
}

//Get data from the local storage
function getFromstorage(name, elem){ // функция за извличане на запазени данни(html) чрез някакво име, и запазването на тези данни (html) в нов елемент
		$(elem).html(localStorage.getItem(name)); // добавяме запазения в LocalStorage html към съответно посочен елемент
}
