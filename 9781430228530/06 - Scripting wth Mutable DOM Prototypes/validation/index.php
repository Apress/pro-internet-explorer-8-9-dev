<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
   <head>
      <meta http-equiv="X-UA-Compatible" content="IE=8" />
      <title>Test</title>
      <style type="text/css">
      
         div#example-form-container {
            margin: 20px;
            padding: 20px;
            
         }
      
         form span.label {
            font-family: "Georgia", serif;
            font-size: 12px;
            font-weight: bold;
         }
         input.text {
            border: 1px solid 666;
            padding: 5px;
            margin: 0;
            font-family: "Arial", Helvetica, sans-serif;
            font-size: 16px;
            
         }
         
      </style>   

<style type="text/css">
   
   input.validationFail {
      background: #ffdddd;
   }
   
   input.validationPass {
      background: #ddffdd;
   }
   
   label.validationFail {
      font-family: "Georgia", serif;
      font-style: italic;
      margin-top: 15px;
      padding: 7px;
      border-left: 3px solid red;
      background: #ffdddd;
      display: block;
   }
   
   label.validationPass {
      display: none;
   }

</style>   
      
<script type="text/javascript">

   //  If a class selector does not exist on an element, add it
   function addClass(selector) {
      if(!this.hasClass(selector)) {
         try {
            var attrClass = this.getAttribute("class");
            this.setAttribute("class", attrClass + ' ' + selector);
         } catch(ex) { return false; }
         return true;
      } else { return true; }
   };
   
   //  If a class selector exists on an element, remove it
   function removeClass(selector) {
      if(this.hasClass(selector)) {
         try {
            var attrClass = this.getAttribute("class");
            this.setAttribute("class", attrClass.replace('/\b' + selector + '\b/',''));
         } catch(ex) { return false; }
         return true;
      } else { return true; }
   }
   
   //  Indicate whether or not an element uses a certain class selector
   function hasClass(selector) {
      var attrClass = this.getAttribute("class");
      return regexMatch(attrClass, '/\b' + selector + '\b/');
   }

   //  Assign the addClass, removeClass, and hasClass functions
   //  to the Element object
   Element.prototype.addClass = addClass; 
   Element.prototype.removeClass = removeClass; 
   Element.prototype.hasClass = hasClass; 
   


   //  A function to determine if a source contains one or more matches of
   //  a pattern based on PREGs
   function regexMatch(source, pattern) {
      
      //  Create a new regular expression from the pattern
      var regEx = new RegExp(pattern);
      
      //  Execute that pattern against the source
      var matches = regEx.exec(source);
      
      //  Return false if there are no matches, true if one or more exist
      if (matches == null) { return false; }
      else { return true; }
      
   }
   
   //  Array that defines different validation classes, their error strings,
   //  and their associated regular expressions
   var regexValidators = { 
      '.validateAlpha'     : [
         'This item may only contain letters.' ,
         /^[a-zA-Z]+$/],
      '.validateNumeric'      : [
         'This item may only contain numbers.' ,
         /^[0-9]+$/, ],
      '.validateAlphanumeric' : [
         'This item may only contain numbers and letters.' ,
         /^[0-9a-zA-Z]+$/ ],
      '.validateEmail'        : [
         'This item must be a valid email address' ,
         /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/ ],
      '.validateUrl'          : [
         'This item must be a valid URL.',
         /^(http[s]?:\/\/|ftp:\/\/)?(www\.)?[a-zA-Z0-9-\.]+\.(com|org|net|mil|edu|ca|co.uk|com.au|gov)$/ ],
      '.validatePhoneNumber'  : [
         'This item must be a valid phone number.',
         /^(([0-9]{1})*[- .(]*([0-9a-zA-Z]{3})*[- .)]*[0-9a-zA-Z]{3}[- .]*[0-9a-zA-Z]{4})+$/ ]
   };
   

   
   //  The getLabel function finds a label tag associated with
   //  the current element
   function getLabel() {
   
      //  Get all labels in the document
      var labels = document.getElementsByTagName("label");
      
      //  Loop through all document labels
      for(i = 0; i < labels.length; i++){
      
         //  If the associated "for" id is the id of this 
         //  element, return it
         if(labels[i].htmlFor == this.id) { return labels[i]; }
      }
      
      //  If no label is found, return false
      return false;
      
   }
   
   //  Assign the getLabel function to the input element object
   HTMLInputElement.prototype.getLabel = getLabel;


   // Customize the DOM by accessing HTMLDocument's and
   // Element's prototype and extending their functionality
   // to include the validate() method.
   function validate() {
   
      //  Create a variable to mark validation progress
      var pass = true;
     
      //  Loop through each validation type           
      for (key in regexValidators) {
      
         //  Get the error message and regex for this validation type
         var errorMessage   = regexValidators[key][0];
         var regexValidator = regexValidators[key][1];

         //  Grab all elements opting into this validation type
         var inputs = document.querySelectorAll(key);

         //  Loop through each element and check if its value passes
         //  validation.  If it doesn't, ensure overall validation progress
         //  fails and this element's label indicates failure type               
         for (i = 0; i < inputs.length; i++) {
            if (!regexMatch(inputs[i].value, regexValidator)) {
               pass = false;
               associatedLabel = inputs[i].getLabel();
               inputs[i].removeClass("validationPass");
               inputs[i].addClass("validationFail");
               associatedLabel.innerText = errorMessage;
               associatedLabel.removeClass("validationPass");
               associatedLabel.addClass("validationFail");
            }
            else {
               associatedLabel = inputs[i].getLabel();
               inputs[i].removeClass("validationFail");
               inputs[i].addClass("validationPass");
               associatedLabel.innerText = "";
               associatedLabel.removeClass("validationFail");
               associatedLabel.addClass("validationPass");
            }
         }

      }
      
      //  Return the overall validataion status
      return pass;
      
   }
   
   //  Assign the validate function to the document object
   HTMLDocument.prototype.validate = validate;

   
   //  Function that calls validation on the document object
   function submitForm() {
   
      //  Validate forms in the document
      document.validate();
      
   }
   
</script>

   </head>
   <body>

      <div id="example-form-container">
         
<form action="javascript:submitForm()">
   <p>
      <span class="label">name:</span><br />
      <input type="text" id="name" name="name" class="text validateAlpha" /><br />

      <label for="name" id="nameLabel"></label>
   </p>
   <p>
      <span class="label">email:</span><br />
      <input type="text" id="email" name="email" class="text validateEmail" /><br />

      <label for="email" id="emailLabel"></label>
   </p>
   <p>
      <span class="label">homepage:</span><br />
      <input type="text" id="homepage" name="homepage" class="text validateUrl" /><br />

      <label for="homepage" id="homepageLabel"></label>
   </p>
   <input type="submit" id="submit" name="submit" value="Submit" />
</form>

      </div>
      
   </body>
   
</html>