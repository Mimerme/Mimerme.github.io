
$(document).ready(function(){

console.log("Getting time of day");
var time = new Date().getHours();
var timeInt = parseInt(time);
console.log("Time is " + timeInt + " hrs");
if(time >= 0 && time <= 3){
	//Late night
      $("body").css("background-image", "url(http://i.imgur.com/HaYuGQi.png)");
      $("body").css("color: white;");
}
else if(time >= 4 && time <= 6){
	//Morning
      $("body").css("background-image", "url(http://i.imgur.com/NNoFNWf.png)");
      $("body").css("color: black;");      
	
}
else if(time >= 7 && time <= 9){
	//Late Morning
      $("body").css("background-image", "url(http://i.imgur.com/VW2DYbL.png)");
      $("body").css("color: black;");      
}
else if(time >= 10 && time <= 13){
	//Afternoon
      $("body").css("background-image", "url(http://i.imgur.com/UZKEjzG.png)");
      $("body").css("color: black;");            
}
else if(time >= 14 && time <= 17){
	//Evening
      $("body").css("background-image", "url(http://i.imgur.com/QOfZ5r8.png)");
      $("body").css("color: black;");            
	
}
else if(time >= 18 && time <= 21){
       //Late Evening
      $("body").css("background-image", "url(http://i.imgur.com/Y4BHWJM.png)");
      $("body").css("color: black;");             
}
else if(time >= 22 && time <= 23){
       //Night
      $("body").css("background-image", "url(http://i.imgur.com/laSSeYN.png)");
      $("body").css("color: white;");            
       
}


});
