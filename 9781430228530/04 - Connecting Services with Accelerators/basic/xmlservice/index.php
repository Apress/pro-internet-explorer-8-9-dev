<?php

   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   
   $template = new template(true, array(
      VAR_TITLE       =>  "Constructing Accelerator XML and Services",
      VAR_MENUTITLE   =>  "",
      VAR_FILE        =>  __FILE__
      ));
   
   $template->start();
   
?>

<button onclick="javascript:window.external.addService('twitter.accelerator.xml');">
   <b>Install</b> the <b>Tweet This!</b> Accelerator!
</button>

<?php

   $template->end();
   
?>