<html>
   <head>
      <title>Test</title>
   </head>
   <body>


<script type="text/javascript">

   //  Create variables to hold the default set and get
   //  attribute functions
   var defaultSetAttribute = Element.prototype.setAttribute;
   var defaultGetAttribute = Element.prototype.getAttribute;

   //  Overwrite the default setAttribute function
   Element.prototype.setAttribute = function (attribute, value) {
      
      //  Support the use of classname as a reference to class
      if (attr.toLowerCase() == "classname") {
      
         //  Pass to the original setAttribute as "class"
         defaultSetAttribute.call(this, "class", value);
         
      }
      
   };
   
   //  Overwrite the default getAttribute function
   Element.prototype.getAttribute = function (attr) {
   
      //  Support the use of classname as a reference to class
      if (attr.toLowerCase() == "classname") {
      
         //  Pass to the original getAttribute as "class"
         return defaultGetAttribute.call(this, "class");
         
      }
      
   };
     
</script>
      
      
   </body>
</html>