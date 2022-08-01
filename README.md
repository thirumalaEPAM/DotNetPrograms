# # Project name : EPAM Internal Code Challenge
## Pre-Requisites for project execution
- Visual Studio 2022
- Latest Chrome Driver version 99.0.5060.134 (

## 01 - Automation Framework design Approach
###### IDE & Language
   - Visual Studio 2022 & C#
###### Automation Tool
   - Selenium WebDriver
###### Project Type
   - Abstract Factory Designpattern
###### Design Pattern
   - Singleton with POM
###### DataDriven
   - Scenario Outline
###### Reports
   - Extent Reports
###### Browsers
   - Chrome Driver
## 02 - Test Scenarios
    1. Navigate to site 'https://www.epam.com' 
    2. Wait until page is loaded 
    3. Click on Magnifier (Search) button
    4. Select from the list of 'Frequent Searches' third value (e.g. 'DevOps')
    5. Click on 'Find'
    6. If number of results in text 'XXX RESULTS FOR "YYY"' is more than 10, write to console text 'More than 10 results were found'
    7. Verify that all results contain value from step 4 (e.g. 'DevOps') in their description (in text, located under link to found article)
 
 ## 03 - Brief Description about framework Approach
 - Reports created using ExtentReports and ScreenShots captured for failed scenarios
 
 - In Project solution 
     ###### 1. ObjectRepsitoryLibrary : 
      which contains common utilities, locators (defined in page classfiles),Constants
       
       
    ###### 2. HelperLibrary : 
     which contains the methods which are specific to the respective pages (Pagehelper class)
     we can call Pagehelper methods from Teststeps methods.
       
    ###### 4. Abstract Design Pattern NUnit Framework
    
          - Need to add few points
