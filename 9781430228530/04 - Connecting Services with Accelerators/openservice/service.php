<?php

   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   require_once("includes/regex.functions.php");
   
   $template = new template(true, array(
      VAR_TITLE       =>  "Accelerator Inspection Tool - Output",
      VAR_MENUTITLE   =>  "",
      VAR_FILE        =>  __FILE__
      ));
   
   $template->start();
   
   $type               = getUriValue("type", "", METHOD_POST);
   $documentUrlText    = getUriValue("documentUrlText", "", METHOD_POST);
   $documentUrlHTML    = getUriValue("documentUrlHTML", "", METHOD_POST);
   $documentTitleText  = getUriValue("documentTitleText", "", METHOD_POST);
   $documentTitleHTML  = getUriValue("documentTitleHTML", "", METHOD_POST);
   $documentDomainText = getUriValue("documentDomainText", "", METHOD_POST);
   $documentDomainHTML = getUriValue("documentDomainHTML", "", METHOD_POST);
   $selectionText      = getUriValue("selectionText", "", METHOD_POST);
   $selectionHTML      = getUriValue("selectionHTML", "", METHOD_POST);
   $linkText           = getUriValue("linkText", "", METHOD_POST);
   $linkHTML           = getUriValue("linkHTML", "", METHOD_POST);
   $linkTextText       = getUriValue("linkTextText", "", METHOD_POST);
   $linkTextHTML       = getUriValue("linkTextHTML", "", METHOD_POST);
   $linkRelText        = getUriValue("linkRelText", "", METHOD_POST);
   $linkRelHTML        = getUriValue("linkRelHTML", "", METHOD_POST);
   $linkTypeText       = getUriValue("linkTypeText", "", METHOD_POST);
   $linkTypeHTML       = getUriValue("linkTypeHTML", "", METHOD_POST);
   $linkDomainText     = getUriValue("linkDomainText", "", METHOD_POST);
   $linkDomainHTML     = getUriValue("linkDomainHTML", "", METHOD_POST);
   $linkHostText       = getUriValue("linkHostText", "", METHOD_POST);
   $linkHostHTML       = getUriValue("linkHostHTML", "", METHOD_POST);

?>
      <link rel="stylesheet" type="text/css" href="styles/table.css">
      <h3>Available Variables</h3>
      <table>
         <thead>
            <tr>
               <th>Variable</th>
               <th>Value (text)</th>
               <th>Value (html)</th>
            </tr>
         </thead>
         <tbody>
            <? if($documentUrlText != "")  { ?>
            <tr>
               <td>documentUrl</td>
               <td><? echo($documentUrlText); ?></td>
               <td>
               <? if($documentUrlHTML != "") { ?>
               <pre class="brush: html jscript">
                  <? echo(htmlspecialchars($documentUrlHTML)); ?>
               </pre>
               <? } else echo("&nbsp;"); ?>
               </td>
            </tr>
            <? } ?>
            <? if($documentTitleText != "")  { ?>
            <tr>
               <td>documentTitle</td>
               <td><? echo($documentTitleText); ?></td>
               <td>
               <? if($documentTitleHTML != "") { ?>
                  <pre class="brush: html jscript">
                     <? echo(htmlspecialchars($documentTitleHTML)); ?>
                  </pre>
               <? } else echo("&nbsp;"); ?>
               </td>
            </tr>
            <? } ?>
            <? if($documentDomainText != "")  { ?>
            <tr>
               <td>documentDomain</td>
               <td><? echo($documentDomainText); ?></td>
               <td>
               <? if($documentDomainHTML != "") { ?>
                  <pre class="brush: html jscript">
                     <? echo(htmlspecialchars($documentDomainHTML)); ?>
                  </pre>
               <? } else echo("&nbsp;"); ?>
               </td>
            </tr>
            <? } ?>
            <? if($selectionText != "")  { ?>
            <tr>
               <td>selection</td>
               <td><? echo($selectionText); ?></td>
               <td>
               <? if($selectionHTML != "") { ?>
                  <pre class="brush: html jscript">
                     <? echo(htmlspecialchars($selectionHTML)); ?>
                  </pre>
               <? } else echo("&nbsp;"); ?>
               </td>
            </tr>
            <? } ?>
            <? if($linkText != "")  { ?>
            <tr>
               <td>link</td>
               <td><? echo($linkText); ?></td>
               <td>
               <? if($linkHTML != "") { ?>
                  <pre class="brush: html jscript">
                     <? echo(htmlspecialchars($linkHTML)); ?>
                  </pre>
               <? } else echo("&nbsp;"); ?>
               </td>
            </tr>
            <? } ?>
            <? if($linkTextText != "")  { ?>
            <tr>
               <td>linkText</td>
               <td><? echo($linkTextText); ?></td>
               <td>
               <? if($linkTextHTML != "") { ?>
                  <pre class="brush: html jscript">
                     <? echo(htmlspecialchars($linkTextHTML)); ?>
                  </pre>
               <? } else echo("&nbsp;"); ?>
               </td>
            </tr>
            <? } ?>
            <? if($linkRelText != "")  { ?>
            <tr>
               <td>linkRel</td>
               <td><? echo($linkRelText); ?></td>
               <td>
               <? if($linkRelHTML != "") { ?>
                  <pre class="brush: html jscript">
                     <? echo(htmlspecialchars($linkRelHTML)); ?>
                  </pre>
               <? } else echo("&nbsp;"); ?>
               </td>
            </tr>
            <? } ?>
            <? if($linkTypeText != "")  { ?>
            <tr>
               <td>linkType</td>
               <td><? echo($linkTypeText); ?></td>
               <td>
               <? if($linkTypeHTML != "") { ?>
                  <pre class="brush: html jscript">
                     <? echo(htmlspecialchars($linkTypeHTML)); ?>
                  </pre>
               <? } else echo("&nbsp;"); ?>
               </td>
            </tr>
            <? } ?>
            <? if($linkDomainText != "")  { ?>
            <tr>
               <td>linkDomain</td>
               <td><? echo($linkDomainText); ?></td>
               <td>
               <? if($linkDomainHTML != "") { ?>
                  <pre class="brush: html jscript">
                     <? echo(htmlspecialchars($linkDomainHTML)); ?>
                  </pre>
               <? } else echo("&nbsp;"); ?>
               </td>
            </tr>
            <? } ?>
            <? if($linkHostText != "")  { ?>
            <tr>
               <td>linkHost</td>
               <td><? echo($linkHostText); ?></td>
               <td>
               <? if($linkHostHTML != "") { ?>
                  <pre class="brush: html jscript">
                     <? echo(htmlspecialchars($linkHostHTML)); ?>
                  </pre>
               <? } else echo("&nbsp;"); ?>
               </td>
            </tr>
            <? } ?>
         </tbody>
      </table>
      <h3>Content Overview</h3>
      <h3>URLs</h3>
      <ul>
      <? foreach(findUrls($selectionHTML) as $url) echo("         <li>".$url[0]."</li>"); ?>
      </ul>
      <h3>Email Addresses</h3>
      <ul>
         <? foreach(findEmails($selectionHTML) as $email) echo("         <li>".$email[0]."</li>"); ?>
      </ul>
<?php

   $template->end();

?>