<?php
   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   $template = new template("Cross-Domain Requests", __FILE__);
   $template->start();
?>     
      <div id="resultDiv">
         <h3>Request to examples.proiedev.com: <span id="xdrAllowed"></span></h3>
         <h3>Request to www.ie-examples.com: <span id="xdrBlocked"></span></h3>
      </div>
      <!-- Include PPK's BrowserDetect script from QuirksMode.org -->
      <script type="text/javascript" src="browserdetect.quirksmode.js"></script>
      <script type="text/javascript">
      
         //  Create variables to hold XDomainRequest or instances of 
         //  XMLHttpRequest that offer origin header support
         var xdrAllowed = null; 
         var xdrBlocked = null;
      
         //  Callback functions for onload and onerror events in
         //  XDomainRequest/XMLHttpRequest
         function onLoadAllowed()  { displayEvent("xdrAllowed", xdrAllowed.responseText); }
         function onLoadBlocked()  { displayEvent("xdrBlocked", xdrBlocked.responseText); }
         function onErrorAllowed() { displayEvent("xdrAllowed", "Error") }
         function onErrorBlocked() { displayEvent("xdrBlocked", "Error") }

         //  Create XDomainRequest objects (or XMLHttpRequest objects
         //  if not IE and on a browser that offers origin header support)
         if(window.XDomainRequest) {
            xdrAllowed = new XDomainRequest(); xdrBlocked = new XDomainRequest();
         } else if((BrowserDetect.browser = "Firefox" && BrowserDetect.version > 3.5) ||
                   (BrowserDetect.browser = "Safari"  && BrowserDetect.version > 4)) {
            xdrAllowed = new XMLHttpRequest(); xdrBlocked = new XMLHttpRequest(); 
         }

         //  Only proceed if cross-domain protections are available
         //  otherwise write a "not-available" message to the page
         if(xdrAllowed != null && xdrBlocked != null) {
         
            //  Point the xdrAllowed object to examples.proiedev.com
            xdrAllowed.onload             = onLoadAllowed;
            xdrAllowed.onerror            = onErrorAllowed;
            xdrAllowed.open("GET", "http://examples.proiedev.com/03/xcomm/xdr/alloworigin/allow.php", true);
            
            //  Point the xdrAllowed object to www.ie-examples.com
            xdrBlocked.onload             = onLoadBlocked;
            xdrBlocked.onerror            = onErrorBlocked;
            xdrBlocked.open("GET", "http://www.ie-examples.com/03/xcomm/xdr/alloworigin/block.php", true);

            //  Send requests to each domain
            xdrAllowed.send(null);
            xdrBlocked.send(null);
            
         } else displayNotAvailableMessage();
         
         //  Display a message on the page indicating origin header support
         //  isn't available on the current browser
         function displayNotAvailableMessage() {
            var resultDiv = document.getElementById("resultDiv")
            resultDiv.innerHTML = "<h3>XDomainRequest and origin-restricted XMLHttpRequest "
                                + "are not available in this browser.</h3>";
         }
         
         //  Generic function to display data in an element
         function displayEvent(id, text) {
            var element = document.getElementById(id);
            setText(element, text);
         }
         
      </script>
<?php
   $template->end();
?>