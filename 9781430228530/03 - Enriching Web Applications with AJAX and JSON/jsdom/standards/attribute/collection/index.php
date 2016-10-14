<?php
   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   $template = new template("Uninitialized Values and the Attributes Collection", __FILE__);
   $template->start();
?>
      <h3>Attribute "checked" exists on "checkBox": 
      <span id="attrCheckBox"></span></h3>
      <h3>Attribute "checked" exists on "checkBoxChecked": 
      <span id="attrCheckBoxChecked"></span></h3>
      "checkBox" Object: <input type="checkbox" id="checkBox"><br>
      "checkBoxChecked" Object: <input type="checkbox" id="checkBoxChecked" checked>
      <script>

         //  Attempt to access the "checked" attribute of checkbox "checkBox"
         var attrCheckBox 
            = document.getElementById("checkBox").getAttribute("checked");
         setText(document.getElementById("attrCheckBox"),
            (attrCheckBox) ? "True" : "False");
         
         //  Attempt to access the "checked" attribute of checkbox "checkBoxChecked"
         var attrCheckBoxChecked 
            = document.getElementById("checkBoxChecked").getAttribute("checked");
         setText(document.getElementById("attrCheckBoxChecked"),
            (attrCheckBoxChecked) ? "True" : "False");
         
      </script>
<?php
   $template->end();
?>