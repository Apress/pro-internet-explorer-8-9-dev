<?php
   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   $template = new template("Persisting Data with DOM Storage", __FILE__);
   $template->setBodyAttrs(Array('onload' => 'getStorageData();'));
   $template->start();
?>
      <h3>Current Value: <span id="curVal"></span></h3>
      <h3>Current Value from <i>expando</i>: <span id="curValExpando"></span></h3>
      Set new text value:&nbsp;&nbsp;
      <input id="inputVal" size="20" type="text">
      <p><input onclick="setStorageData();" type="submit" value="Save Data">&nbsp;&nbsp;
      <button onclick="clearItems();">Clear Data</button>
      <h3>DOM Store information for <span id="infoDomain"></span></h3>
      <b>Length:</b> <span id="infoLength"></span> items<br>
      <b>Remaining Space:</b> <span id="infoRemaining"></span> KB<br>
      <script type="text/javascript">

         //  Create variables for the storage type
         var storageObject = localStorage;

         //  Read DOM Storage data for this domain
         function getStorageData() {
            
            //  Get the storage data via getItem. Make sure this value
            //  is string (IE Bug: empty values are returned as VT_NULL
            //  instead of a blank BSTR ("")
            var getItemData = storageObject.getItem('DOMStorageExample');
            if(getItemData == null) getItemData = "";
            
            //  Sanitize the data with toStaticHTML (if available)
            try { getItemData = toStaticHTML(getItemData); }
            catch(e) { escape(getItemData); }
            
            //  Write getItem results to the screen
            document.getElementById("inputVal").value = getItemData;
            setText(document.getElementById("curVal"), 
               (getItemData == "") ? "—" : getItemData);
            
            //  Get the value via an expando, again compensating for
            //  the VT_NULL bug
            var expandoData = storageObject.DOMStorageExample;
            if(expandoData == null) expandoData = "—";
            
            //  Sanitize the data with toStaticHTML (if available)
            try { expandoData = toStaticHTML(expandoData); }
            catch(e) { escape(expandoData); }
            
            //  Write expando results to the screen
            setText(document.getElementById("curValExpando"), expandoData); 
               
            //  Write domain info
            setText(document.getElementById("infoDomain"), document.domain);

            //  Display length if available
            var remainingSpace = "—";
            try { if(storageObject.remainingSpace != null &&
               typeof storageObject.remainingSpace != typeof undefined)
               remainingSpace = String(Math.round(storageObject.remainingSpace / 1024));
            } catch(e) { }
            setText(document.getElementById("infoLength"), storageObject.length);
            
            //  Display remainingSpace if available
            var remainingSpace = "—";
            try { if(storageObject.remainingSpace != null &&
               typeof storageObject.remainingSpace != typeof undefined)
               remainingSpace = String(Math.round(storageObject.remainingSpace / 1024));
            } catch(e) { }
            setText(document.getElementById("infoRemaining"), remainingSpace);
            
         }
         
         //  Write data into DOM Storage for this domain
         function setStorageData() {
         
            //  Set the contents of the input box to the storage
            var newValue = String(document.getElementById("inputVal").value);
            storageObject.setItem('DOMStorageExample', newValue);
            
            //  Re-display the storage data
            getStorageData();

         }
         
         //  Clear DOM Storage for this domain
         function clearItems() {
         
            //  Clear out data in the storage object
            storageObject.clear();
            
            //  Re-display the storage data
            getStorageData();
            
         }

      </script>
<?php
   $template->end();
?>