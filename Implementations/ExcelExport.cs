using POC_TemplateMethod.Pattern;
using System;
using System.Collections.Generic;

namespace POC_TemplateMethod
{
    public class ExcelExport<T> : ExportTemplate<T> where T : class
    {
        public override void PrepareData(IEnumerable<T> rows)
        {
            // Load data.
            throw new NotImplementedException();
        }

        public override void GenerateExport(IEnumerable<T> rows)
        {
            // Prepare data
            throw new NotImplementedException();
        }

        public override void SaveFile(IEnumerable<T> rows)
        {
            // Generate file
            throw new NotImplementedException();
        }
    }
}
