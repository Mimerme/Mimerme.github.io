$(document).ready(function(){

		$("#rss").rss("http://www.theverge.com/rss/frontpage", {
	    limit: 999,
	    layoutTemplate: '<section>{entries}</section>',
	    effect: 'slideFastSynced',
	    entryTemplate: '<center><font color="blue">{title}</font></center><center><dd>Published by <font color="red">{author}</font> on <font color="green">{date}</font></dd></center><center><button><script>console.log("View Summary for {title}"); console.log("http://smmry.com/" + "{url}")</script>Press F12 and view console to view summarys</button><a href= {url}>View Article</a></center><br>'
	}).show();
	$("#reddit").rss("http://www.reddit.com/r/tech/.rss", {
	    limit: 999,
	    layoutTemplate: '<section>{entries}</section>',
	    effect: 'slideFastSynced',
	    entryTemplate: '<center><font color="blue">{title}</font></center><center><dd>Published by <font color="red">{author}</font> on <font color="green">{date}</font></dd></center><center><button><script>console.log("View Summary for {title}"); console.log("http://smmry.com/" + "{url}")</script>Press F12 and view console to view summarys</button><a href= {url}>View Article</a></center><br>'
	}).show();
	console.log("No Copyright cause screw copyright laws");
	console.log("Developed By Andros (Mimerme) Yang");
	console.log("Hosted on Mimerme.github.io, domain provided by Github Pages");
	console.log("-------------------------------------------------------------");
	console.log("-------------------------------------------------------------");
});

function addListener(URL, title){
	console.log("adding button listener for " + title);
	console.log(URL);
	$("[id = " + "'" + title + "'" + "]").click(function() {
	prepareSummary(URL);
});
}

function sweg(erl){
	console.log(erl);
}

function prepareSummary(URL){



	//FUCK AJAX
/*	$("center").animate({left:'-30%'});

$.ajax({
    url: "http://api.smmry.com/&SM_API_KEY=94B9913126&SM_URL=http://www.theverge.com/2014/10/6/6901013/whats-happening-in-gamergate",
 
    // tell jQuery we're expecting JSONP
    dataType: "jsonp",
 
    // work with the response
    success: function( response ) {
        console.log( response ); // server response
    }
});

	$.ajax({
		dataType : "json",
		url :  "http://api.smmry.com/&SM_API_KEY=94B9913126&SM_URL=http://www.theverge.com/2014/10/6/6901013/whats-happening-in-gamergate",
		type : "POST",
		success:function(result){
				console.log(result);
		}
	});

/*	$.getJSON("http://api.smmry.com/&SM_API_KEY=94B9913126&SM_URL=http://www.theverge.com/2014/10/6/6901013/whats-happening-in-gamergate.json",
		type : "POST",
	 function(data){
		alert(data);
	});*/
}