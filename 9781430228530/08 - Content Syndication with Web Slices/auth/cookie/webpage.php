<?php
require_once('functions.php');

if(login()) {

//  Create a new DateTime object and grab current values
$dateTime = new DateTime(); 
$currentTime = $dateTime->format('H:i:s A');
$currentDate = $dateTime->format('D, M jS, Y');
?>
<html>
   <head>
      <meta http-equiv="X-UA-Compatible" content="IE=edge" />
      <title>Super News Network</title>
      <link rel="stylesheet" type="text/css" href="style.css" />
   </head>
   <body>
      <h1 id="page-title">
         Welcome to Super News Network!
      </h1>
      <span id="page-teaser" style="">
         Super News Network provides news that matters most to you when 
         and where you need it. You just can't get news like this anywhere 
         else.  Other networks simply do not compare.
      </span>
      <div class="hslice" id="webslice">
         <div class="entry-title" style="display:none;">Super News Network</div>
         <div class="entry-content" id="webslice-content">         
            <h2 id="webslice-title">
               Up-to-the-Minute Content from Super News Network:
            </h2>
            <ul id="webslice-list">
               <li>Content placeholder 1</li>
               <li>Content placeholder 2</li>
               <li>Content placeholder 3</li>
            </ul>
            <div id="webslice-time">
               This content was last refreshed at 
               <? echo($currentTime); ?> on <? echo($currentDate); ?>.
            </div>
         </div>
         <div style="display:none;" class="ttl">30</div>
         <abbr class="endtime" title="2010-12-23T12:30:00-08:00" 
               style="display:none;"></abbr>
      </div>
   </body>
</html>
<?php 

}

?>