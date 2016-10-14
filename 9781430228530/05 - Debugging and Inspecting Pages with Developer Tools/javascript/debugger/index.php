<?php

   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   
   $template = new template(true, array(
      VAR_TITLE       =>  "JavaScript debugging in action",
      VAR_MENUTITLE   =>  "",
      VAR_FILE        =>  __FILE__
   ));
   
   $template->start();
   
?>
<script type="text/javascript">
   
   //  Create a foo object that contains
   //  a variable bar
   function foo() {
   
      this.bar = "golden";
      
   }
      
   //  A function to display the current value of bar
   function displayBar() {
   
      try{

         //  Display the value of bar
         alert(myFoo.bar);
         
      } catch(exception) { }

   }
   
   //  Display the bar variable
   display();
   
</script>
<?php 
   $template->end();
?>