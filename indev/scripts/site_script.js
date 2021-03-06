﻿var currentRotation = 0;
var currentRotation2 = 0;
//Default
var degreesPRotation = 90;
var degreesPRotation2 = 90;
var rotating = true;
var objectCount = 0;

//Make rotation calculations
// - 1 left
// 1 - right

var projectList = ["yikyak","stayingstill","playlister","stubz","exp"];

function rotateDependent(orbit, direction, duration, distance){
	if(rotating)
		return;

	rotating = true;
	if(current_orbit == 1)
		currentRotation += degreesPRotation * direction;
	else if(current_orbit == 2)
		currentRotation2 += degreesPRotation2 * direction;

	    $(orbit).animate({deg: currentRotation}, {
        duration: duration * 1000,
        done: function(animation, jumpedToEnd){
        	rotating = false;
        },
        step: function(now){
            $(orbit).css({
                 transform: "scale(2) rotate(" + now + "deg)"
            });
        }
    });

    var objectList = $(orbit).children().children();
    console.log(objectList.length);
    objectList.each(function(){
    	var orbitObject = $(this).children();
    	orbitObject.animate({deg: $(this).children().attr("baseRot") - (degreesPRotation * direction)}, {
        duration: duration * 1000,
        done: function(animation, jumpedToEnd){
        	rotating = false;
        },
        step: function(now){
					if(now == 0){
						console.log(now);
					return;
				}
            orbitObject.css({
							//MOD
                 transform: "translateX(" + distance + "px) rotate(" + now + "deg)"
        	    });
        	}
	    });
			$(this).children().attr("baseRot", parseInt($(this).children().attr("baseRot")) - (degreesPRotation * direction))

	});
}

var touchEnabled = false;

$(document).ready(function(){
	$("#touchon").click(function(){
		touchEnabled = !touchEnabled;
		console.log("Touch controls " + touchEnabled);
		if(touchEnabled){
			$("#touchControls").css("opacity", 0.5);
			$("#tLeft").click(function(){
				if(isActive && touchEnabled)
					return;
				if(current_orbit == 1)
					rotateDependent('#orbitCenter', -1, 0.2,45);
				else if(current_orbit == 2)
					rotateDependent('#orbitSecondary', -1, 0.2,90);
			});
			$("#tRight").click(function(){
				if(isActive && touchEnabled)
					return;
					if(current_orbit == 1)
						rotateDependent('#orbitCenter', 1, 0.2,45);
					else if(current_orbit == 2)
						rotateDependent('#orbitSecondary', 1, 0.2,90);
			});
			$(".go").click(function(){
				if(!touchEnabled)
				return;
				if(isActive)
				returnToPosition();
				else
					animateObjectToRight($('#object' + calculateSelected()));
			});
		}
		else if(!touchEnabled){
			$("#touchControls").css("opacity", 0);
			$('#tLeft').off('click');
			$('#tRight').off('click');
			$('.go').off('click');

		}
	});
	priiLoad();
});

function active(){

		console.log("Document is ready for input");
		var rotatingChildren = $('#orbitCenter').children('.dead_center').children('.dead_center');
		degreesPRotation = 360 / rotatingChildren.length;
		var rotatingParents = $('#orbitCenter').children('.dead_center')

		//Seperate the rotatable objects directly after load
		var iteration= 0;
		rotatingChildren.each(function(){
			$(this).css('transform', 'rotate(' + iteration * degreesPRotation * -1 + 'deg)');
			$(this).children().first().attr("id","object" + iteration);
			$(this).children().first().attr('baseRot', iteration * degreesPRotation);
			iteration ++;
		});

		objectCount = iteration;

		var rotatingChildren2 = $('#orbitSecondary').children('.dead_center').children('.dead_center');
		degreesPRotation2 = 360 / rotatingChildren2.length;
		var rotatingParents2 = $('#orbitSecondary').children('.dead_center')

		//Seperate the rotatable objects directly after load
		var iteration2 = 0;
		rotatingChildren2.each(function(){
			$(this).css('transform', 'rotate(' + iteration2 * degreesPRotation2 + 'deg)');
			iteration2 ++;
		});

		$('#orbitCenter').css('visibility', 'hidden');
		$('#orbitSecondary').css('visibility', 'hidden');

		$('#noOrbit').toggleClass('jelly_scale_play');
		$('#orbitCenter').css('transform', 'scale(2)');
		$('#orbitSecondary').css('transform', 'scale(2)');

			rotateDependent('#orbitCenter', -1, 0.15,45);

			rotateDependent('#orbitCenter', 1, 0.15,45);
			rotateDependent('#orbitCenter', 1, 0.15,45);

			expandOrbit(1);



		//Legacy code
		$('#noOrbit').one('webkitAnimationEnd oanimationend msAnimationEnd animationend',
			function(e){
			$('#orbitCenter').css('visibility', 'visible');
			$('#orbitSecondary').css('visibility', 'visible');
		});
		document.title = "Andros (Mimerme) Yang";
}

function priiLoad(){
	console.log("Preloading iframes");
	for (var i = 0; i < projectList.length; i++) {
		console.log(projectList[i]);
		console.log(i);
		if(i == projectList.length - 1){
			$('body').append("<iframe class='cl' id='" + projectList[i] + "' src='sidebars/" + projectList[i] + ".html' frameborder='0' onload='finishLoad()'></iframe>");
		}
		else{$('body').append("<iframe class='cl' id='" + projectList[i] + "' src='sidebars/" + projectList[i] + ".html' frameborder='0'></iframe>");
	}

}
}

function expandOrbit(orbitLevel){
	if(orbitLevel == 1){
		$('#orbitCenter').children().children().each(function(){
			animateExpandObject($(this).children(), 45, 1)
		});
		animateExpandHighlight($('.highlight-lv1'), 270, 1);
	}
	else if(orbitLevel == 2){
		$('#orbitSecondary').children().children().each(function(){
			animateExpandObject($(this).children(), 115, 0.8)
		});
		animateExpandHighlight($('.highlight-lv2'), 540, 0.4);
	}
	rotating = false;
}

function animateExpandObject(jObject, translateLevel, duration){
	    jObject.animate({blankSpaceBaby: '[BABYS_NAME]'}, {
        duration: duration * 1000,
        step: function(now,fn){
        	fn.start = -25;
        	fn.end = translateLevel;

			//hacky workaround for dem glitchy animations
			if(now == 0)
				return;
            jObject.css({
                 transform: "translateX(" + now + "px) rotate(" + jObject.attr("baseRot") + "deg)"
            });
        }
    });
}

function calculateSelected(){
	return ((currentRotation/degreesPRotation))-(objectCount * (Math.floor(currentRotation/360)));
}

function animateExpandHighlight(jObject, scaleLevel, duration){
		jObject.animate({blankSpaceBaby: '[BABYS_NAME]'}, {
        duration: duration * 1000,
        step: function(now, fn){
        	fn.start = 0;
        	fn.end = scaleLevel;
            jObject.css({
                 "width": now + "px",
                 "height": now + "px"
            },'linear');
        }
    });

}
