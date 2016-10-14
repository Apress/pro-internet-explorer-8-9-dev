<?

   function inWebSlice() {
   
      $http_a_im = isset($_SERVER['HTTP_A_IM'])?$_SERVER['HTTP_A_IM']:"";
      $http_user_agent = isset($_SERVER['HTTP_USER_AGENT'])?$_SERVER['HTTP_USER_AGENT']:"";
      $http_accept = isset($_SERVER['HTTP_ACCEPT'])?$_SERVER['HTTP_ACCEPT']:"";
      
      $slice_a_im = "feed";
      $slice_user_agent = "Windows-RSS-Platform";
      $slice_accept = "*/*";
      
      if($http_a_im == $slice_a_im &&
         substr($http_user_agent, 0, strlen($slice_user_agent)) == $slice_user_agent &&
         $http_accept == $slice_accept)
         return array(true,$http_a_im, $http_user_agent, $http_accept);
      else return array(false,$http_a_im, $http_user_agent, $http_accept);

   }
   
?>
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
            <h2><? $ws = inWebSlice(); if($ws[0]===true) { echo("Running in WebSlice"); var_dump($ws); } else { echo("Running in Browser Window"); var_dump($ws); }; ?></h2>
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