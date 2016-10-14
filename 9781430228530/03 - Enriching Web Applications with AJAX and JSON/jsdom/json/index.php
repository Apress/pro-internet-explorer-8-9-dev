<?php
   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   $template = new template("Native JSON Support", __FILE__);
   $template->start();
?>
      <h3>Original String:</h3><span id="original"></span>
      <h3>Parsed JSON:</h3><span id="parsed"></span>
      <h3>Stringified JSON:</h3><span id="result"></span>
      <script type="text/javascript">
      
         //  Define a new serialized JSON object
         var contactStr = "{ \"firstname\" : \"Nick\", \"lastname\" : " + 
                          "\"Tierno\", \"address\" : { \"street\" : \"123 Euclid " +
                          "Avenue\", \"city\" : \"Cleveland\", \"state\" : " +
                          "\"OH\", \"postalCode\" : 44106 }, \"phone\" : [ " + 
                          "\"+1 555 867 5309\", \"+1 555 TIERNO0\" ] }";
         //  Write that string to the page
         setText(document.getElementById('original'), contactStr);
      
         //  Check if the JSON object exists
         if(window.JSON) {

            // Convert contactStr to a JSON JavaScript object
            var contactObjectJSON = JSON.parse(contactStr);
            var outputFromJSON = "Name: " + contactObjectJSON.firstname + " " 
                                 + contactObjectJSON.lastname + "\n" +
                                 "Address: " + contactObjectJSON.address.street 
                                 + ", " + contactObjectJSON.address.city 
                                 + ", " + contactObjectJSON.address.state + " " 
                                 + contactObjectJSON.address.postalCode + "\n"
                                 + "Phone: " + contactObjectJSON.phone[0] + " " 
                                 + contactObjectJSON["phone"][1];
            setText(document.getElementById('parsed'), outputFromJSON);

            // Convert contactJSON back to a string
            var contactStrRedux = JSON.stringify(contactObjectJSON);
            setText(document.getElementById('result'), contactStrRedux);
            
         //  Display an error message if the JSON object doesn’t exist
         } else {
            setText(document.getElementById("parsed"), 
               "Error: window.JSON object does not exist.");
            setText(document.getElementById("result"), 
               "Error: window.JSON object does not exist.");
         }

      </script>
<?php
   $template->end();
?>