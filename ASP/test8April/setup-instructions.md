**API SETUP INSTRUCTIONS**
___

Create folder, use Terminal to CD into that folder.
Type
```
dotnet new webapi -o project_name --no-https
```

Install NewtonSoft.Json as below. Once installed you need to add a *using Newtonsoft.Json;* statement at the top of all Controller files.
```
dotnet add package Newtonsoft.Json --version 12.0.1
```

**MODELS**

Inside VS Code create a Models folder and inside this you can create .cs files for all classes you need to create. All Models .cs files need a namespace the same as the Controllers files but with a .Models extension at the end (e.g. *namespace.myapi.Models*)

**CONTROLLERS**

Controllers should have using statements for the namespace.Models and NewtonSoft.Json. Under [HttpGet] update the code to deserialize the Json string, returning a List<> of the object type that you created in the Models files.

When everything is done, stop the server (ctrl-c) and restart by doing 
```
dotnet run
```

**POSTBOX**

On Postbox do a GET request using url http://localhost:5000/api/'controller-name'
