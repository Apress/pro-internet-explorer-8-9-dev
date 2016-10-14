<?php
   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   $template = new template("Building Interoperable Cross-Domain Requests", __FILE__);
   $template->start();
?>     
      <div id="resultDiv">
         <h3>XDR over XDomainRequest? <span id="useXDR">No</span></h3>
         <h3>XDR over XMLHttpRequest? <span id="useXHR">No</span></h3>
      </div>
      <!-- Include PPK's BrowserDetect script from QuirksMode.org -->
      <script type="text/javascript" src="browserdetect.quirksmode.js"></script>
      <script type="text/javascript">
      
         //  Create variables to hold XDomainRequest or instances of 
         //  XMLHttpRequest that offer origin header support
         var xdrAllowed = null; 
         var xdrBlocked = null;

         //  Create XDomainRequest objects (or XMLHttpRequest objects
         //  if not IE and on a browser that offers origin header support)
         if(window.XDomainRequest) {
            xdrAllowed = new XDomainRequest(); xdrBlocked = new XDomainRequest();
            setText(document.getElementById("useXDR"), "Yes");
         } else if((BrowserDetect.browser = "Firefox" && BrowserDetect.version > 3.5) ||
                   (BrowserDetect.browser = "Safari"  && BrowserDetect.version > 4)) {
            xdrAllowed = new XMLHttpRequest(); xdrBlocked = new XMLHttpRequest(); 
            setText(document.getElementById("useXHR"), "Yes");
         }

      </script>
<?php
   $template->end();
?>