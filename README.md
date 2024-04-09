# OCR_Tool

## Overview
This is a simple tool for OCR (Optical Character Recognition) by combinations of Tessract and .Net.

## User Guide
STEP 1. Download Tesseract with version 4.0.0 or higher via the following website.
    https://tesseract-ocr.github.io/tessdoc/Downloads.html

STEP 2. Install Tesseract under C:\Program File. Alternatively, changing the path of Tesseract as below is also available in Line 19 of Form1.cs.
     
    var engine = new TesseractEngine("InputYourPathHere", "eng");

STEP 3. Open the TessarctTest.exe

STEP 4. Drag and drop the picture into the textbox.

STEP 5. Click OCR button to run the program.
