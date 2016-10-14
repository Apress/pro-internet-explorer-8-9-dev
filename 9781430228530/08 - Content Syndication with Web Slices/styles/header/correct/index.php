<?
//  Create a new DateTime object and grab current values
$dateTime = new DateTime(); 
$currentTime = $dateTime->format('H:i:s A');
$currentDate = $dateTime->format('D, M jS, Y');
?>
<html>
   <head>
      <meta http-equiv="X-UA-Compatible" content="IE=edge" />
      <title>Super News Network</title>
      <style type="text/css">
         body {
            font: normal 1.0em Arial, Helvetica, sans-serif;
         }
         #page-title {
            font: bold 1.75em Georgia, Times, serif;
         }
         #page-teaser {
            font-style: italic;
         }
         #webslice-title {
            font: bold 1.25em Georgia, Times, serif;
         }
         #webslice-content {
            font: normal 0.8em Arial, Helvetica, sans-serif;
         }
         #webslice-list { }
         #webslice-time {
            color: #555; font: italic 0.75em Georgia, Times, serif;
         }
      </style>
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