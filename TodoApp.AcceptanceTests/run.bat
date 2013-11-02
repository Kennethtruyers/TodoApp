nunit-console.exe /include:security /labels /out=TestResult.txt /xml=TestResult.xml bin\Debug\TodoApp.AcceptanceTests.dll

taskkill /IM iedriverserver.exe /F
taskkill /IM iexplore.exe /F

specflow.exe nunitexecutionreport TodoApp.AcceptanceTests.csproj /out:TodoAppReport.html

start TodoAppReport.html