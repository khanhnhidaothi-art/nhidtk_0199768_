using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;


namespace APPBASIC
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class Class1 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            MessageBox.Show(" DAO THI KHANH NHI ");
            for (int i = 0; i <= 6; i++)
            {
                MessageBox.Show(i.ToString());
            }
            MessageBox.Show("Check");
            return Result.Succeeded;
        }
    }
}