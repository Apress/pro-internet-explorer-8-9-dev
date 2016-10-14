<?
//  Create a new DateTime object and grab current values
$dateTme = new DateTime(); 
$currentTime = $date->format('H:i:s A');
$currentDate = $date->format('D, M jS, Y');
?>
<html>
   <head>
      <meta http-equiv="X-UA-Compatible" content="IE=edge" />
      <title>Super News Network</title>
   </head>
   <body>
      <h1>Welcome to Super News Network!</h1>
      Super News Network provides news that matters most to you when 
      and where you need it. You just can't get news like this anywhere 
      else.  Other networks simply do not compare.
      <div class="hslice" id="my-webslice">
         <div class="entry-title" style="display:none;">Super News Network</div>
         <div class="entry-content" id="news-updates">
            <h2>Up-to-the-Minute Content from Super News Network:</h2>
            <ul>
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