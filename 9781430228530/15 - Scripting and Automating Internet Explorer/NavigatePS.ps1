#  Grab a new IE object instance
$objIE = new-object -comobject "InternetExplorer.Application"

#  Navigate to an URL
$objIE.navigate("http://www.bing.com")

#  Set the browser window as visible
$objIE.visible = $true