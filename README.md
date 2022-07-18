## Word Prediction Project Description
                                                  
--> WordPrediction project is the client for fetching data from **Word predictions web service. (Open WordPrediction solution for opening the complete project)**

--> CustomDictionary is the web API project. This gets the data from the Sqlite3 Database and displays it as a service and also added the code for the client here as a .cs file WordPrediction.cs)
This API has the service Url for fetching data from Sqlite3 database and another service Url for fetching data from the webservice (https://services.lingapps.dk/misc/getPredictions).

--> Frontend is the project which uses the web API and displays the word predictions in two lists. HTML/JS code is in: ***Views/Home/Index.cshtml***.
Here I have hardcoded the Url for fetching the result.

--> _Note_: The Web API is not hosted, I tried to do it, but I don’t have enough facility to do. But if you run the web API first (without closing it), and run the Frontend it will show the results.

--> Also, I haven’t created a separate web service for fetching data from database, as this is a part of web API (web API is also a service) and also creation of a webservice (.asmx) is not supported in some latest versions of visual studio.

In case if you have any problem running the project or any other difficulties please let me know.
