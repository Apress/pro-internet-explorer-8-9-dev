<?php

   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   
   $template = new template(true, array(
      VAR_TITLE       =>  "String Substitution in Console Messages",
      VAR_MENUTITLE   =>  "",
      VAR_FILE        =>  __FILE__
   ));
   
   $template->start();
   
?>
<h3><i>See the Console Pane in the Developer Tools Script tab for output</i></h3>
<button onclick="stringSubstitution();"><b>Display messages with string substitution</b></button>
<button onclick="clearConsole();">Clear Console</button>

<!--  Write basic console messages  -->
<script type="text/javascript">
   
   function stringSubstitution() {
   
      //  Check if the console object exists
      if(window.console) {

         //  Define some variables
         var u = 3.14159;     //  Double (Float)
         var v = 8675309;     //  Float
         var x = 42;          //  Integer
         var y = new Date();  //  Object
         var z = "Marmite";   //  String

         //  Write to the console
         console.log("Double: %d", u);
         console.info("Floats: %f %f", v, u);
         console.warn("Integer: %i", x);
         console.error("Object: ", y);
         console.assert(false, "String: %s", z);

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