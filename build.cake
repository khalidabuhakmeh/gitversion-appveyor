#tool "nuget:?package=GitVersion.CommandLine&version=4.0.0-beta0014"

var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
    var version = 
    GitVersion(new GitVersionSettings {
        UpdateAssemblyInfo = false,
        OutputType = GitVersionOutput.BuildServer,
    });

    Information(version);
});

RunTarget(target);