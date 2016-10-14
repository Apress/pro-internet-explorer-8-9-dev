<?php
   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   $template = new template("Online/Offline Events", __FILE__);
   $template->setBodyAttrs(Array('ononline' => 'onOnline();',
                                 'onoffline' => 'onOffline();',
                                 'onload' => 'onLoad();'
                                 ));
   $template->start();
?>
      <h3>Connectivity Status: <span id="status"></span></h3>
      <script type="text/javascript">
      
         //  When the browser goes online, write "Online" to the page
         function onOnline() {
            setText(document.getElementById("status"), "Online");
         }
         
         //  When the browser goes offline, write "Offline" to the page
         function onOffline() {
            setText(document.getElementById("status"), "Offline");
         }
         
         //  When the page loads, display the current connectivity status
         function onLoad() {
            setText(document.getElementById("status"),
               (window.navigator.onLine) ? "Online" : "Offline");
         }
         
      </script>
<?php
   $template->end();
?>