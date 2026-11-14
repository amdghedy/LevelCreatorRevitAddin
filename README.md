# Level Creator — Revit Add-in

Create a sequence of Revit levels and corresponding floor-plan views using configurable level counts, elevations, naming, and a special spacing range.

![Level Creator interface](https://github.com/amdghedy/LevelCreatorRevitAddin/assets/43811322/bd5afec3-963a-425f-8d23-9f72356a7c97)

## Compatibility

- **Target application:** Autodesk Revit 2022 (as configured in the current project)
- **Framework:** .NET Framework 4.8
- **Language / UI:** C# with Windows Forms
- **Project:** LevelCreator/LevelCreator/LevelCreator.csproj
- **Manifest:** LevelCreator/LevelCreator/LevelCreator.addin

The project references Revit 2022 API assemblies. Other Revit versions require compatible API references and validation; do not assume the same DLL works across versions.

## Features and options

| Option | Description |
|---|---|
| **Number of Levels** | Number of levels to create; the UI control permits values up to 900. |
| **Level Spacing (m)** | Standard vertical spacing in metres between generated level elevations. |
| **Prefix** | Text placed before the generated level label. |
| **Suffix** | Text appended after the generated level number. |
| **Special Range — Start / End** | Inclusive level-number range that uses the special spacing value. |
| **Special Spacing** | Alternative vertical spacing, in metres, for levels within the configured special range. |
| **Create Levels** | Confirms the dialog and runs the Revit transaction. |

The command converts spacing values from metres to Revit internal feet. It creates levels starting at elevation zero, names each level using the prefix/level number/suffix pattern, and attempts to create a floor-plan view for each level. Floor plans use the first available Revit floor-plan view family type.

## Quick start: create levels

1. Open a project in the supported Revit version. Work on a test model or project copy first.
2. Install the add-in using the instructions below and restart Revit.
3. Open the **Level Creator** command from the add-in ribbon.
4. Enter the number of levels and standard spacing in metres.
5. Enter a prefix and suffix for the generated names.
6. If a range needs different spacing, set its start level, end level, and special spacing.
7. Review the naming and spacing values carefully.
8. Click **Create Levels**.
9. Inspect the generated levels and floor-plan views in the Project Browser and elevations.

### Naming pattern

Generated levels and their floor plans use the pattern:

**[Prefix] - Level [number][Suffix]**

For example, with prefix **Tower A** and suffix ** - Typical**, the generated name is **Tower A - Level 1 - Typical**.

### Elevation behavior

The first level is created at elevation **0**. After creating each level, the next elevation is advanced using the spacing that applies to the current level number. The special range is inclusive. Confirm this sequence against your project datum and naming convention before creating many levels.

## Build from source

1. Install Visual Studio with .NET desktop development support and the .NET Framework 4.8 targeting pack.
2. Install Revit 2022.
3. Clone or download this repository.
4. Open LevelCreator/LevelCreator/LevelCreator.sln.
5. Confirm the project references point to the Revit 2022 API assemblies on your computer.
6. Build the solution in Visual Studio.
7. Check the build output for LevelCreator.dll and the add-in manifest.

The project contains a user-specific project settings file and may contain local path assumptions. Review those settings on a new machine rather than relying on the original developer's paths.

## Install the add-in

1. Close Revit.
2. Create the per-user folder if needed: **%APPDATA%\Autodesk\Revit\Addins\2022\**
3. Copy LevelCreator.dll into that folder (or a dedicated subfolder and adjust the manifest path accordingly).
4. Copy LevelCreator.addin into the same Revit 2022 Addins folder.
5. Open the manifest and verify its assembly path points to the installed DLL.
6. Start Revit 2022 and confirm the command appears on the ribbon.

## Troubleshooting

- **Command missing:** confirm both the DLL and manifest are in the Revit 2022 add-in location and the manifest assembly path is correct.
- **Assembly load error:** rebuild against the installed Revit 2022 API and .NET Framework 4.8.
- **Floor plans are not created:** check that the project has a usable floor-plan view family type.
- **Unexpected level elevations:** verify the spacing units are metres, the first elevation is zero, and the special range boundaries are correct.
- **Duplicate names or existing levels:** review existing project names before running. Revit may reject conflicting names and the command can fail.
- **Unexpected partial results:** the command uses one transaction for the generated levels and views; inspect the model and failure message before retrying.

## Important notes

- This command creates levels and floor-plan views; it does not automatically create structural, architectural, or MEP elements on those levels.
- It does not automatically align the first level to a selected datum: generation begins at elevation zero.
- Always test on a copy and verify the resulting levels, names, elevations, and floor plans before using it on a production project.

## License

See LICENSE.
