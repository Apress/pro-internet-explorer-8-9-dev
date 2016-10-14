<?php
   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   $template = new template("Case Sensitivity in getElementById", __FILE__);
   $template->start();
?>
      <h3>Access element with id "testdiv": <span id="caseInsensitive"></span></h3>
      <h3>Access element with id "testDiv": <span id="caseSensitive"></span></h3>
      <div id="testDiv"></div>
      <script>

         //  Attempt to access element testdiv
         try { 
            setText(document.getElementById("testdiv"), " ");
            setText(document.getElementById("caseInsensitive"), "Success!"); }
         catch(e) { setText(document.getElementById("caseInsensitive"), "Error"); }
         
         //  Attempt to access element testDiv
         try { 
            setText(document.getElementById("testDiv"), " ");
            setText(document.getElementById("caseSensitive"), "Success!"); }
         catch(e) { setText(document.getElementById("caseSensitive"), "Error"); }
         
      </script>
<?php
   $template->end();
?>