param([string]$version="")
$ChromeVersion=""
$LocalChromeVersionInfo = (Get-Item "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe").VersionInfo
$LocalChromeVersion=$LocalChromeVersionInfo.ProductVersion
Write-Host "Local version:$LocalChromeVersion"
if($version -ne ""){
    Write-Host "Using chrome version from command:$version"
    $ChromeVersion=$version
}else{
    $ChromeVersion=$LocalChromeVersion
}
Write-Host "Using chrome version:$ChromeVersion"
$currentDirectoryPath=Get-Location
$configFilePath="$currentDirectoryPath\RegressionDemo\packages.config"
$doc = New-Object System.Xml.XmlDocument
$doc.Load("$configFilePath")

$ChromeDriverVersionElem = $doc.SelectSingleNode("//package[@id = 'Selenium.WebDriver.ChromeDriver']")
$ChromeDriverVersionElem.version = "$ChromeVersion"

$doc.Save("$configFilePath")