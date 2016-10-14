<html>
   <head>
      <title>Test</title>
   </head>
   <body>


<script type="text/javascript">

   //  Create a function that does nothing
   function disableWrite() { }
   
   //  Set the the disableWrite function as document.write
   HTMLDocument.prototype.write = disableWrite;

</script>

<script type="text/javascript">

   //  Write the current value of data to the document
   function writeToDocument() {
      document.write(document.getElementById("data").value);
   }
   
</script>

<form action="javascript:writeToDocument()">
   <p>
   Data to write:<br />
   <input type="text" id="data" name="data" />
   </p>
   <input type="submit" id="submit" name="submit" value="Write text" />
</form>
      
   </body>
   

   
</html>


