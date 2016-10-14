//  Create placeholder variables that will be used to 
//  access the context menu wrapper and keep track of when
//  the right mouse button was clicked
var showContextMenu = false;
var mouseOverContextMenu = false;
var contextMenu = document.getElementById('contextMenuWrapper');

//  Add a callback function to the body element event handler on
//  the document
document.body.onmousedown = Body_OnMouseDown;
document.body.oncontextmenu = Body_OnContextMenu;

//  Keep track of when the mouse is on the context menu
//  wrapper and when it isn't
contextMenu.onmouseover
            = function () { mouseOverContextMenu = true; }
contextMenu.onmouseout
            = function () { mouseOverContextMenu = false; }

//  Return the currently selected text on a page
function GetSelectedText() {

   //  Create a buffer variable
   var text = "";

   //  Attempt to get selection information from various
   //  browser configurations
   if (window.getSelection) text = window.getSelection();
   if (document.selection) text = document.selection.createRange().text;
   if (document.getSelection) text = document.getSelection();
   return text;

}

//  Handles the OnMouseDown event on the body element
function Body_OnMouseDown(event) {

   //  Ensure that both the event and the event target
   //  objects are available
   if (event == null) event = window.event;
   var target = event.target != null ? event.target : event.srcElement;

   //  If the right mouse button was clicked, mark that
   //  the context menu should be shown on the context
   //  menu event
   if (event.button == 2) showContextMenu = true;
   else if (!mouseOverContextMenu) contextMenu.style.display = 'none';
}

//  Handles the OnContextMenu event on the body element
function Body_OnContextMenu(event) {

   //  Ensure that both the event and the event target
   //  objects are available
   if (event == null) event = window.event;
   var target = event.target != null ? event.target : event.srcElement;

   //  Show a custom context menu if a user triggered
   //  the right mouse button
   if (showContextMenu) {

      //  Get the current page offsets due to scrolling
      var scrollTop = document.body.scrollTop ? document.body.scrollTop : document.documentElement.scrollTop;
      var scrollLeft = document.body.scrollLeft ? document.body.scrollLeft : document.documentElement.scrollLeft;

      //  Hide the div while changes are made to it
      contextMenu.style.display = 'none';

      //  Move the div to where the mouse is located
      contextMenu.style.left = event.clientX + scrollLeft + 'px';
      contextMenu.style.top = event.clientY + scrollTop + 'px';

      //  Display the context menu
      contextMenu.style.display = 'block';

      //  Don't show the context menu again for this event
      showContextMenu = false;

      //  Return false so the browser context menu will 
      //  not show up
      return false;

   }

}