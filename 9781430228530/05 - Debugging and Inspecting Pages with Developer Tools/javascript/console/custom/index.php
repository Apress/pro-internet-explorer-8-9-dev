<?php

   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   
   $template = new template(true, array(
      VAR_TITLE       =>  "Custom Console Messages",
      VAR_MENUTITLE   =>  "",
      VAR_FILE        =>  __FILE__
   ));
   
   $template->start();
   
?>
<h3><i>See the Console Pane in the Developer Tools Script tab for output</i></h3>
<button onclick="customMethods();"><b>Display custom console messages</b></button>
<button onclick="clearConsole();">Clear Console</button>

<!--  Write basic console messages  -->
<script type="text/javascript">
   
   function customMethods() {
   
      //  Check if the console object exists
      if(window.console) {

         //  Create a new method on the console object
         console.debug = function() {

            //  Get all the arguments and concat them
            var concatArguments = arguments.join(" ");

            //  Grab the current date object
            var now = new Date();

            //  Construct a new message format that uses the
            //  "Debug: " prefix and appends a time to the end
            //  of the message
            console.info("Debug: " + concatArguments +
                         " - " + now.toTimeString().split(" ")[0] +
                         " " + String(now.getUTCMilliseconds()) + "ms");

         }

         //  Write to the console
         console.debug("This is a custom method!");
         console.debug("This is a custom method...", "with multiple input parameters");

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