<?php
   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   $template = new template("Using toStaticHTML", __FILE__);
   $template->start();
?>
      <p>Type some input into the box below.  If "safely handle input" is checked,
      the output will be run through toStaticHTML (if availalable).  If it is
      not, the output will be set as the innerHTML of a div.
      <p><input type="text" id="userInput" name="userInput">
      <input type="checkbox" id="sanitizeCheck" name="sanitizeCheck" checked> Safely handle input?
      <button name="displayOutput" id="displayOutput" onclick="processUserInput();">Display Output</button>
      <h3>Output:</h3><div id="outputContainer"></div>
      <script type="text/javascript">
         function processUserInput() {

            //  Simulate some evil input, such as script injection
            var evilInput = document.getElementById("userInput").value;
            var sanitizeCheck = document.getElementById("sanitizeCheck").checked;
            var doSanitize = (sanitizeCheck == true) ? true : false;
            var sanitizedInput = "";
            
            //  Sanitize input text if box is checked
            if(doSanitize) {

               // If toStaticHTML is defined, use it (otherwise, escape)
               if(typeof toStaticHTML == "object") sanitizedInput = toStaticHTML(evilInput);
               else sanitizedInput = escape(evilInput);
               
               //  Write sanitized input to the webpage
               setText(document.getElementById("outputContainer"), sanitizedInput);

            }
            
            //  Otherwise, write raw HTML to document 
            else document.getElementById("outputContainer").innerHTML = evilInput;

         }
      </script>
<?php
   $template->end();
?>
