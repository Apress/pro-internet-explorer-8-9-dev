<?php
   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   $template = new template("Using JavaScript", __FILE__);
   $template->start();
?>
<h3>XMLHttpRequest object loaded? <span id="spanXhrJS">No</span></h3>
<script type="text/javascript">
   try {
      
      //  Create a new XMLHttpRequest object and send a GET
      //  request to http://examples.proiedev.com
      var xmlHttp = new ActiveXObject("Microsoft.XMLHTTP");
      xmlHttp.open("get", "http://examples.proiedev.com", true);
      
      //  Indicate success if the script made it this far
      setText(document.getElementById("spanXhrJS"), "Yes");
      
   } catch(e) { }
</script>
<?php
   $template->end();
?>