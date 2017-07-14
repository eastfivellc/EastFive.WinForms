using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EastFive.WinForms.Extensions
{
    public static class DataGridViewExtensions
    {
        public static void HideColumn(this DataGridView grid, string columnName)
        {
            grid.Columns[columnName].Visible = false;
        }

        public static int GetColumnIndexByName(this DataGridView grid, string columnName)
        {
            var column = grid.Columns[columnName];
            if (null == column)
                return -1;

            return column.Index;
        }

        public static Guid GetCurrentRowCellValueGuid(this DataGridView grid, string columnName)
        {
            var currentRow = grid.CurrentRow;
            if (null == currentRow)
                return default(Guid);

            var guidString = currentRow.Cells[columnName].Value.ToString();
            if (string.IsNullOrEmpty(guidString))
                return default(Guid);

            return Guid.Parse(guidString);
        }

        public static string GetCurrentRowCellValueString(this DataGridView grid, string columnName)
        {
            var currentRow = grid.CurrentRow;
            if (null == currentRow)
                return string.Empty;

            return currentRow.Cells[columnName].Value.ToString();
        }
    }
}
