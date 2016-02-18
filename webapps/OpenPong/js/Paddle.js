//Speed at which paddles move, play around with it
var debugSpeed = 240;
function Paddle(name, playerValue, stage, shape){
    var dirMoving = "still";
    var player = playerValue;
    this.name = name;
    this.stage = stage;
    var _shape = stage.addChild(shape);
    stage.update();
    
     var listener = new window.keypress.Listener();
    
if(playerValue == 1){
    paddle1X = shape.x;
    paddle1Y = shape.y;
        listener.register_combo({
            "keys"  : "up",
            "on_keydown"    : function(){
                dirMoving = "up";
            },
             "on_keyup"  : function(){
                dirMoving = "still";   
            }
    });
        listener.register_combo({
            "keys"  : "down",
            "on_keydown"    : function(){
                dirMoving = "down";
            },
             "on_keyup"  : function(){
                dirMoving = "still";   
            }
    });
}
else if(playerValue == 2){
    paddle2X = shape.x;
    paddle2Y = shape.y;
        listener.register_combo({
            "keys"  : "w",
            "on_keydown"    : function(){
                dirMoving = "up";
            },
             "on_keyup"  : function(){
                dirMoving = "still";   
            }
    });
        listener.register_combo({
            "keys"  : "s",
            "on_keydown"    : function(){
                dirMoving = "down";
            },
            "on_keyup"  : function(){
                dirMoving = "still";   
            }
    });
}
 createjs.Ticker.addEventListener("tick", handleTick);
 function handleTick(event) {
            if(dirMoving == "up"){
                shape.y -= debugSpeed * (event.delta / 1000);
            }
            else if(dirMoving == "down"){
                shape.y += debugSpeed * (event.delta / 1000);
            }
     
     if(dirMoving != "still"){
         if(player == 2){
             paddle2Y = shape.y;
         }
         else if(player == 1){
             paddle1Y = shape.y;
         }
     }
     
      checkIntersection();
      stage.update();
     
        }
}

Paddle.prototype.getInfo = function(){
    return this.player;
}
Paddle.prototype.getName = function(){
    return this.name;
}
this.checkIntersection = function() {
    
    if((getBall.x >= paddle1X - 2 && velX > 0)){
        if(paddle1Y < getBall.y && paddle1Y + 100 > getBall.y){
        velX *= -1;
        lastPaddle = 1;
        calcOffset();
        }
    }
    else if((getBall.x <= paddle2X + 25 && velX < 0)){
        if(paddle2Y < getBall.y && paddle2Y + 100 > getBall.y){
        velX *= -1;
        lastPaddle = 2;
        calcOffset();
        }
    }
}
//Callculate angle offset when ball is returned
this.calcOffset = function(){
    if(lastPaddle == 1){
        velY = (getBall.y - paddle1Y - 50) * ballSpeed;
    }
    else if (lastPaddle == 2){
        velY = (getBall.y - paddle2Y - 50) * ballSpeed;
    }
}