var current_orbit = 1;
var debug = false;
var DEBUG_UPDATE_SPEED = 250;
var interval;

$('html').keydown(function(eventData){
	console.log(eventData.which);
	switch(eventData.which){
	//Backspace
		case 40:
		if(!isActive)
			return;
		returnToPosition();
		break;

	//Right arrow
		case 39:
		if(isActive)
			return;
		if(current_orbit == 1)
			rotateDependent('#orbitCenter', 1, 0.15,45);
		else if(current_orbit == 2)
			rotateDependent('#orbitSecondary', 1, 0.15,90);
		break;
	//Left arrow
		case 37:
		if(isActive)
			return;
		if(current_orbit == 1)
			rotateDependent('#orbitCenter', -1, 0.15,45);
		else if(current_orbit == 2)
			rotateDependent('#orbitSecondary', -1, 0.15,90);
		break;
	//Enter
		case 38:
		if(isActive)
			return;
		animateObjectToRight($('#object' + calculateSelected()));
		break;

	//Debug mode
		case 68:
		console.log('Toggling debug mode')
		debug = !debug;
		if(debug){
			debugValues({
				'current_orbit': current_orbit,
				'DEBUG_UPDATE_SPEED' : DEBUG_UPDATE_SPEED,
				'degreesPRotation' : degreesPRotation,
				'degreesPRotation2' : degreesPRotation2,
				'currentRotation' : currentRotation,
				'currentRotation2'  :currentRotation2,
				'rotating' : rotating,
				'currentobjectselected': calculateSelected(),
				'dummy': activeObjectData.top + ' : ' + activeObjectData.left
			});
				//Current a debug loop to display the variables on screen
			interval = window.setInterval(function(){
				updateValues({
					'current_orbit': current_orbit,
					'DEBUG_UPDATE_SPEED' : DEBUG_UPDATE_SPEED,
					'degreesPRotation' : degreesPRotation,
					'degreesPRotation2' : degreesPRotation2,
					'currentRotation' : currentRotation,
					'currentRotation2'  :currentRotation2,
					'rotating' : rotating,
					'currentobjectselected': calculateSelected(),
					'dummy': activeObjectData.top + ' : ' + activeObjectData.left
				});
			}, DEBUG_UPDATE_SPEED);
		}
		else{
			$('debug').empty();
			window.clearInterval(interval);
			interval = null;
		}
		break;
	}
});

function debugValues(hashTable){
	console.log('Initialized Debug Elements');
	 for(var variable in hashTable)
	{
	    $('debug').append('<p class="black" id="' + variable + '">' + variable + ':' + hashTable[variable] + '</p>');
	}
}

function updateValues(hashTable){
	for(var variable in hashTable)
	{
	    $('#' + variable).text(variable + ':' + hashTable[variable]);
	}

}
