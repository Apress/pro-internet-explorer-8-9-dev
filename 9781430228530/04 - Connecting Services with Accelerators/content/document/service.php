<?php

   ////
   ////  INCLUDES
   ////

   //  Include some necessary functions (truncateString, getHTTPVar, ...)
   require_once('functions.php');

   ////
   ////  CONSTANTS
   ////
   
   //  Define constants for Accelerator content 'types'
   define('TYPE_DOCUMENT',  'document');
   define('TYPE_SELECTION', 'selection');
   
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

   ////
   ////  FUNCTIONS
   ////
   
   //  Function to build a tweet (minify an url and truncate a string
   //  to 140 characters)
   function buildTweet() {

      global $type;
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

      //  Get the text to send to Twitter
      if      ($type == TYPE_DOCUMENT)  $text = $documentTitle;
      else if ($type == TYPE_SELECTION) $text = $selection;

      //  Minify the URL (e.g. TinyURL)
      $minifiedURL = minifyURL($url);
      
      //  Truncate the text + URL to 140 characters or less
      $output  = truncateString($text, 140 - strlen($minifiedURL));
      $output .= " " . $minifiedURL;

      //  Return the output (urlencoded if specified)
      return urlencode($output);

   }

   ////
   ////  SCRIPT
   ////
   
   //  Execute the accelerator
   header('Location: http://twitter.com/home?status=' . buildTweet(true));
  
?>