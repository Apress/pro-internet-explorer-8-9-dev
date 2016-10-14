<html>
   <head>
      <title>postMessage Receiver</title>
      <meta content="no-cache" http-equiv="pragma">
      <style>
      body {
         text-align: left;
         font-family: Arial, Helvetica, Tahoma, sans-serif;
      }
      </style>
   </head>
   <body>
      <h3>Remote Page (www.ie-examples.com)</h3>
      Message Origin (e.origin): <span id="receivedDataOrigin"></span><br>
      Message Contents (e.data): <span id="receivedDataContents"></span><br>
      Message Type (e.type): <span id="receivedDataType"></span><br>
      <script type="text/javascript">
      
         //  Point the onmessage event callback to receiveData, either by 
         //  using addEventListener or attachEvent
         if(window.addEventListener)
            window.addEventListener("message", receiveData, false);
         else window.attachEvent("onmessage", receiveData); 

         //  Grab messages from the parent through this callback/event e
         function receiveData(e) {    
         
            //  Make sure that the origin server is examples.proiedev.com
            if (e.data != "" && e.origin == "http://examples.proiedev.com") {
            
               //  Write message data to the webpage            
               setText(document.getElementById("receivedDataOrigin"), e.origin);
               setText(document.getElementById("receivedDataContents"), e.data);  
               setText(document.getElementById("receivedDataType"), e.type); 
               
            }
            
         }
         
         //  Set element text (cross-browser innerText/textContent)
         function setText(element, text) {
            try { 
               if(typeof element.textContent == typeof undefined)
                  element.innerText = text;
               else element.textContent = text;
            }
            catch(e) { }
         }
         
      </script>
   </body>
</html>
