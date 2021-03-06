package com.aspose.cells.cloud.examples.worksheet;

import com.aspose.cells.cloud.examples.Utils;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.StandardCopyOption;

public class MoveWorksheet {

    public static void main(String... args) throws IOException {
        String input = "Sample1.xlsx";
        String output = "Sample2.xlsx";
        Path inputFile = Utils.getPath(MoveWorksheet.class, input);
        Path outputFile = Utils.getPath(MoveWorksheet.class, output);
        String sheet = "Sheet2";
        com.aspose.cells.model.WorksheetMovingRequest move = new com.aspose.cells.model.WorksheetMovingRequest();
        move.setDestinationWorksheet("Sheet5");
        move.setPosition("after");

        Utils.getStorageSdk().PutCreate(
                input,
                null,
                Utils.STORAGE,
                inputFile.toFile()
        );

        com.aspose.cells.model.WorksheetsResponse wr
                = Utils.getCellsSdk().PostMoveWorksheet(
                        input,
                        sheet,
                        Utils.STORAGE,
                        null,
                        move
                );

        com.aspose.storage.model.ResponseMessage sr
                = Utils.getStorageSdk().GetDownload(
                        input,
                        null,
                        Utils.STORAGE
                );

        Files.copy(sr.getInputStream(), outputFile, StandardCopyOption.REPLACE_EXISTING);

    }
}
