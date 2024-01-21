using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.DB.Architecture;
using System.Xml;

namespace HvhieuLabRevit
{
    [TransactionAttribute(TransactionMode.Manual)]
    public class lab1 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {

            UIDocument uIDocument = commandData.Application.ActiveUIDocument;
            Reference reference = uIDocument.Selection.PickObject(ObjectType.Element);

            try
            {
                if (reference != null)
                {
                    TaskDialog.Show("UV point", "UV point có giá trị là:" + reference.GlobalPoint.ToString());
                    return Result.Succeeded;
                }

            }
            catch (Exception ex)
            {
                message = ex.Message;
                return Result.Failed;
            }


            TaskDialog.Show("Title", "Xin chào Nhân !");

            return Result.Succeeded;
        }
    }
}


