var div = document.getElementById('errors');
var firstname = document.getElementById('firstname'); 	//getting our firstname input field
var addr = document.getElementById('addr'); 			//getting our address input field
var zip = document.getElementById('zip'); 				// getting our zip code input field
var state = document.getElementById('state'); 			//getting our select input field
var username = document.getElementById('username'); 	// getting our username input field
var email = document.getElementById('email'); 

function formValidator(){
	
	// Check each input in the order that it appears in the form!

	if(isAlphabet(firstname, "Please enter only letters for your name")){
		if(isAlphanumeric(addr, "Numbers and Letters Only for Address")){
			if(isNumeric(zip, "Please enter a valid zip code")){
				if(madeSelection(state, "Please Choose a State")){
					if(lengthRestriction(username, 6, 8) && notEmpty(username, "Username field must be filled")){
						if(emailValidator(email, "Please enter a valid email address") && notEmpty(email, "Email field must be filled")){
							if(GetSelectedItem()){
								if(CheckBox()){
									alert("Form successfuly submited!");
									return true;
								}
							}
						}
					}
				}
			}
		}
	}

	return false;
	
}

function returnError(errorMessage){
		div.innerHTML = "<hr/><p>" + errorMessage + "</p><hr/>";
}
function clearError(elem){
	 	elem.onfocus=function() {
        div.innerHTML = "";
    };
}

function notEmpty(elem,errorMessage){
	if(elem.value.length == 0){
		returnError(errorMessage);
		clearError(elem);
		return false;
	}
	return true;
}

function isNumeric(elem,errorMessage){
	var numericExp = /^[0-9]+$/;
	if(elem.value.match(numericExp)){
		return true;
	}else{
		returnError(errorMessage);
		clearError(elem);
		return false;

	}
}

function isAlphabet(elem,errorMessage){
	var alphaExp = /^[a-zA-Z]+$/;
	if(elem.value.match(alphaExp)){
		return true;
	}else{
		returnError(errorMessage);
		clearError(elem);
		return false;
	}
}

function isAlphanumeric(elem,errorMessage){
	var alphaExp = /^[0-9a-zA-Z]+$/;
	if(elem.value.match(alphaExp)){
		return true;
	}else{
		returnError(errorMessage);
		clearError(elem);
		return false;
	}
}

function lengthRestriction(elem, min, max){
	var uInput = elem.value;
	if(uInput.length >= min && uInput.length <= max){
		return true;
	}else{
		returnError("The length of the field must be between " + min + " and " + max);
		clearError(elem);
		return false;
	}
}

function madeSelection(elem, errorMessage){
	if(elem.value == "Please Choose"){
		returnError(errorMessage);
		clearError(elem);
		return false;
	}else{
		return true;
	}
}

function emailValidator(elem, errorMessage){
	var emailExp = /^[\w\-\.\+]+\@[a-zA-Z0-9\.\-]+\.[a-zA-z0-9]{2,4}$/;
	if(elem.value.match(emailExp)){
		return true;
	}else{
		returnError(errorMessage);
		clearError(elem);
		return false;
	}
}

function GetSelectedItem() {

chosen = "";
len = document.f1.r1.length;

	for (i = 0; i <len; i++) {
		if (document.f1.r1[i].checked) {
		chosen = document.f1.r1[i].value;
		}
	}
	if (chosen == "") {
		returnError("No Location Chosen");
		return false;
	}else {
		return true;
	}
}

function CheckBox(){
	if(document.f1.checkbox.checked)
	{
		return true;
	}else{
		 returnError('You must agree to the terms first.');
		 return false;
	}

}