var velX = -180;
var velY = 1;
var lastPaddle = 0;
var getBall;
var ballSpeed = 2;

var paddle1X, paddle2X, paddle1Y, paddle2Y;

function Ball (stage, ball){
    velX *= ballSpeed;
    getBall = stage.addChild(ball);
    stage.update();
    
    createjs.Ticker.addEventListener("tick", handleTick);
    
 function handleTick(event) {
         if(getBall.y > 300 || getBall.y < 0){
                    velY = velY * -1;
                }
                ball.x += velX * (event.delta / 1000);
                ball.y += velY * (event.delta / 1000);
      stage.update();
     
        }
}