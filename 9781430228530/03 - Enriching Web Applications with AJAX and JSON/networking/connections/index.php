<?php
   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   $template = new template("Concurrent Connections", __FILE__);
   //$template->setBodyAttrs(Array('onload' => 'getMaxConnections();'));
   $template->start();
?>
      <h3>Maximum connections per host: <span id="maxCon"></span></h3>
      <img src="images/1.jpg"><br>
      <img src="images/2.jpg"><br>
      <img src="images/3.jpg"><br>
      <img src="images/4.jpg"><br>
      <img src="images/5.jpg"><br>
      <img src="images/6.jpg"><br>
      <img src="images/7.jpg"><br>
      <img src="images/8.jpg">
      <script type="text/javascript">

         //  If the number of maxConnectionsPerServer is readable from
         //  script, display that value to the screen
         var spanMaxCon = document.getElementById("maxCon");
         if(window.maxConnectionsPerServer)
            setText(spanMaxCon, window.maxConnectionsPerServer);
         else setText(spanMaxCon, "—");
      
      </script>
<?php
   $template->end();
?>