# Basic Tye With Redis OM

Very basic dotnet tye app that uses Redis OM. It connects to the redis connection provider and pings redis inside of the program.cs file of `backend` (doing redis stuff inside of the startup phase of the app is not ideal but serves the purpose of this demonstrations)

To run this app use the following:

```
tye run --logs console
```

for more information about tye see the [Tye](https://github.com/dotnet/tye) repo