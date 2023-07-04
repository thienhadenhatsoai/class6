using Autodesk.Revit.DB;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using System.Data;

namespace ClassLibrary6
{
    [TransactionAttribute(TransactionMode.Manual)]
    class Command_duclo : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;

            //Tìm farmily

            try
            {
                Reference r = uidoc.Selection.PickObject(Autodesk.Revit.UI.Selection.ObjectType.Element);
                ElementId elementId = r.ElementId;
                Element element = doc.GetElement(elementId);
                if (element != null)
                { 

                }
                return Result.Succeeded;
            }
            catch (Exception ex)           
             {
                message = ex.Message;
                return Result.Failed;
            }

            return "aasdasas";
            sadasasdsa


        }

    }
}
