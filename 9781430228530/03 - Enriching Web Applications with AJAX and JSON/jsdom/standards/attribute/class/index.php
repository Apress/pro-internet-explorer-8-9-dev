<?php
   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   $template = new template("Accessing an Element's Class Information", __FILE__);
   $template->start();
?>
      <h3>&lt;div&gt; "classTest", getAttribute("class"): 
          <span id="attrClass"></span></h3>
      <h3>&lt;div&gt; "classTest", getAttribute("className"): 
          <span id="attrClassName"></span></h3>
      <h3>&lt;div&gt; "classTest", property .className: 
          <span id="propClassName"></span></h3>
      <div id="classTest" class="testClass"></div>
      <script type="text/javascript">
      
         //  Get the <div id="testClass"> element
         var divClassTest = document.getElementById("classTest");

         //  Attempt to access the attribute via getAttribute "class"
         try {
            var attrClass = divClassTest.getAttribute("class");
            setText(document.getElementById("attrClass"), attrClass.toString());
         } catch(e) {
            setText(document.getElementById("attrClass"), "—");
         }
         
         //  Attempt to access the attribute via getAttribute "className"
         try {
            var attrClassName = divClassTest.getAttribute("className");
            setText(document.getElementById("attrClassName"), attrClassName.toString());
         } catch(e) {
            setText(document.getElementById("attrClassName"), "—");
         }
         
         //  Attempt to access the attribute via property "className"
         try {
            var attrClass = divClassTest.className;
            setText(document.getElementById("propClassName"), attrClass.toString());
         } catch(e) {
            setText(document.getElementById("propClassName"), "—");
         }
         
      </script>
<?php
   $template->end();
?>