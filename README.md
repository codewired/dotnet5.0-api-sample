#  Sample Web API for .Net 5.0 API

Here is a minimal but working sample for intermediate API developers who want to use the newest ASP.Net technology that is making waves in the full-stack world today.

This sample was curled from [Microsoft ASP.Net 5.0.x Docs](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio)


## Few words on technology used

This code was developed using Visual Studio Enterprise 2019 and
Dot Net Core 5.0. You can refer to the link above for the visual guide on scafolding a .Net Core 5.0 API


## Setting Up Your Envrionment

1. Clone this repository into your favorite folder and open with your favorite .Net Editor
2. You need to have ASP.Net core 5.0 SDK installed
3. The data access layer uses Entity Framework 5.0's In Memory Datastore which is already added as a Nuget Package
4. You will need to have Postman (https://www.postman.com) Installed.
5. Inside your launchSettings.json file change the LuanchURL's to 'api/Claims'
6. Build and launch the app from your favorite editor. You will see an empty array [ ] in your browser.
7. You will need to send a post request to the Url in your browser Via PostMan assuming you are using port 5001 (https://localhost:5001/api/Claims) in the format below, then reload the URL on a browser to see your new claims:
    ```
     {
        "ClaimDate":"2020-10-06T00:00:00.000",
        "ClaimAmount": 1112.56,
        "Member":{
            "id": 1123,
            "enrollmentDate": "2020-09-01T00:00:00",
            "firstName": "John",
            "lastname": "Doe"
        }
     }
    ```
8. You can post as many time as you want to but make sure the Member.id field in your post request is unique during every session. 
9. Shutting down or restarting the application server removes all data from EF's In-Memory DB.
10. You can also try out other HTTP Methods (PUT, DELETE) for 'https://localhost:5001/api/Members' and 'https://localhost:5001/api/Claims' routes, check out the corresponding Controller Classes inside the Controllers folder to see implementation.
11. Feel free to clone and modify.