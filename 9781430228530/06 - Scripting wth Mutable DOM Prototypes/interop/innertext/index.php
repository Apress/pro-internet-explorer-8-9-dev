<html>
   <head>
      <title>Test</title>
   </head>
   <body>

<script type="text/javascript">

   //  Check if the textContent property is available on the first node.  If not,
   //  proceed with mapping this property to innerText
   if(!document.firstChild.textContent) {
   
      //  Get the innerText property on the current object
      var defInnerText = Object.getOwnPropertyDescriptor(Element.prototype, "innerText");
      
      //  Define a new property for all elements called textContent
      Object.defineProperty(Element.prototype, "textContent",
      {
         //  Map the getter to the original innerText property getter
         get: function () { return defInnerText.get.call(this, content); }
         
         //  Map the setter to the original innerText property setter
         set: function (content) {defInnerText.set.call(this, content); }
      }
   }
   
</script>

<div id="testInnerText"></div>
<div id="testTextContent"></div>

<script type="text/javascript">

   //  Access the two test divs
   var divInnerText   = document.getElementById("testInnerText");
   var divTextContent = document.getElementById("testTextContent");
   
   //  Attempt to write to the innerText property of divInnerText
   divInnerText.innerText = "This element supports innerText.";
   
   //  Attempt to write to the textContent property of divTextContent
   divTextContent.textContent = "This element supports textContent.";

</script>

      
   </body>
</html>