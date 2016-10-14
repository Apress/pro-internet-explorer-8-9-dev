<?php

   ////
   ////  CONSTANTS
   ////

   //  Constants for spacing and padding
   define('SZ_SPACE_LEN'   , 1);
   define('SZ_SPACE_CHAR'  , ' ');
   define('SZ_PAD_LEN'     , 3);
   define('SZ_PAD_CHAR'    , '.');
   
   //  Constants for HTTP variable methods
   define('METHOD_GET'     , 'get');
   define('METHOD_POST'    , 'post');
   
   ////
   ////  FUNCTIONS
   ////

   //  Truncate string to a specified limit length and include
   //  an elipsis if the string was truncated
   //  Source: Chirp Internet @ www.chirp.com.au
   function truncateString($string, $limit)
   {

      //  Define the break character (space) and reduce the limit
      //  to include padding and elipsis
      $break = " ";
      $limit = $limit - (SZ_SPACE_LEN + SZ_PAD_LEN);

      // Return with no change if string is shorter than $limit
      if(strlen($string) <= $limit) return $string;

      //  If string is larger than the limit, break at first available
      //  space that leaves room for padding and an elipsis
      $string = substr($string, 0, $limit);
      if(false !== ($breakpoint = strrpos($string, $break)))
         $string = substr($string, 0, $breakpoint);

      //  Return the string, 
      $string  = trim($string);
      $string .= str_repeat(SZ_PAD_CHAR, SZ_PAD_LEN);
      $string .= str_repeat(SZ_SPACE_CHAR, SZ_SPACE_LEN);
      
      //  Return the truncated string
      return $string;
      
   }

   //  Minifies an URL using TinyURL.  Can also simulate a
   //  minified URL instead of pinging a web sevice
   //  Source: http://davidwalsh.name/create-tiny-url-php
   function minifyURL($url, $preview=false)  
   {  
   
      //  If running in preview mode, simulate a minified URL
      if($preview) {
      
         //  Simulate a minified URL
         return "http://tinyurl.com/" . preg_replace('/([ ])/e', 'chr(rand(97,122))', '      ');
                      
      //  Otherwise, get a real minified URL
      } else {
      
         //  Call the TinyURL web service to get a minified url
         $curlHandle = curl_init();   
         curl_setopt($curlHandle, CURLOPT_URL, 'http://tinyurl.com/api-create.php?url='.$url);  
         curl_setopt($curlHandle, CURLOPT_RETURNTRANSFER, 1);  
         curl_setopt($curlHandle, CURLOPT_CONNECTTIMEOUT, 5);  
         $data = curl_exec($curlHandle);  
         curl_close($curlHandle);  
         
         //  Return an array with the results
         return $data;  
      
      }
      
   }

   //  Get an HTTP variable passed by a specified method
   function getHTTPVar($key="", $method=METHOD_POST, $default="") {
   
      //  If the method is POST, return POST variable
      if($method == METHOD_POST)
         return (isset($_POST[$key])) ? $_POST[$key] : "";
         
      //  If the method is GET, reutrn GET variable
      else if($method == METHOD_GET)   
         return (isset($_GET[$key])) ? $_GET[$key] : "";
         
      //  If the method isn't POST or GET, return the default
      else return $default;
      
   }

?>