<?php
   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   $template = new template("Using VBScript", __FILE__);
   $template->start();
?>
<h3>XMLHttpRequest object loaded? <span id="spanXhrVB">No</span></h3>
<script type="text/vbscript">

   ''  Create a new XMLHttpRequest object 
   Set xmlHttp = CreateObject("Microsoft.XmlHttp")

   ''  Send a GET request to http://examples.proiedev.com
   If Err = 0 Then xmlHttp.open "get", "http://examples.proiedev.com", TRUE
   
   ''  Indicate success if the script made it this far
   If Err = 0 Then document.getelementbyid("spanXhrVB").innerText = "Yes"

</script>
<?php
   $template->end();
?>
