# Planets
Technical interview task for Dootrix.

# Running
To run, you will need:
- yarn, although npm should work fine too.
- ASP.NET Core 3.1

Navigate to Planets.Back\Planets\Planets and run 'dotnet run', or just run it with your IDE of choice.

Then, navigate to Planets.Front\planets and run 'yarn install' followed by 'yarn start', or 'npm install' and 'npm start'. Although the node modules are included in the repo, so yarn/npm install should not be needed. The frontend will then start on http://localhost:3000

# Usage
If you want to revert the database to the default seed data, delete app.db and then run 'dotnet ef database update' within the project folder.

To edit planets, you need to provide a password for security demonstration, this is set to "DootrixTest".
