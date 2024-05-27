using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Windows.Forms;

namespace LevelCreator
{
    [Transaction(TransactionMode.Manual)]
    public class LevelCreatorCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            try
            {
                // Show the Windows Forms dialog
                using (LevelForm levelForm = new LevelForm())
                {
                    if (levelForm.ShowDialog() != DialogResult.OK)
                    {
                        return Result.Cancelled;
                    }

                    int numberOfLevels = (int)levelForm.numericUpDownLevels.Value;
                    double levelSpacingMeters = (double)levelForm.numericUpDownSpacing.Value;
                    string prefix = levelForm.txtPrefix.Text;
                    string suffix = levelForm.txtSuffix.Text;
                    int specialStartLevel = (int)levelForm.numericUpDownSpecialStart.Value;
                    int specialEndLevel = (int)levelForm.numericUpDownSpecialEnd.Value;
                    double specialSpacingMeters = (double)levelForm.numericUpDownSpecialSpacing.Value;

                    // Convert spacing from meters to feet
                    double levelSpacingFeet = levelSpacingMeters * 3.28084;
                    double specialSpacingFeet = specialSpacingMeters * 3.28084;

                    UIDocument uiDoc = commandData.Application.ActiveUIDocument;
                    Document doc = uiDoc.Document;

                    using (Transaction trans = new Transaction(doc, "Create Levels and Floor Plans"))
                    {
                        trans.Start();

                        // Create specified number of Levels with user-defined spacing
                        double elevation = 0.0;
                        for (int i = 1; i <= numberOfLevels; i++)
                        {
                            double currentSpacing = (i >= specialStartLevel && i <= specialEndLevel) ? specialSpacingFeet : levelSpacingFeet;
                            Level level = Level.Create(doc, elevation);
                            level.Name = $"{prefix} - Level {i}{suffix}";

                            // Create a Floor Plan for each Level
                            ViewPlan floorPlan = CreateFloorPlan(doc, level);
                            if (floorPlan != null)
                            {
                                floorPlan.Name = $"{prefix} - Level {i}{suffix}";
                            }

                            elevation += currentSpacing; // Increase elevation by current spacing in feet
                        }

                        trans.Commit();
                    }

                    return Result.Succeeded;
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return Result.Failed;
            }
        }

        private ViewPlan CreateFloorPlan(Document doc, Level level)
        {
            ViewFamilyType viewFamilyType = GetViewFamilyType(doc, ViewFamily.FloorPlan);
            if (viewFamilyType != null)
            {
                return ViewPlan.Create(doc, viewFamilyType.Id, level.Id);
            }

            return null;
        }

        private ViewFamilyType GetViewFamilyType(Document doc, ViewFamily viewFamily)
        {
            FilteredElementCollector collector = new FilteredElementCollector(doc);
            collector.OfClass(typeof(ViewFamilyType));
            foreach (Element elem in collector)
            {
                ViewFamilyType viewFamilyType = elem as ViewFamilyType;
                if (viewFamilyType.ViewFamily == viewFamily)
                {
                    return viewFamilyType;
                }
            }
            return null;
        }
    }
}
