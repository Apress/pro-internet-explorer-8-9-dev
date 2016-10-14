<?php

   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   
   $template = new template(true, array(
      VAR_TITLE       =>  "Basic Console Messages",
      VAR_MENUTITLE   =>  "",
      VAR_FILE        =>  __FILE__
   ));
   
   $template->start();
   
?>
<h3><i>See the Console Pane in the Developer Tools Script tab for output</i></h3>
<button onclick="basicMessages();"><b>Write basic console messages</b></button>
<button onclick="clearConsole();">Clear Console</button>

<!--  Write basic console messages  -->
<script type="text/javascript">

   function basicMessages() {
   
      //  Check if the console object exists
      if(window.console) {

         //  Write entries to the console
         console.log("This is a log entry!");
         console.info("This is information!");
         console.warn("This is a warning!");
         console.error("This is an error!");
         console.assert(false, "This is an assert!");
         
      } else alert("Console object does not exist!");

   }
   
   function clearConsole() {
   
      //  Check if the console object exists
      if(window.console) {
      
         //  Clear the console
         console.clear();
         
      } else alert("Console object does not exist!");
   
   }
   
</script>
<?php 
   $template->end();
?>