<?php
   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   $template = new template("Cross-Browser AJAX Compatibility", __FILE__);
   $template->start();
?>
      <h3>Status of XmlHttpRequest object: <span id="status"></span></h3>
      <script type="text/javascript">
         
         //  Create a variable to hold the XMLHttpRequest object
         var xhr;

         //  Check to see if the native object exists
         if(window.XMLHttpRequest){ 
            xhr = new XMLHttpRequest();
            setText(document.getElementById("status"), "Created Native XHR.");
         }
         
         //  If no native object is found, check for the ActiveX object
         else if(window.ActiveXObject) {
            try {
               xhr = new ActiveXObject("Microsoft.XMLHTTP");
               setText(document.getElementById("status"), "Created ActiveX XHR.");
            } catch(e) {
               setText(document.getElementById("status"), "XHR not supported");
            }
         } else {
            //  Indicate failure to find any XHR object
            setText(document.getElementById("status"), "XHR not supported.");
         }
         
      </script>
<?php
   $template->end();
?>