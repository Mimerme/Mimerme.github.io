var activeObjectData = {};
var activeObject;
var isActive = false;

function finishLoad(){
	console.log("iFrames have finished loading");
	$( "#spin" ).fadeOut( "slow", function() {
		console.log("Loop broken");
		$( "#spin" ).removeClass("spinner");
		active();
  });
}

function animateObjectToRight(jobject){
	isActive = true;
	activeObject = jobject;
	activeObjectData= {
		'top' : jobject.css('top'),
		'left' : jobject.css('left'),
		'width' : jobject.width(),
		'height' : jobject.height()
		
	};
	sidebarPullout(jobject.attr("sidebar"), jobject.attr("caption"), jobject.attr("websource"));
	jobject.animate({'top' : -(window.innerHeight / 6) + 'px',
	 'left' : (window.innerWidth) / 10 + 'px',
	 'width': jobject.width() * window.innerHeight / 655,
	 'height': jobject.height() * window.innerHeight / 655
	 },{
	  done: function(animation, jumpedToEnd){
        	jobject.addClass(".idle-target");
        }
       }
  	  ,250);
 }

function returnToPosition(){
	sidebarFallback();
	activeObject.removeClass('.idle-target');
	activeObject.animate({'top' : activeObjectData.top, 'left' : activeObjectData.left,
	'width': activeObjectData.width, 'height': activeObjectData.height},{
		done: function(a,b){
			isActive = false;
		}}, 175);
	activeObject = null
	activeObjectData = {};
}

function sidebarPullout(source, sideCaption, place){
	console.log(source.replace("sidebars/", "").replace(".html", ""));
	$('#' + source.replace("sidebars/", "").replace(".html", "")).animate({'left': '0%'}).addClass("active");
	headerPullout(sideCaption, place);
}

//15 - 16 characters to be centered
function headerPullout(text ,sauce){
	$('#contentHeader').animate({
	 'left' : (window.innerWidth) / 10 + 'px'
 	 });
	 console.log(sauce);
	 $('#contentHeader').attr("href", sauce);
	$('#contentHeader').text(text);
	$('#contentHeader').css("font-size", window.innerHeight / 42 + "px");
}

function headerFallback(){
	$('#contentHeader').animate({'left': '500px'});
}

function sidebarFallback(){
	$('.active').animate({'left': '-65%'});
	headerFallback();
}
