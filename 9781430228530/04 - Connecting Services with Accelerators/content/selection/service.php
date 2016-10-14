<?php


   ////
   ////  INCLUDES
   ////

   //  Include some necessary functions (truncateString, getHTTPVar, ...)
   require_once('functions.php');
   
   ////
   ////  GLOBAL VARIABLES
   ////

   //  Set the HTTP Method used for passe variables
   $method             = METHOD_POST;

   //  Get values from HTTP Variables   
   $mode               = getHTTPVar("mode",          $method);
   $type               = getHTTPVar("type",          $method);
   $documentUrl        = getHTTPVar("documentUrl",   $method);
   $selection          = getHTTPVar("selection",     $method);

   ////
   ////  FUNCTIONS
   ////
   
   //  Function to build a tweet (minify an url and truncate a string
   //  to 140 characters)
   function buildTweet() {

      global $documentUrl;
      global $selection;

      //  Minify the URL (e.g. TinyURL)
      $minifiedURL = minifyURL($documentUrl);
      
      //  Truncate the text + URL to 140 characters or less
      $output  = truncateString($selection, 140 - strlen($minifiedURL));
      $output .= " " . $minifiedURL;

      //  Return the output (urlencoded if specified)
      return  urlencode($output);

   }

   ////
   ////  SCRIPT
   ////
   
   //  Execute the accelerator
   header('Location: http://twitter.com/home?status=' . buildTweet(true));

?>