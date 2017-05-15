using POC_TemplateMethod.Pattern;
using System.Collections.Generic;

namespace POC_TemplateMethod
{
    public class DataExport<T> where T : class
    {
        public static void LaunchAll(IEnumerable<T> rows)
        {
            var instances = GetExportInstances();
            instances.ForEach(x => x.Execute(rows));
        }

        public static List<ExportTemplate<T>> GetExportInstances()
        {
            var instances = new List<ExportTemplate<T>>();
            instances.Add(new ExcelExport<T>());
            instances.Add(new PdfExport<T>());
            // Add a new way to export.
            return instances;
        }
    }
}
