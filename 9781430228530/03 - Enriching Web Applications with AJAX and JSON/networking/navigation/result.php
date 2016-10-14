<?
   
   //  Load the GET headers
   $name    = urldecode($_GET["name"   ]);
   $desc    = urldecode($_GET["desc"   ]);
   $uri     = urldecode($_GET["uri"    ]);
   $enc     = urldecode($_GET["enc"    ]);
   $icon    = urldecode($_GET["icon"   ]);
   $dev     = urldecode($_GET["dev"    ]);
   $contact = urldecode($_GET["contact"]);

   //  Open the template Search Provider XML file
   $data   = file_get_contents("search.xml");
   
   //  Replace placeholders with submitted data
   $data   = str_replace("##name##",     $name,           $data);
   $data   = str_replace("##desc##",     $desc,           $data);
   $data   = str_replace("##uri##",      $uri,            $data);
   $data   = str_replace("##enc##",      $enc,            $data);
   $data   = str_replace("##icon##",     $icon,           $data);
   $data   = str_replace("##dev##",      $dev,            $data);
   $data   = str_replace("##contact##",  $contact,        $data);
   $data   = str_replace("TEST",         "{searchTerms}", $data);

   //  Send XML MIME type headers
   header("Content-Type: text/xml");
   header("Content-Disposition: attachment; filename=\"".preg_replace("/[^a-zA-Z\.]/","",$name)."-searchprovider.xml\""); 
   header("Content-Transfer-Encoding: binary");
   
   //  Return the Search Provider XML for download
   echo($data);
   
?>