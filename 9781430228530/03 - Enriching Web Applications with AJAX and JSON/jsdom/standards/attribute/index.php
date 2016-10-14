<?php
   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   $template = new template("Attribute Object Changes", __FILE__);
   $template->start();
?>
      <ol>
         <li class="exnav"><a href="addeventlistener/">Handling the addEventListener Method</a></li>
         <li class="exnav"><a href="elementid/">Case Sensitivity in getElementById</a></li>
         <li class="exnav">Attribute Object Changes</li>
         <ol>
            <li class="exnav"><a href="collection/">Uninitialized Values</a></li>
            <li class="exnav"><a href="ordering/">Attributes Collection Ordering</a></li>
            <li class="exnav"><a href="class/">Class Attribute Changes</a></li>
         </ol>
      </ol>
<?php
   $template->end();
?>