﻿'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Imaging. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Aspose.Cloud
Imports System
Namespace Aspose.Cells.Cloud.Examples.Hyperlinks
	Friend Class UpdateHyperlinkWorksheet
		Shared Sub Main()
			Dim dataDir As String = Common.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

			Dim input As String = "sample1.xlsx"
			Dim output As String = "output.xlsx"
			Common.StorageService.File.UploadFile(dataDir & input, input, storage:= Common.STORAGE)

			Dim sheetName As String = "Sheet1"

			Dim cellsHyperlinkResponse As CellsHyperlinkResponse = Common.CellsService.Hypelinks.GetWorksheetHyperlinkByIndex(input, sheetName, 0, Common.FOLDER, storage:= Common.STORAGE)

			cellsHyperlinkResponse.Hyperlink.TextToDisplay = "Aspose"
			Dim apiResponse As CellsHyperlinkResponse = Common.CellsService.Hypelinks.UpdateWorksheetHyperlinkByIndex(input, sheetName, 0, cellsHyperlinkResponse.Hyperlink, Common.FOLDER, storage:= Common.STORAGE)

			Common.StorageService.File.DownloadFile(input, dataDir & output, storage:= Common.STORAGE)
		End Sub
	End Class
End Namespace

