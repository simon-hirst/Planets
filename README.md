# Planets
Technical interview task for Dootrix

# Running
To run, you will need:
- yarn (https://legacy.yarnpkg.com/en/docs/install/), although npm should work fine too.
- ASP.NET Core 3.1

Navigate to Planets.Back\Planets\Planets and run 'dotnet run', or just run it with your IDE of choice.

Then, navigate to Planets.Front\planets and run 'yarn install' followed by 'yarn start', or 'npm install' and 'npm start'. Although the node modules are included in the repo, so yarn/npm install should not be needed. The frontend will then start on http://localhost:3000

# Usage
Every time you run the backend service, the database will be dropped and reseeded with the default data.
In order to edit planet details you will need to enter a password, this is set to "DootrixTest".
