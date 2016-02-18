//Speed at which paddles move, play around with it
var debugSpeed = 400;
var audio = new Audio('sfx/bounce.wav');
var rallies = 0;

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
                listener.register_combo({
            "keys"  : "space",
            "on_keydown"    : function(){
                playing = true;
                changeStatus("Good Luck!");
            },                
    });
            listener.register_combo({
            "keys"  : "shift",
            "on_keydown"    : function(){
                debugSpeed /= 2;
            },
            "on_keyup"  : function(){
                debugSpeed *= 2;
            }
        });
}
 createjs.Ticker.addEventListener("tick", handleTick);
 function handleTick(event) {
        if(playing == false){
            shape.y = 200;
            shape.x = 25;
            return;
        }

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
        velX *= -1;
        audio.play();
        lastPaddle = 1;
    }
    else if((getBall.x <= paddle2X + 25 && velX < 0)){
        if(paddle2Y - 10 < getBall.y && paddle2Y + 100 > getBall.y){
        velX *= -1;
        audio.play();
        lastPaddle = 2;
        rallies++;
        $("p1").html("Rallies : " + rallies);
        ballSpeed =  0.01 + ballSpeed;
        $("p2").html("Ball Speed : " + Math.round(ballSpeed * 100) / 100);
        debugSpeed =  0.01 + debugSpeed;
        $("p3").html("Paddle Speed : " + Math.round(debugSpeed * 100) / 100);
        calcOffset();
        }
        else{
            changeStatus("Nice Score!");
            playing = false;
            getBall.x = 250;
            getBall.y = 150;
            velY = 0;
            velX = -180 * ballSpeed;
            rallies = 0;
            ballSpeed = 3.5;
            debugSpeed = 400;
            stage.update();
        }
        switch(rallies){
            case 5 : 
            changeStatus("Getting the hang of it");
            break;
            case 10 :
            changeStatus("You still reading this?")
            break;
            case 12 :
            changeStatus("No?")
            break;
            case 13 :
            changeStatus("Maybe this will get your attention")
            break;
            case 14 :
            changeStatus("##jksdna");
            break;            
            case 15 : 
            changeStatus("Gewjjkjkndas");
            break;
            case 16 :
            changeStatus("asdawasdasd")
            break;
            case 18 :
            changeStatus("That get your attention?")
            break;
            case 20 :
            changeStatus("Good")
            break;
            case 21 :
            changeStatus("Now play the game and read this at the same time");
            break;
            case 22 : 
            changeStatus("And say it outloud");
            break;
            case 23 :
            changeStatus("I")
            break;
            case 24 :
            changeStatus("Am")
            break;
            case 25 :
            changeStatus("Retarted")
            break;
            case 26 :
            changeStatus("Is anyone nearby laughing?");
            break;            
            case 28 : 
            changeStatus("Or did you just not do it");
            break;
            case 30 :
            changeStatus("Maybe this is to distract you so you don't beat my highscore")
            break;
            case 35 :
            changeStatus("Its 69")
            break;
            case 40 :
            changeStatus("zzZZZzz")
            break;
            case 45 :
            changeStatus("Oh wow you are still going");
            break;
            case 47 :
            changeStatus("What if...")
            break;
            case 50 :
            changeStatus("I multiply the speed by 1.5")
            break;
            case 52 :
            changeStatus("Yeah I'll do that!");
            ballSpeed *= 1.5;
            break;
            case 54 :
            changeStatus("You are still plaing?");
            break;
            case 56 :
            changeStatus("I've been typing random phrases for too long");
            break;
            case 57 :
            changeStatus("Speed x 2");
            ballSpeed *= 2;
            break;
            case 60 :
            changeStatus("You are STILL playing?");
            break;
            case 62 :
            changeStatus("Wow, wut a low-life");
            break;
            case 64 :
            changeStatus("Don't do it!");
            break;
            case 65 :
            changeStatus("YOU SHOULD BE DEAD");
            break;
            case 66 :
            changeStatus("DONT BEAT MY HIGHSCORE");
            break;
            case 67 :
            changeStatus("I WILL SHANK YOU AND YOUR FAMILY!");
            break;
            case 68 :
            changeStatus("...and...");
            break;
            case 70 :
            changeStatus("you beat it");
            break;
            case 72 :
            changeStatus("go die...");
            break;
            case 73 :
            changeStatus("...in a hole...");
            break;
            case 74 :
            changeStatus("...painfully...");
            break;
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
function changeStatus(newStatus){
    $("p4").html("Status : " + newStatus);
}