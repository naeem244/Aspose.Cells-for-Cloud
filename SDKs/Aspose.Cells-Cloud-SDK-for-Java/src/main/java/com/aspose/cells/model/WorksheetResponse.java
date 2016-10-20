package com.aspose.cells.model;

import com.aspose.cells.model.Worksheet;
public class WorksheetResponse {
  private Worksheet Worksheet = null;
  private String Code = null;
  private String Status = null;
  /**
	 * getWorksheet
	 * Gets Worksheet
	 * @return Worksheet
	 */
  public Worksheet getWorksheet() {
    return Worksheet;
  }

	/**
	 * setWorksheet
	 * Sets Worksheet
	 * @param Worksheet Worksheet
	 */
  public void setWorksheet(Worksheet Worksheet) {
    this.Worksheet = Worksheet;
  }

  /**
	 * getCode
	 * Gets String
	 * @return Code
	 */
  public String getCode() {
    return Code;
  }

	/**
	 * setCode
	 * Sets String
	 * @param Code String
	 */
  public void setCode(String Code) {
    this.Code = Code;
  }

  /**
	 * getStatus
	 * Gets String
	 * @return Status
	 */
  public String getStatus() {
    return Status;
  }

	/**
	 * setStatus
	 * Sets String
	 * @param Status String
	 */
  public void setStatus(String Status) {
    this.Status = Status;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class WorksheetResponse {\n");
    sb.append("  Worksheet: ").append(Worksheet).append("\n");
    sb.append("  Code: ").append(Code).append("\n");
    sb.append("  Status: ").append(Status).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}
