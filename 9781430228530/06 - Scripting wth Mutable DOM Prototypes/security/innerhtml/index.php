<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
   <head>
      <meta http-equiv="X-UA-Compatible" content="IE=8" />
      <title>Test</title>
   </head>
   <body>

<script type="text/javascript">

   //  Get the innerText property on Element
   var defInnerText = Element.prototype.innerText;
   
   //  Define a new property for innerText
   Object.defineProperty(Element.prototype, "innerText",
   {
      //  Map the getter to the original innerText property getter and
      //  return sanitized content using toStaticHTML
      get: function () { return toStaticHTML(defInnerText.get.call(this, content)); }
      
      //  Map the setter to the original innerText property setter and
      //  call it after sanitizing the input content using toStaticHTML
      set: function (content) {defInnerText.set.call(this, toStaticHTML(content)); }
      
   }
   
</script>

      
   </body>
</html>