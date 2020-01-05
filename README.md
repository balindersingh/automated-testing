# UI testing using selenium in c#
----------------
It has a test where it opens https://trailhead.salesforce.com/en/home website and search for login button and click it and then make sure next page has a button with text 'Salesforce'
We can run the test using following command (tested on Windows) assuming your current terminal is this folder's parent directory
```
dotnet vstest "RegressionDemo\\bin\\Debug\\RegressionDemo.dll" /Tests:Dosearch
```
