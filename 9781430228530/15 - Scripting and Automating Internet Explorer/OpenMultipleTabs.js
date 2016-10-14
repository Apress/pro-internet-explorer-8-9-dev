//  Define the background flag const for Navigate2
var openInBackgroundTabFlag = 0x1000;

//  Create a new IE Automation object
var objIE = new ActiveXObject("InternetExplorer.Application");

//  Navigate to a URL for the main tab
objIE.Navigate2("http://www.bing.com");

//  Load other tabs in the background
objIE.Navigate2("http://www.yahoo.com", openInBackgroundTabFlag);
objIE.Navigate2("http://www.google.com", openInBackgroundTabFlag);

//  Show the browser window
objIE.Visible = true;