//  Create a new IE Automation object
var objIE = new ActiveXObject("InternetExplorer.Application");

//  Navigate to a URL for the main tab
objIE.Navigate2("http://www.bing.com");

//  Show the browser window
objIE.Visible = true;