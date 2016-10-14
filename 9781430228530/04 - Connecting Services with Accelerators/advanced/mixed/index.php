<?php

   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   
   $template = new template(true, array(
      VAR_TITLE       =>  "WOT",
      VAR_MENUTITLE   =>  "",
      VAR_FILE        =>  __FILE__
      ));
   
   $template->start();
   
?>

<button onclick="javascript:window.external.addService('wot.accelerator.xml');">
   <b>Install</b> the <b>WOT Reputation Scorecard</b> Accelerator
</button>

<?php

   $template->end();
   
?>