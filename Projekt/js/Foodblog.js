/*"use strict";
window.onload=function()
{
    var memorycard = document.getElementsByClassName("card");
    var myTry = 0;
    var umgedrehte = [];
    var erste;
    var locked = [];
    var isAlreadyTurned = false;
          
for(var i=0; i<memorycard.length;i++)
    {
        memorycard[i].onclick= function(){
                         
                if(myTry !=2)
                {
                    console.log("Try");
                    for(var j=0;j<locked.length;j++)
                        {
                            console.log("in der schleife");
                            console.log(locked[j],memorycard[i]);
                            if(locked[j]===memorycard[i])
                                {
                                    isAlreadyTurned=true;
                                    alert("You already turned that card!");
                                }
                            
                        }    
                    
                            if(!isAlreadyTurned){
                                console.log("is nicht gelocked");
                                  if(this.alt=="Burger")
                                  {
                                      this.src="img/FoodGame/Burger.jpg";
                                      this.title= "Burger";
                                      locked.push(this);
                                      console.log("gelocked");
                    
                                  }
                                else if(this.alt=="Pizza")
                                {
                                    this.src="img/FoodGame/Pizza.jpg";
                                    this.title= "Pizza";
                                    locked.push(this);
                                    console.log("gelocked");
                                }
                                else if(this.alt=="Nudeln")
                                {
                                    this.src="img/FoodGame/Nudeln.jpg";
                                    this.title= "Nudeln";
                                    locked.push(this);
                                    console.log("gelocked");
                                }
                
                                if(myTry==0){ 
                                    erste = this.title;
                                    umgedrehte.unshift(this);
                                    console.log(umgedrehte);
                                }
                   
                                myTry = myTry+1;
                                
                                
                                }
                    
                            isAlreadyTurned = false;
                        }
                    

            
            if(myTry == 2)
            {
                console.log("Try 2 unten");
            
                    if(erste===this.title)
                        {
                           console.log("yeey");
                            umgedrehte.unshift(this);
                            console.log(umgedrehte);
                            myTry=0;
            
                        }
                   else
                        {
                           console.log("im else");
                            setTimeout(turnBack, 1000);
                             umgedrehte.shift();
                            console.log("shifted");
                            myTry=0;
                            
                            
                        }

            }
          
    }
    
 
    
    function turnBack(){      
        
        
        for(var i=0; i<memorycard.length;i++){
            if(memorycard[i].title != "verdeckt" )
                {
                    if(memorycard[i]!=umgedrehte[0]&&memorycard[i]!=umgedrehte[1])
                    memorycard[i].src="img/FoodGame/Testhintergrund.png";
                    memorycard[i].title = "verdeckt";
                    locked.length=0;
                    
                }
            
        }
       
        
    }
    
    //_______________________________________________________
    
   function nochmal(){
        
        if(umgedrehte.length===6)
            {
               for(var i=0; i<memorycard.length;i++){
        
                    memorycard[i].src="img/FoodGame/Testhintergrund.png";
                    memorycard[i].title = "verdeckt";
                    
                } 
                umgedrehte.length=0;
            }
        else{
            alert("You have unlimited tries!");
        }
         
            
        }
        
    
    var but = document.getElementsByClassName("button")[0];
    
    but.onclick = nochmal;
    
    
    
    }
    
    
}*/
"use strict";
window.addEventListener('load', function ()
{
     
    var essen = document.getElementById("Essen");
    var radio = document.getElementsByName("Geschlecht");
    var spiel = document.getElementById("Spiel");
    //var absenden = document.getElementById("send");
    var h2 = document.getElementsByTagName("h2")[0];
     
     
    //console.log(absenden);
    //console.log(essen);
    //console.log(radioState);
     
     
    //absenden.onclick = function(){ Essencontrol(essen)}
     
        /* INPUT RADIO ÜBERPRÜFUNG  */
     
    
     
    /* INPUT RADIO ÜBERPRÜFUNG ENDE */
     
    /* INPUT ESSEN ÜBERPRÜFUNG */
     
    var erlaubt = /^[a-zA-Z]+$/;
    var empty = " ";
     
     var radioState = false;
        //console.log(radioState);
         
        for(var i=0;i<radio.length;i++)
        {
            radio[i].addEventListener('click',checkRadio,false);
            //console.log(radio[i].value);
        }
 
     
        function checkRadio()
        {
            radio = document.querySelectorAll('input[name="Geschlecht"]:checked');
            console.log(radio);
            if(radio == "maennlich"||"weiblich")
            {   
                 
                radioState = true;
                console.log(radioState);
                //return radioState;
            }
        }
         
     
    document.querySelector(".Umfrage").addEventListener("submit" , function (e)                                                      
    {
        
        var Ausgabe = "Error: \n";
        var ec1 = false;
        var ec2 = false;
        var sc = false;
        var gc = false;
        e.preventDefault();
        //console.log(essen.value);
        if(essen.value.match(erlaubt))
            {
                //alert("yes")
            }
        else
            {
                if(essen.value.length == 0)
                    {
                        Ausgabe += "Sag uns dein Lieblingsessen" + "\n";
                        var ec1 = true;
                        console.log(ec1);
                    }
                else
                    {
                    Ausgabe += "Nur Buchstaben beim Essen eingeben" + "\n";
                         var ec2 = true;
                    }
            }
          
         
        if(spiel.value.length == 0)
                    {
                        Ausgabe += "Sag uns dein Lieblingsspiel" + "\n";
                        var sc = true;
                    }
     
       if(!radioState)
            {
                Ausgabe += "Wähle ein Geschlecht";
                var gc = true;
            }
         
         
        if(ec1 || ec2 || sc || gc)
            {
                alert(Ausgabe);
            }
        
         
         
     });  
         
})    
         
     
 
    /* INPUT ESSEN ÜBERPRÜFUNG ENDE */
 
 
   
     
    /*
     
    var img = new Image,
          c = document.getElementById('myCanvas').getContext('2d');
 
    img.src = "img/FoodGame/Player.png";
    img.addEventListener('load', function () 
    {
 
        var interval = setInterval(function() 
        {
            var x = 0, y = 0;
 
            return function () 
            {
                c.clearRect(0, 0, c.canvas.width, c.canvas.height);
                c.drawImage(img, x, y);
 
                x += 1;
                if (x > c.canvas.width) 
                {
                x = 0;
                }
            };
             
        }(), 1000/40);
    }, false);
     
    
     
}, false);
 
 
 
 
 
/*window.onload=function()
{   
    animate();
    var x = 0;
    var y = 15;
    var speed = 3;
     
    
 
    //c.fillStyle= "#f00";
    //c.fillRect(0,0,50,50);
     
    function animate() 
    {
        requestAnimationFrame(animate);
  
        x += speed;
        if(x <= 0 || x >= 1000)
        {
            speed = -speed;
        }
         
        draw();
    }
     
    function draw()
    { 
        var canvas = document.getElementById("myCanvas");
        var c = canvas.getContext("2d");
         
        var image = new Image();
        image.src = "img/FoodGame/Player.png";
     
        image.onload = function()
        {
            c.drawImage(image,x,y,100,100);
        }
         
    }
}*/