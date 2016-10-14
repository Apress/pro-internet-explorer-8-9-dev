
//  Set innerHTML of an element whose id
//  matches the id parameter
function setTextAndClass(id, text) {
   try { 
      var element = document.getElementById(id + "text");  // Fix this error to correctly display status
      element.innerHTML = text;
      element.className = text;
   }
   catch(ex) { }
}

function debugConsole(data) {
   if(console) {
      console.debug(data);
   }
}

//  Create a new function on the console object
//  that will write a debug message to the
//  console only if a global debugging bit is
//  enabled
console.debug = function() { 
   if(debugging) {
      var concatArguments = ""; 
      for(var i = 0; i < arguments.length; i++)
         concatArguments += arguments[i]; 
      var now = new Date();
      console.log("Debug: " + concatArguments + 
                  " - " + now.toTimeString().split(" ")[0] + 
                  " " + String(now.getUTCMilliseconds()) + "ms");
   }
}