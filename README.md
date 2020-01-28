# Planets
Technical interview task for Dootrix

# Running
To run, you will need Azure Storage Emulator installed and running (https://go.microsoft.com/fwlink/?linkid=717179&clcid=0x409) as well as yarn (https://legacy.yarnpkg.com/en/docs/install/#windows-stable), although npm should work fine too.
The database table is created and seeded with planet data using a startup task in the ASP.NET Core project.
If running windows, run the start.bat script to run the project, alternatively, navigate to Planets.Back\Planets\Planets and run 'dotnet run', or just run it with your IDE of choice, and then navigate to Planets.Front\planets and run 'yarn install' followed by 'yarn start', or 'npm install' and 'npm start'

# Usage
In order to edit planet details, you will need to enter a password, for demonstration purposes this is set to "DootrixTest"
