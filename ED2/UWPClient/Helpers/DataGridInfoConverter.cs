using Abstractions;
using Telerik.UI.Xaml.Controls.Grid;

namespace WT.ED2.UWP.Helpers
{
    public class DataGridInfoConverter : ISelectedManagementUnit
    {
        public int RecordId(object item)
        {
            DataGridCellInfo dgDataGridCellInfo = (DataGridCellInfo) item;

            //{DataObjects.ManagementUnitsDTO}

            var value = dgDataGridCellInfo.Value;
            DataObjects.ManagementUnitsDTO managementUnitsDto = (DataObjects.ManagementUnitsDTO)
            dgDataGridCellInfo.Item;


            return managementUnitsDto.ManagementUnitId;
        }
    }
}
