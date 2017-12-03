// Most functions use CompSci 335 examples as base code and modified accordingly

function getBlurayList(){
	var uri = "http://redsox.uoa.auckland.ac.nz/BC/Open/Service.svc/brlist";
	var xhr = new XMLHttpRequest();
	xhr.open("GET", uri, true);
	xhr.setRequestHeader("Accept", "application/json; charset=UTF-8");
	xhr.onload = function() {
	var getBlurayTable = document.getElementById("blurayTable");
	var tableContent = "<tr class='blurayTitle'></tr>";
	var blurayImg = "http://redsox.uoa.auckland.ac.nz/BC/Open/Service.svc/brimg?id=";
	var response = JSON.parse(xhr.responseText);
	for (var i = 0; i < response.length; ++i) {
		var json = response[i];
		tableContent += "<tr><td><img src='" + blurayImg + json.Id  + "'/>'" + "</td><td>" + json.Title + "</td></tr>";
		}	
	getBlurayTable.innerHTML = tableContent;
	}
	xhr.send(null);
}

function getBooksList(){
	var uri = "http://redsox.uoa.auckland.ac.nz/BC/Open/Service.svc/booklist";
	var xhr = new XMLHttpRequest();
	xhr.open("GET", uri, true);
	xhr.setRequestHeader("Accept", "application/json; charset=UTF-8");
	xhr.onload = function() {
	var getBookTable = document.getElementById("booksTable");
	var tableContent = "<tr class='bookTitle'></tr>";
	var bookImg = "http://redsox.uoa.auckland.ac.nz/BC/Open/Service.svc/bookimg?id=";
	var response = JSON.parse(xhr.responseText);
	for (var i = 0; i < response.length; ++i) {
		var json = response[i];
		tableContent += "<tr><td><img src='" + bookImg + json.Id  + "'/>'" + "</td><td>" + json.Title + "</td></tr>";
		}
	getBookTable.innerHTML = tableContent;
	}
	xhr.send(null);
}

function postComment(){
	var fname = document.getElementById("fname").value;
	var comment = document.getElementById("comment").value;
	var xhr = new XMLHttpRequest();
	var uri = "http://redsox.uoa.auckland.ac.nz/BC/Open/Service.svc/comment?name=" + fname;
	xhr.open("POST", uri, true);
	xhr.setRequestHeader("Content-Type", "application/json; charset=UTF-8");
	xhr.onload = function () {
		alert("Comment posted!");
		document.getElementById("fname").value = "";
		document.getElementById("comment").value = "";
		display.src = display.src;
	}
	xhr.send(JSON.stringify(comment));
}

function registerUser(){
	var userName = document.getElementById("userName").value;
	var userPassword = document.getElementById("userPassword").value;
	var userAddress = document.getElementById("userAddress").value;
	var userInfo = {"Address": userAddress, "Name": userName, "Password": userPassword}
	var xhr = new XMLHttpRequest();
	var uri = "http://redsox.uoa.auckland.ac.nz/BC/Open/Service.svc/register";
	xhr.open("POST", uri, true);
	xhr.setRequestHeader("Content-Type", "application/json; charset=UTF-8");
	xhr.onload = function () {
		alert(xhr.response);
		document.getElementById("userName").value = "";
		document.getElementById("userPassword").value = "";
		document.getElementById("userAddress").value = "";
	}
	if (userName.length > 0 && userPassword.length > 0 && userAddress.length > 0){
			xhr.send(JSON.stringify(userInfo));
	} else {
		alert("Please enter a username, password, and address");
	}
}

// Tab structure taken from CompSci335 examples

  var currentTab = "";
  function showTabA() {
	 if (currentTab != "TabA") {
		currentTab = "TabA";
		showNoTabs();
		document.getElementById("TabA").style.backgroundColor = "white";
		document.getElementById("SectionA").style.display = "inline";
		getBooksList();
	 }
  }

  function showTabB() {
	 if (currentTab != "TabB") {
		currentTab = "TabB";
		showNoTabs();
		document.getElementById("TabB").style.backgroundColor = "white";
		document.getElementById("SectionB").style.display = "inline";
		getBlurayList();

	 }
  }

  function showTabC() {
	 if (currentTab != "TabC") {
		currentTab = "TabC";
		showNoTabs();
		document.getElementById("TabC").style.backgroundColor = "white";
		document.getElementById("SectionC").style.display = "inline";
	 }
  }
  
  function showTabD() {
	 if (currentTab != "TabD") {
		currentTab = "TabD";
		showNoTabs();
		document.getElementById("TabD").style.backgroundColor = "white";
		document.getElementById("SectionD").style.display = "inline";
	 }
  }
  
  function showTabE() {
	 if (currentTab != "TabE") {
		currentTab = "TabE";
		showNoTabs();
		document.getElementById("TabE").style.backgroundColor = "lightBlue";
		document.getElementById("SectionE").style.display = "inline";
	 }
  }

  function showNoTabs() {
	 document.getElementById("TabA").style.backgroundColor = "transparent";
	 document.getElementById("TabB").style.backgroundColor = "transparent";
	 document.getElementById("TabC").style.backgroundColor = "transparent";
	 document.getElementById("TabD").style.backgroundColor = "transparent";
	 document.getElementById("TabE").style.backgroundColor = "transparent";


	 document.getElementById("SectionA").style.display = "none";
	 document.getElementById("SectionB").style.display = "none";
	 document.getElementById("SectionC").style.display = "none";
	 document.getElementById("SectionD").style.display = "none";
	 document.getElementById("SectionE").style.display = "none";
	 
  }

  window.onload = function () {
	 showTabA();
  }
  
  