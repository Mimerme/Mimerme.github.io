$(document).ready(function(){


	console.log("Webpage fully loaded");


setTimeout(function(){

	//Wait before animating the nameline
	$("h1").append('<hr noshadow="" width="0px" style="margin-top: 0px;" id="nameLine">');

	//Draw the Line on which the name resides on
	$("#nameLine").animate({
		width: "+=20%"
	},{duration: 800, queue: true});

	$("#github").delay(1000).animate({
		left: "-3%"
	},{duration: 1300, queue: true} );

	$("#steam").delay(2000).animate({
		left: "-1%"
	},{duration: 1300,  queue: true});

	$("#twitter").delay(3000).animate({
		right: "-1%"
	},{duration: 1300,  queue: true});

	$("#youtube").delay(4000).animate({
	right: "-3%"
	},{duration: 1300,  queue: true});

	},
		

	700);

//	$("h2").delay(2000).animate({
//		right: "885px"
//	},"slow")

});

