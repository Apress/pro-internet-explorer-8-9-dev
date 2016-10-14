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
   $mode               = getHTTPVar("mode",          $method);
   $type               = getHTTPVar("type",          $method);
   $documentUrl        = getHTTPVar("documentUrl",   $method);
   $documentTitle      = getHTTPVar("documentTitle", $method);
   $selection          = getHTTPVar("selection",     $method);
   $link               = getHTTPVar("link",          $method);
   $linkText           = getHTTPVar("linkText",      $method);

   ////
   ////  FUNCTIONS
   ////
   
   //  Function to build a tweet (minify an url and truncate a string
   //  to 140 characters)
   function buildTweet() {

      global $mode, $type;
      global $documentUrl, $documentTitle;
      global $selection;
      global $link, $linkText;

      //  Create new variables for the URL, text, and final output
      $url      = "";
      $text     = "";
      $output   = "";
      
      //  Get the URL to send to Twitter
      if      ($type == TYPE_DOCUMENT)  $url = $documentUrl;
      else if ($type == TYPE_SELECTION) $url = $documentUrl;
      else if ($type == TYPE_LINK)      $url = $link;

      //  Get the text to send to Twitter
      if      ($type == TYPE_DOCUMENT)  $text = $documentTitle;
      else if ($type == TYPE_SELECTION) $text = $selection;
      else if ($type == TYPE_LINK)      $text = $linkText;

      //  Minify the URL (e.g. TinyURL)
      $minifiedURL = minifyURL($url, ($mode == MODE_PREVIEW));
      
      //  Truncate the text + URL to 140 characters or less
      $output  = truncateString($text, 140 - strlen($minifiedURL));
      $output .= " " . $minifiedURL;

      //  Return the output (urlencoded if specified)
      return  ($mode == MODE_PREVIEW) ? $output : urlencode($output);

   }

   ////
   ////  SCRIPT
   ////
   
   //  Execute the accelerator if the mode is set to MODE_EXECUTE
   if($mode == MODE_EXECUTE) {
      header('Location: http://twitter.com/home?status=' . buildTweet(true));
      exit();
   }
   
   //  Otherwise, display the preview!
   
?>

<html>
   <head>
      <meta http-equiv="X-UA-Compatible" content="IE=edge">
      <meta http-equiv="Pragma" content="no-cache">
      <title>Tweet This! Preview</title>
		<link type="text/css" rel="stylesheet" href="styles/preview.css">
   </head>
   <body>
      <div id="container">
      <div id="container">
         <div id="logo">
            <img src="images/logo.png">
         </div>
         <div id="preview"><img id="shadow" src="images/shadow.png"></div>
         <div id="content"><? echo(buildTweet()); ?></div>  
      </div>
   </body>
</html>