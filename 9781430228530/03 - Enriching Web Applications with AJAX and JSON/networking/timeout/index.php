<?php
   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   $template = new template("XMLHttpRequest Timeout", __FILE__);
   $template->start();
?>
      <h3>Request with 2s timeout: <span id="xhrSmallStatus"></span></h3>
      <h3>Request with 10s timeout: <span id="xhrLargeStatus"></span></h3>
      <h3>Exceptions:</h3>
      <div id="exceptions"><p></div>
      <script type="text/javascript">
      
         //  Define the XMLHttpRequest variables, the target page and
         //  elements that will be written to
         var xhrSmallTimeout; var xhrLargeTimeout;
         var targetPage = "http://examples.proiedev.com/03/networking/timeout/result.php";
         var spanXhrSmallStatus = document.getElementById("xhrSmallStatus");
         var spanXhrLargeStatus = document.getElementById("xhrLargeStatus");
         var spanExceptions     = document.getElementById("exceptions"); 
         
         
         function displayException(e, objectName) {
            spanExceptions.innerHTML += "<b>Object:</b> " + objectName + "<br>"
                                     +  "<b>Name:</b> " +  e.name + "<br>"
                                     +  "<b>Message:</b> " + e.message + "<p>";
         }
         
         //  Timeout callback for request with 2s timeout
         function timeoutRaisedSmall(){
            setText(spanXhrSmallStatus, "Timeout");
         }
         
         //  Timeout callback for request with 10s timeout
         function timeoutRaisedLarge() { 
            setText(spanXhrLargeStatus, "Timeout");
         }
         
         //  readyState callback for request with 2s timeout.  If an
         //  exception is raised, write it to the screen.
         function readyStateHandlerSmall() {
            if(xhrSmallTimeout.readyState == 4) {
               try {
                  setText(spanXhrSmallStatus, xhrSmallTimeout.responseText);
                } catch(e) { displayException(e, "xhrSmallTimeout"); }
            }
         }
         
         //  readyState callback for request with 10s timeout.  If an
         //  exception is raised, write it to the screen.
         function readyStateHandlerLarge() {
            if(xhrLargeTimeout.readyState == 4) {
               try {
                  setText(spanXhrLargeStatus, xhrLargeTimeout.responseText);
                } catch(e) { displayException(e, "xhrLargeTimeout"); }
            }
         }
         
         // Create a XMLHttpRequest object with a small (2 second)
         // timeout period
         xhrSmallTimeout = new XMLHttpRequest();
         xhrSmallTimeout.open("GET", targetPage, true);
         xhrSmallTimeout.timeout = 2000;
         xhrSmallTimeout.ontimeout = timeoutRaisedSmall;
         xhrSmallTimeout.onreadystatechange = readyStateHandlerSmall;
         
         // Create a XMLHttpRequest object with a large (10 second)
         // timeout period
         xhrLargeTimeout = new XMLHttpRequest();
         xhrLargeTimeout.open("GET", targetPage, true);
         xhrLargeTimeout.timeout = 10000;
         xhrLargeTimeout.ontimeout = timeoutRaisedLarge;
         xhrLargeTimeout.onreadystatechange = readyStateHandlerLarge;
         
         // Sent the XMLHttpRequests
         xhrSmallTimeout.send(null);
         xhrLargeTimeout.send(null);
         
      </script>
<?php
   $template->end();
?>