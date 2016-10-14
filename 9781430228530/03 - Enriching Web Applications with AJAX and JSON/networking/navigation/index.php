<?php

   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   
   $template = new template(true, array(
      VAR_TITLE       =>  "AJAX Navigation",
      VAR_MENUTITLE   =>  "",
      VAR_FILE        =>  __FILE__,
      VAR_BODY_ATTRS  =>  Array('onload' => 'onHashChange();')
   ));
   
   $template->start();
   
?>
<h2 id="title">Search Provider Wizard</h2>
<div id="stepPanel1">
   <h3>Step 1 - Choose search engine</h3>
   Welcome to the Search Provider Wizard!  Want a quick and easy way to query your favorite search engine using the nifty search box found in IE and Firefox?  Well, in just a few simple steps you can create a Search Provider extension for IE7, IE8, and other major browsers!
   <p>To begin, type in the URL (with protocol of your desired search engine (e.g. http://www.google.com).  Once you're ready, click <b>Next Step</b> to continue
   <p>Search Engine URL: <input type="text" id="spSearchUrl" value="">
</div>
<div id="stepPanel2">
   <h3>Step 2 - Perform a sample search query</h3>
   <p>The search engine you chose was opened in another window.  Please search the term "TEST" (in all captial letters).
   Once the search results are finished loading, paste the contents of the address bar into the box below then click the <b>Next Step</b> button. 
   <p><img src="address.png" alt="Picture of browser address bar.">
   <p>URL from Address Bar: <input type="text" name="uri" id="spUri" value="" maxlength="" /> 
</div>
<div id="stepPanel3">
   <h3>Step 3 - Describe the search provider</h3>
   Great!  To finish the process, describe the search engine.  Type in a name and description in the fields below.  Optionally, you can link to an icon (a url) and list your name/contact information.  If you need this page to be encoded in a certain character set other than UTF-8, select that set from the dropdown.
   <p>Name: <input type="text" name="name" id="spName" value="" maxlength="" />
   <p>Description: <input type="text" name="desc" id="spDesc" value="" maxlength="" />
   <p><i>Icon: (Optional):</i> <input type="text" name="icon" id="spIcon" value="" maxlength="" />
   <p><i>Author Name: (Optional):</i> <input type="text" name="dev" id="spDev" value="" maxlength="" />
   <p><i>Contact Info: (Optional):</i> <input type="text" name="contact" id="spContact" value="" maxlength="" />
   <p><i>Encoding (Optional):</i>
   <select name="enc" id="spEnc"> 
      <? 
         $langs = explode("\n",trim(file_get_contents('languages.csv')));
         foreach($langs as $lang) { 
            $kv = explode(",", trim($lang));
            echo("<option value=\"".$kv[0]."\">".$kv[1]."</option>");
         }
      ?>
   </select>
</div>
<div id="stepPanel4">
   <h3>Step 4 - Download and Install!</h3>
   Congrats! Your new search provider has been created!  To install, click on the <b>Install Search Provider</b> button below; to download, press <b>Download Search Provider</b> button below.
   <p>
   <button onclick="getSearchProvider(true)"><b>Install</b> Search Provider</button>&nbsp;&nbsp;
   <button onclick="getSearchProvider(false)"><b>Download</b> Search Provider</button>
</div>
<p>
<button id="previousStep" onclick="previous()">Previous Step</button>&nbsp;&nbsp;
<button id="nextStep" onclick="next()">Next Step</button>
<script type="text/javascript">

   //  Define the current, min, and max steps.
   var currentStep = 1; 
   var minStep = 1; var maxStep = 4;
   
   //  Define a variable to hold the request URL
   var buildRequest = "";
   
   function next() {
      
      //  Stop if the current step is already at/above max
      if(currentStep >= maxStep) return;
      
      //  Increase the current position, set that position to the
      //  hash, and display the panel for this new step
      currentStep++;
      window.location.hash = currentStep;
      loadPanelForStep();
      
   }
   
   function previous() {
      
      //  Stop if the current step is already at/below min
      if(currentStep <= minStep) return;
      
      //  Decrease the current position, set that position to the hash, and 
      //  display the panel for this new step
      currentStep--; 
      window.location.hash = currentStep;
      loadPanelForStep();
      
   }
   
   function onHashChange() {
   
      //  Grab the step specified by the hash as an Integer
      var hashStep = parseInt(window.location.hash.substr(1));
      
      //  If the hash value isn't a valid number, start at the first step. If 
      //  it is out of bounds, snap to the closest limit.  Otherwise, set the 
      //  current step to be the one specified in the hash
      if(isNaN(hashStep))         currentStep = minStep;
      else if(hashStep < minStep) currentStep = minStep;
      else if(hashStep > maxStep) currentStep = maxStep;
      else                        currentStep = hashStep;
      
      //  Display panel for the current step
      loadPanelForStep();
      
   }

   function loadPanelForStep() {
   
      //  Disable the previous button if on the first panel and
      //  disable the next button of on the last
      document.getElementById("previousStep").disabled = (currentStep <= minStep) ? true : false;
      document.getElementById("nextStep"    ).disabled = (currentStep >= maxStep) ? true : false;
      
      //  Show the current panel and hide all others
      for(var i = minStep; i <= maxStep; i++) {
         var display = ((i == currentStep) ? "block" : "none");
         document.getElementById("stepPanel" + i).style.display = display;
      }
      
      //  Perform step-specific actions
      switch(currentStep) {
         case 2:
            window.open(String(document.getElementById("spSearchUrl").value), "_blank");
            break;
         case 4:
            buildRequest = "http://examples.proiedev.com/03/networking/navigation/result.php?"
                         + "name="     + encodeURI(String(document.getElementById("spName"   ).value)) + "&"
                         + "desc="     + encodeURI(String(document.getElementById("spDesc"   ).value)) + "&"
                         + "uri="      + encodeURI(String(document.getElementById("spUri"    ).value)) + "&"
                         + "icon="     + encodeURI(String(document.getElementById("spIcon"   ).value)) + "&"
                         + "dev="      + encodeURI(String(document.getElementById("spDev"    ).value)) + "&"
                         + "contact="  + encodeURI(String(document.getElementById("spContact").value)) + "&"
                         + "enc="      + encodeURI(String(document.getElementById("spEnc"    ).value));
            break;
         default: break;
      }
      
   }
   
   function getSearchProvider(install) {
      
      //  If install is true, attempt to point IE to the new search
      //  provider
      if(install && window.external.AddSearchProvider) 
         window.external.AddSearchProvider(buildRequest);
         
      //  If not install or not IE, just download the XML file
      else window.open(buildRequest, "_blank");
      
   }
   
</script>
<?php
   $template->end();
?>