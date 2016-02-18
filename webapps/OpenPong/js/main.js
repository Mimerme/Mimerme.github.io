$(document).ready(function(){
    console.log("Document Ready");
    createjs.Ticker.framerate = 60;
    var stage = new createjs.Stage("demoCanvas");
    
    var ball = new createjs.Shape();
    ball.graphics.beginFill("#ff0000").drawRect(0, 0, 10, 10);  
    ball.x = 250;
    ball.y = 150;
    ball.width = 10;
    ball.height = 10;
        
    var paddle1 = new createjs.Shape();
    paddle1.graphics.beginFill("#ff0000").drawRect(0, 0, 25, 100);  
    paddle1.x = 25;
    paddle1.y = 100;
    paddle1.width = 25;
    paddle1.height = 100;
    
    var paddle2 = new createjs.Shape();
    paddle2.graphics.beginFill("#ff0000").drawRect(0, 0, 25, 100);  
    paddle2.x = 475;
    paddle2.y = 100;
    paddle2.width = 25;
    paddle2.height = 100;
    
    new Ball(stage, ball);
    var p2 = new Paddle("Player 2", 2, stage, paddle1);
    var p1 = new Paddle("Player 1", 1, stage, paddle2);

});