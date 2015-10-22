var activeObjectData = {};
var activeObject;
var isActive = false;

function animateObjectToRight(jobject){
	isActive = true;
	activeObject = jobject;
	activeObjectData= {
		'top' : jobject.css('top'),
		'left' : jobject.css('left'),
		'width' : jobject.width(),
		'height' : jobject.height()

	};
	sidebarPullout(jobject.attr("sidebar"), jobject.attr("caption"));
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

function sidebarPullout(source, sideCaption){
	$('#sideFrame').animate({'left': '0%'});
	$('#sideFrame').attr("src", source);
	headerPullout(sideCaption);
}

//15 - 16 characters to be centered
function headerPullout(text){
	$('#contentHeader').animate({
	 'left' : (window.innerWidth) / 10 + 'px'
 	 });
	$('#contentHeader').text(text);
	$('#contentHeader').css("font-size", window.innerHeight / 42 + "px");
}

function headerFallback(){
	$('#contentHeader').animate({'left': '500px'});
}

function sidebarFallback(){
	$('#sideFrame').animate({'left': '-65%'});
	headerFallback();
}
