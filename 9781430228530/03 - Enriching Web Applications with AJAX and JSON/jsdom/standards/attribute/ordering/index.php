<?php
   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   $template = new template("Attributes Collection Ordering", __FILE__);
   $template->start();
?>
      <div id="resultsDiv"></div>
      <div class="someClass" style="display: none;" id="testDiv"></div>
      <script type="text/javascript">

         //  Return the names of the first 5 attributes on <div>
         var resultHTML = "";
         for(var i = 0; i < 5; i++) {
         
            //  Attempt to access the ith element of the <div id="testDiv"> attribute 
            //  collection
            var attrByArray = document.getElementById("testDiv").attributes[i];
            resultHTML += "<h3>Element [" + i + "] on &lt;div&gt;: " 
                          + ((attrByArray) ? attrByArray.name : "&mdash;") 
                          + "</h3>\r\n";
         
         }
         
         //  Output results to the screen
         document.getElementById("resultsDiv").innerHTML = resultHTML;   

      </script>
<?php
   $template->end();
?>