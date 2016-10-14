<?php

   ////
   ////  INCLUDES
   ////

   //  Include some necessary functions (truncateString, getHTTPVar, ...)
   require_once('functions.php');

   ////
   ////  CONSTANTS
   ////
   
   //  Define constants for Accelerator 'modes'
   define('MODE_PREVIEW',   'preview');
   define('MODE_EXECUTE',   'execute');
   
   //  Define constants for Accelerator content 'types'
   define('TYPE_DOCUMENT',  'document');
   define('TYPE_SELECTION', 'selection');
   define('TYPE_LINK',      'link');
   
   ////
   ////  GLOBAL VARIABLES
   ////

   //  Set the HTTP Method used for passe variables
   $method             = METHOD_POST;

   //  Get values from HTTP Variables   
   $mode               = getHTTPVar("mode",           $method);
   $type               = getHTTPVar("type",           $method);
   $documentDomain     = getHTTPVar("documentDomain", $method);
   $linkDomain         = getHTTPVar("linkDomain",     $method);

   ////
   ////  FUNCTIONS
   ////

   function getComponentName($component) {
      global $components;
      return $components[$component][0];
   }

   function getReputationValue($component) {
      global $result;
      $value = $result[(string)$component][0];
      return ($value == "") ? "0" : $value;
   }
   function getConfidenceValue($component) {
      global $result;
      $value = $result[(string)$component][1];
      return ($value == "") ? "0" : $value;
   }

   function getReputationIcon($component) {
      $reputation = getReputationValue($component);
      $confidence = getConfidenceValue($component);
      if($confidence < 6) return "no_rep_available.png";
      else {
         if($reputation >= 80) return "trusted.png";
         else if($reputation >= 40) return "caution.png";
         else if($reputation >= 0) return "not_safe.png";
         else return "no_rep_available.png";
      }
   }

   function getConfidenceIcon($component) {
      $confidence = getConfidenceValue($component);
      if($confidence >= 45) return "confidence-5.png";
      else if($confidence >= 34) return "confidence-4.png";
      else if($confidence >= 23) return "confidence-3.png";
      else if($confidence >= 12) return "confidence-2.png";
      else if($confidence >= 6) return "confidence-1.png";
      else if($confidence >= 0) return "confidence-0.png";
      else return "confidence-0.png";
   }

   function getMarkerPos($component) {
      $reputation = getReputationValue($component);
      if($reputation <= 4) return 0;
      if($reputation >= 91) return 91;
      else return ($reputation - 5);
   }
   
   function buildWOTQuery($domain, $api=false) {
      if($api) return "http://api.mywot.com/0.4/public_link_json?hosts=$domain/";
      else return "http://www.mywot.com/en/scorecard/$domain";
   }

   ////
   ////  SCRIPT
   ////
   
   $domain = "";
   if($type == TYPE_DOCUMENT) $domain = $documentDomain;
   if($type == TYPE_SELECTION) $domain = $documentDomain;
   if($type == TYPE_DOCUMENT) $domain = $linkDomain;
   else exit();   
   
   //  Execute the accelerator if the mode is set to MODE_EXECUTE
   if($mode == MODE_EXECUTE) {
      header('Location: ' . buildWOTQuery($domain));
      exit();
   }
   
   //  Otherwise, display the preview!

   
   $components = array(0 => array('Trust', 
                                  'Do you trust this website? Is it safe to use? Does it deliver what it promises?'
                                  ), 
                       1 => array('Safety',
                                  'Is the site safe for buying and selling, or for business transactions in general?'
                                  ), 
                       2 => array('Privacy', 
                                  'Can you trust the site owner, safely supply personal information, and download files?'
                                  ),
                       4 => array('Modesty', 
                                  'Does the site contain age-inappropriate material?'
                                  )
                       ); 


   $json = file_get_contents(buildWOTQuery($domain, true));

   $result = json_decode($json, true);
   $keys = array_keys($result); 
   $result = $result[$keys[0]];
   
?>
<html>
   <head>
      <meta http-equiv="X-UA-Compatible" content="IE=edge">
      <meta http-equiv="Pragma" content="no-cache">
      <title>WOT URL Reputation Service</title>
		<link type="text/css" rel="stylesheet" href="styles/preview.css">
   </head>
   <body topmargin="0" leftmargin="0">
      <div id="logo"><img src="images/logo.png" width="100px" height="38px"></div>
      <table border="0" cellpadding="0" cellspacing="0" align="center">
         <thead>
            <tr>
               <td width="71px" colspan="2" align="center">Tenet</td>
               <td width="171px" colspan="3" align="center">Reputation</td>
            </tr>
         </thead>
         <tbody>
            <? foreach($components as $k => $v) { ?>
            <tr>
               <td width="16px"><img src="images/<? echo(getReputationIcon($k)); ?>"></td>
               <td width="55px"><? echo(getComponentName($k)); ?></td>
               <td width="100px" class="testimony"><img src="images/marker.png" style="margin-left: <? echo(getMarkerPos($k)); ?>px;"></td>
               <td width="20px"><? echo(getReputationValue($k)); ?>%</td>
               <td width="51px"><img src="images/<? echo(getConfidenceIcon($k)); ?>"></td>
            </tr>
            <? } ?>
         </tbody>
      </table>
   </body>
</html>