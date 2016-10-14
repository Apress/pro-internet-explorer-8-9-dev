<?php

   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   
   $template = new template(true, array(
      VAR_TITLE       =>  "Inspecting Layout and Styles",
      VAR_MENUTITLE   =>  "",
      VAR_FILE        =>  __FILE__
   ));
   
   $template->start();
   
?>    
<link rel="stylesheet" href="styles/reset-fonts-grids.css" type="text/css">
<link rel="stylesheet" href="styles/main.css" type="text/css">
<div id="doc" class="document yui-t1">
   <div id="hd" class="header-container">
      <div class="header">
         <h1>
            The Joy of Fonts - A Blog
         </h1>
      </div>
   </div>
   <div id="bd">
      <div id="yui-main">
         <div class="yui-b">
            <div class="content yui-g">
               <div class="entry-title">
                  The Tragedy of Comic Sans
                  <div class="entry-date">
                     November 20th, 2009
                  </div>
               </div>
               <div class="entry-content" style="width: auto;">
                  Oh, Comic Sans!  I do not like you.  You thought you were so popular.  Yes, Mom's a big fan of your curves, and the secretary at my old school likes the way you present yourself on signage. But you are evil, and I want the world to know that fact.
                  <div class="entry-content-diagram" width="90%">
                     <img class="entry-image" src="images/comicsans.png" alt="Comic Sans saves the day">
                  </div>
                  I saw this picture on the internet.  It lies.  No, you do not save the day.  You ruin my day.
               </div>
            </div>
         </div>
      </div>
      <div class="navigation yui-b">
         <h3>Archived Entries</h3>
         <ul>
            <li><a href="#">The Tragedy of Comic Sans</a></li>
            <li><a href="#">Just Another First Post</a></li>
         </ul>
         <h3>Font Blogs I Read</h3>
         <ul>
            <li><a href="#">California Serif'n</a></li>
            <li><a href="#">Sans Restraint</a></li>
            <li><a href="#">Hiram Glyphics</a></li>
            <li><a href="#">Dithering Heights</a></li>
            <li><a href="#">Subpixel Underground</a></li>
         </ul>
      </div>
   </div>
   <div id="ft" class="footer">
      &copy; 2010 Random Font Guy - A big fan of fonts.
   </div>
</div>
<?php
   $template->end();
?>