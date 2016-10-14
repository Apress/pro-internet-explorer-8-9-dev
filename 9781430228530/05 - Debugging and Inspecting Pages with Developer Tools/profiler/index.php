<?php

   require_once($_SERVER['DOCUMENT_ROOT'] . "/includes/template.php");
   
   $template = new template(true, array(
      VAR_TITLE       =>  "JavaScript Measurement and Optimization",
      VAR_MENUTITLE   =>  "",
      VAR_FILE        =>  __FILE__,
      VAR_BODY_ARRTS  => Array('onload' => "clearResults(); toggleCallsOnly(); toggleDebugging();")
   ));
   
   $template->start();
   
?>
<style>
   /* Elements */
   table     { background-color: #eeeeee; margin: 10px 10px 10px 0; border: 1px solid #cccccc; }
   tr        { background-color: #eeeeee; padding: 5px; }
   td        { text-align: center; background-color: #eeeeee; padding: 3px; }
   button    { margin: 7px; }
   /* Classes */
   .Idle     { background-color: red; color: white; }
   .Running  { background-color: yellow; color: white; }
   .Complete { background-color: green; color: white; }
   .noInput  { background-color: #cccccc; }
</style>
<script id="jsUtilities" src="scripts/utilities.js" type="text/javascript"></script>
<script type="text/javascript">

   //  Define function states
   var idle       = "Idle";
   var progress   = "Running";
   var complete   = "Complete";

   //  Add a switch to turn off everything but
   //  function calls
   var callsOnly  = false;
   var debugging  = true;

   //  Initialize function call delay values
   var bDelay     = 3000;
   var cDelay     = 5000;
   var dDelay     = 2000;
   var eDelay     = 1000;

   //  Initialize internal function loop values
   var cLoop      = 6000;
   var dLoop      = 50000;
   var eLoop      = 10000;

   //  Generic worker function "a"
   //  This function calls other functions.
   //  This function does not simulate work.
   //  Caller: button (id=aCaller) onclick event
   function a() {

      //  Write to console
      console.debug("a() - Entering function");

      //  Make sure values are applied and clear the
      //  last result set
      clearResults();
      applyValues();

      //  Mark this function as in progress
      setTextAndClass("a", progress);

      //  Run function "b" 3 seconds from now
      setTimeout("b()", bDelay);
      setTextAndClass("b", progress);

      //  Run function "b" 1 second from now
      setTimeout("e()", eDelay);
      setTextAndClass("e", progress);

      //  Mark this function as complete
      setTextAndClass("a", complete);

      //  Write to console
      console.debug("a() - Leaving function");

   }

   //  Generic worker function "d"
   //  This function calls other functions.
   //  This function does not simulate work.
   //  Caller: a()
   function b() {

      //  Write to console
      console.debug("b() - Entering function");

      //  Run function "c" 5 seconds from now
      setTimeout("c()", cDelay);
      setTextAndClass("c", progress);

      //  Run function "d" 2 seconds from now
      setTimeout("d();", dDelay);
      setTextAndClass("d", progress);

      //  Mark this function as complete
      setTextAndClass("b", complete);

      //  Write to console
      console.debug("b() - Leaving function");

   }

   //  Generic worker function "c"
   //  This function has a loop that simulates work
   //  Caller: b()
   function c() {

      //  Write to console
      console.debug("c() - Entering function");

      //  Loop from 0 to 6000 to simulate work
      if(!callsOnly) {

         //  Write to console
         console.debug("c() - Entering work loop simulation");

         //  Simulate some heavy lifting
         for(var i = 0; i < cLoop; i++)
            doWork();

      }

      //  Mark this function as complete
      setTextAndClass("c", complete);

      //  Write to console
      console.debug("c() - Leaving function");

   }

   //  Generic worker function "d"
   //  This function has a loop that simulates work
   //  Caller: b()
   function d() {

      //  Write to console
      console.debug("d() - Entering function");

      //  Loop from 0 to 50000 to simulate work
      if(!callsOnly) {

         //  Write to console
         console.debug("d() - Entering work loop simulation");

         //  Simulate some heavy lifting
         for(var i = 0; i < dLoop; i++)
            doWork();

      }

      //  Mark this function as complete
      setTextAndClass("d", complete);

      //  Write to console
      console.debug("d() - Leaving function");

   }

   //  Generic worker function "e"
   //  This function has a loop that simulates work
   //  Caller: a()
   function e() {

      //  Write to console
      console.debug("e() - Entering function");

      //  Loop from 0 to 10000 to simulate work
      if(!callsOnly) {

         //  Write to console
         console.debug("e() - Entering work loop simulation");

         //  Simulate some heavy lifting
         for(var i = 0; i < eLoop; i++)
            doWork();

      }

      //  Mark this function as complete
      setTextAndClass("e", complete);

      //  Write to console
      console.debug("e() - Leaving function");

   }

   function toggleCallsOnly() {

      //  Flip the Calls Only bit and change button display
      callsOnly = !callsOnly;
      document.getElementById("coButton").innerHTML = "Turn \"Calls Only\" <b>" + ((callsOnly) ? "Off" : "On") + "</b>";

      //  Write to console
      console.debug("Calls Only turned " + (callsOnly) ? "Off" : "On");

   }

   function toggleDebugging() {

      //  Flip the debugging bit and change button display
      debugging = !debugging;
      document.getElementById("dbgButton").innerHTML = "Turn Debugging <b>" + ((debugging) ? "Off" : "On") + "</b>";

      //  Write to console
      console.log("Debug: Debugging turned " + ((debugging) ? "On" : "Off"));

   }

   function clearResults() {

      //  Write to console
      console.debug("Clearing results display");

      //  Clear <span> tags for each element
      setTextAndClass("a", "Idle");
      setTextAndClass("b", "Idle");
      setTextAndClass("c", "Idle");
      setTextAndClass("d", "Idle");
      setTextAndClass("e", "Idle");
      
      //  Apply default values
      applyValues();

   }

   function applyValues() {

      //  Write to console
      console.debug("Applying values to <input> boxes");

      //  Set function call delay values
      bDelay         = parseInt(document.getElementById("bDelay").value);
      cDelay         = parseInt(document.getElementById("cDelay").value);
      dDelay         = parseInt(document.getElementById("dDelay").value);
      eDelay         = parseInt(document.getElementById("eDelay").value);

      //  Set internal function loop values
      cLoop          = parseInt(document.getElementById("cLoop").value);
      dLoop          = parseInt(document.getElementById("dLoop").value);
      eLoop          = parseInt(document.getElementById("eLoop").value);

   }

   //  A function whose sole purpose is to waste time.
   function doWork() {

      //  Do some really random, wasteful work
      var containerDiv = document.getElementById('container');
      var newDiv = document.createElement("div");
      newDiv.setAttribute('id', "tempDiv" + String(parseInt(Math.random() * 1000000)));
      newDiv.innerHTML = "&nbsp;&nbsp;&nbsp;";
      containerDiv.appendChild(newDiv);
      containerDiv.removeChild(newDiv);

   }

</script>
<table border="0" cellpadding="" cellspacing="0">
   <tr>
      <th>&nbsp;</th>
      <th valign="center"><b>a(...)</b></th>
      <th valign="center"><b>b(...)</b></th>
      <th valign="center"><b>c(...)</b></th>
      <th valign="center"><b>d(...)</b></th>
      <th valign="center"><b>e(...)</b></th>
   </tr>
   <tr>
      <td valign="center"><b>Delay</b></td>
      <td valign="center"><input type="text" id="aDelay" value="" onchange="applyValues();" class="noInput" disabled></td>
      <td valign="center"><input type="text" id="bDelay" value="3000" onchange="applyValues();"></td>
      <td valign="center"><input type="text" id="cDelay" value="5000" onchange="applyValues();"></td>
      <td valign="center"><input type="text" id="dDelay" value="2000" onchange="applyValues();"></td>
      <td valign="center"><input type="text" id="eDelay" value="1000" onchange="applyValues();"></td>
   </tr>
   <tr>
      <td valign="center"><b>Loop Max</b></td>
      <td valign="center"><input type="text" id="aLoop" value="" onchange="applyValues();" class="noInput"  disabled></td>
      <td valign="center"><input type="text" id="bLoop" value="" onchange="applyValues();" class="noInput" disabled></td>
      <td valign="center"><input type="text" id="cLoop" value="6000"   onchange="applyValues();"></td>
      <td valign="center"><input type="text" id="dLoop" value="50000" onchange="applyValues();"></td>
      <td valign="center"><input type="text" id="eLoop" value="10000" onchange="applyValues();"></td>
   </tr>
   <tr>
      <td valign="center" colspan="6" style="text-align: right;">
         <button id="aCaller" onclick="a();"><b>Run</b> Function a(...)</button>
         <button id="coButton" onclick="toggleCallsOnly();">Turn "Calls Only" Off</button>
         <button id="dbgButton" onclick="toggleDebugging();">Turn Debugging Off</button>
         <button id="ccButton" onclick="console.clear();">Clear Console</button>
      </td>
   </tr>
</table>
<div>
   <h3>Function a(...): <span id="aText"></span></h3>
   <h3>Function b(...): <span id="bText"></span></h3>
   <h3>Function c(...): <span id="cText"></span></h3>
   <h3>Function d(...): <span id="dText"></span></h3>
   <h3>Function e(...): <span id="eText"></span></h3>
</div>
<div id="container">
   <!-- Used to waste time by creating child elements -->
</div>
<?php 
   $template->end();
?>