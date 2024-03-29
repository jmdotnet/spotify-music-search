# spotify-music-search
A demo music search app built with .Net Core 3.0, Angular 8 and Spotify Web API

Demo: https://jmdotnetmusicsearchdemo.azurewebsites.net/

# Getting started

Install the following dependencies on your machine and sign up for a Spotify Web API account.  

## Visual Studio 2019 (Community, Professional or Enterprise) ([link](https://visualstudio.microsoft.com/vs/))

Select ASP.NET & web development workloads during the install steps.  

Note: VS2019 includes .Net Core 3.0 https://dotnet.microsoft.com/download/dotnet-core/3.0

## Node.js ([link](https://nodejs.org/en/))

Once Node is installed open a command prompt and go to root of MusicSearch.UI and run the following command to install node dependencies:

    npm install
    
## Angular CLI ([link](https://cli.angular.io))

npm install -g @angular/cli
    
        
## Spotify's Web API ([link](https://developer.spotify.com/web-api/))

To use the Web API, start by creating a Spotify user account (Premium or Free). To do that, simply sign up at www.spotify.com.

When you have a user account, go to the Dashboard page at the Spotify Developer website and, if necessary, log in. Accept the latest Developer Terms of Service to complete your account set up.

Obtain Client Id and Client secret from Spotify Dashboard

## Add Spotify Client Id and Client Secret to API App settings

Update appsettings.json

{
 "spotify-client-id": "",
  "spotify-client-secret": ""
}

# To Build / Run Locally

1. Launch Visual Studio and F5 Debug API App

2. Open a command prompt and go to root of UI app and run the following:

   ng serve





