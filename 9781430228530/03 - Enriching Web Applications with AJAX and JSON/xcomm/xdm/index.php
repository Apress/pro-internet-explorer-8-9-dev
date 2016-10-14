<?php
   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   $template = new template("Cross Frame Messaging with postMessage", __FILE__);
   $template->start();
?>
<h3>Parent Document (examples.proiedev.com)</h3>
Post message to remote document (www.ie-examples.com):&nbsp;&nbsp;
<input id="postDataInput" size="25" type="text">&nbsp;&nbsp;
<input onclick="postToRemote();" type="submit" value="Post Message"><br><br>
<iframe id="remoteFrame" src="http://www.ie-examples.com/03/xcomm/xdm/remote"
        width="400px" height="200px" class="highlightBorder" frameborder="no"></iframe>
<script type="text/javascript">

   //  Post contents of an input box to a remote page
   function postToRemote() {
   
      //  Grab the input value from the box (explicitly type as a string to
      //  avoid pulling in a VT_NULL (IE Bug) and quit if empty
      var postData = String(document.getElementById("postDataInput").value);
      if (postData == "") return;
      
      //  Use postMessage to send the string message over to the remote page
      var remote = document.getElementById("remoteFrame");
      remote.contentWindow.postMessage(postData, "http://www.ie-examples.com");

   }
   
</script>

<!-------------------------------------------------------->
<!-- START: Code for remote page on www.ie-examples.com -->
<!-------------------------------------------------------->

<!--
<html>
   <head>
      <title>Cross Frame Messaging with postMessage (Receiver)</title>
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
               document.getElementById("receivedDataOrigin").innerText = e.origin;
               document.getElementById("receivedDataContents").innerText = e.data;  
               document.getElementById("receivedDataType").innerText = e.type; 
               
            }
            
         }
         
      </script>
   </body>
</html>
-->

<!-------------------------------------------------------->
<!-- END:   Code for remote page on www.ie-examples.com -->
<!-------------------------------------------------------->

<?php
   $template->end();
?>