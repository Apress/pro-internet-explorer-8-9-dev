<?php

//Source: http://php.net/manual/en/function.preg-match.php
$regex_url  = "((https?|ftp)\:\/\/)?"; // SCHEME 
$regex_url .= "([a-z0-9+!*(),;?&=\$_.-]+(\:[a-z0-9+!*(),;?&=\$_.-]+)?@)?"; // User and Pass 
$regex_url .= "([a-z0-9-.]*)\.([a-z]{2,3})"; // Host or IP 
$regex_url .= "(\:[0-9]{2,5})?"; // Port 
$regex_url .= "(\/([a-z0-9+\$_-]\.?)+)*\/?"; // Path 
$regex_url .= "(\?[a-z+&\$_.-][a-z0-9;:@&%=+\/\$_.-]*)?"; // GET Query 
$regex_url .= "(#[a-z_.-][a-z0-9+\$_.-]*)?"; // Anchor 


$regex_email  = "([a-z0-9])(([-a-z0-9._])*([a-z0-9]))*";
$regex_email .= "\@";
$regex_email .= "([a-z0-9])*(\.([a-z0-9])([-a-z0-9_-])([a-z0-9])+)*";

function findUrls($source) {
   global $regex_url;
   preg_match_all("/($regex_url)/", $source, $urls, PREG_SET_ORDER);
   return $urls;
}

function findEmails($source) {
   global $regex_email;
   preg_match_all("/($regex_email)/", $source, $urls, PREG_SET_ORDER);
   return $urls;
}

?>