# NumberWordAnalyzerApi - Unit Test and Api Project

This is a Number Word Count Analyzer Api, It's purpose is to detect, count and collect number words (e.g."one","two","three").
The Api only caters for word numbers "One" - "Ten"

## Prerequisites:
- Visual Studio 2022
- Clone project from <li>https://github.com/LiamForbay07/NewRepo.git</li>
- Understanding of C# language
- All packages are already intstalled on project


## Projects in NumberWordAnalyzerApi.sln include:
- NumberWordAnalyzerApi (Consists of DTOs, BusinessLogic, Interfaces, Controllers, Helpers, appsettings.json)
- NumberWordAnalyzer.UnitTest (Consists of NumberWordAnalyzerTests.cs class)

## How to use api:
- Runs on localhost.
- Opens swagger api on local host, if not simply add "swagger" in to the url (e.g. "https://localhost:{portnumber}/swagger")

## How to run tests:
- Go to NumberWordAnalyzer.UnitTest > NumberWordAnalyzerTests.cs,
- Open > Test > Test Explorer on visual studio and you should be able to see the runnable tests.
- Click 'Run All Tests'.