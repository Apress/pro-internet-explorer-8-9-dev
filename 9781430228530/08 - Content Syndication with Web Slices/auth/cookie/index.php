
<?

   require_once('functions.php');
   
   if(!login()) {
   
      if(!inWebSlice()) {
   
?>

<html>
   <head>
      <title>Login Page</title>
   </head>
   <body>
      <form method='post' action='index.php'>
         Username: <input type='text' name='user' size='15' />
         Password: <input type='password' name='pass' size='15' />
         <input type='submit' name='submit' value='submit'><br />
      </form>
   </body>
</html>

<?
      } else {
?>

<html>
   <head>
      <meta http-equiv="X-UA-Compatible" content="IE=edge" />
      <title>Super News Network</title>

   </head>
   <body>
      <div class="hslice" id="webslice">
         <div class="entry-title" style="display:none;">Super News Network</div>
         <div class="entry-content" id="webslice-content">         
            <h2 id="webslice-title">
               Please Login:
            </h2>
            <div id="testid"></div>
            <script type="text/javascript">
               document.getElementById('testid').innerText="foo";
            </script>
            <form method='post' action='index.php'>
               Username: <input type='text' name='user' size='15' />
               Password: <input type='password' name='pass' size='15' />
               <input type='submit' name='submit' value='submit' onclick="javascript:test()"><br />
            </form>
         </div>
         <div style="display:none;" class="ttl">30</div>
         <abbr class="endtime" title="2010-12-23T12:30:00-08:00" 
               style="display:none;"></abbr>
      </div>
   </body>
</html>

<?
      }
      

   } else {

      require_once('webpage.php');

   }
   
?>



