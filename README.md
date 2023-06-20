# IOptionMonitorsDemo

Generally, when the application is applying configurations, it should set reloadOnChange parameter to true on AddJsonFile call.

This change is not required for .NET core web applications. This is because they use CreateDefaultBuilder method to create the IWebHostBuilder, which takes care of setting the reloadOnChange parameter to true.

But let’s say if you want to use custom logic for creating IWebHostBuilder, then you should remember to use appropriate overload of AddJsonFile. OR if you want to use appsettings.json file with console application, then also you will have to appropriately load the configurations. 

https://thecodeblogger.com/2021/04/22/ioptionsmonitor-demo-reload-configurations-in-net-applications/