using System.Collections.Generic;

namespace POC_TemplateMethod.Pattern
{
    public abstract class ExportTemplate<T> where T : class
    {
        public void Execute(IEnumerable<T> rows)
        {
            PrepareData(rows);
            GenerateExport(rows);
            SaveFile(rows);
        }

        public abstract void PrepareData(IEnumerable<T> rows);
        public abstract void GenerateExport(IEnumerable<T> rows);
        public abstract void SaveFile(IEnumerable<T> rows);
    }
}
