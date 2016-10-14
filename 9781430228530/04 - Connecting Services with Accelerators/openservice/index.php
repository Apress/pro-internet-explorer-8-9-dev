<?php

   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   
   $template = new template(true, array(
      VAR_TITLE       =>  "Defining Accelerators with OpenService XML",
      VAR_MENUTITLE   =>  "",
      VAR_FILE        =>  __FILE__
      ));
   
   $template->start();
   
?>

<button onclick="javascript:window.external.addService('openservice.accelerator.xml');">
   <b>Install</b> the Accelerator Inspection Tool
</button>

<?php

   $template->end();
   
?>