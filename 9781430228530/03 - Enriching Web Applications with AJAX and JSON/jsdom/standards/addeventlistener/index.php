<?php
   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   $template = new template("Handling the addEventListener Method", __FILE__);
   $template->start();
?>
      <h3>addEventListenter Support? <span id="supportAEL">No.</span></h3>
      <h3>attachEvent Support? <span id="supportAE">No.</span></h3>
      <h3>Function used: <span id="fallback"></span></h3>
      <script type="text/javascript">

         //  Determine if the browser supports addEventListener()
         if (window.addEventListener)
            setText(document.getElementById("supportAEL"), "Yes!");
         
         //  Determine if the browser supports attachEvent()
         if (window.attachEvent)
            setText(document.getElementById("supportAE"), "Yes!");

         //  Simulate a fallback chain used by many web applications
         if (window.addEventListener)
            setText(document.getElementById("fallback"), "addEventListener()");
         else {
            if (window.attachEvent)
               setText(document.getElementById("fallback"), "attachEvent()");
            else setText(document.getElementById("fallback"), "—");
         }
         
      </script>
<?php
   $template->end();
?>
