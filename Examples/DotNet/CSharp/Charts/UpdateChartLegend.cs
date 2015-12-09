﻿//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Imaging. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////

using Aspose.Cloud;
using System;
namespace Aspose.Cells.Cloud.Examples.Charts
{
    class UpdateChartLegend
    {
        static void Main()
        {
            string dataDir = Common.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            string input = "Sample1.xlsx";
            string output = "output.xlsx";
            string sheetName = "Sheet1";

            Common.StorageService.File.UploadFile(dataDir + input, input, storage: Common.STORAGE);

            CellsChartLegendResponse cellsChartLegendResponse = Common.CellsService.Charts.GetChartLegend(input, sheetName, 0, Common.FOLDER);
            
            Common.CellsService.Charts.UpdateChartLegend(input, sheetName, 0, Common.FOLDER, cellsChartLegendResponse.Legend, storage: Common.STORAGE);

            Common.CellsService.Charts.ShowLegendInChart(input, sheetName, 0, Common.FOLDER, storage: Common.STORAGE);

            Common.StorageService.File.DownloadFile(input, dataDir + output, storage: Common.STORAGE);

        }
    }
}

