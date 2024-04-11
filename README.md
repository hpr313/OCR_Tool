# OCR_Tool

## Overview
This is a simple tool for OCR (Optical Character Recognition) by combinations of Tessract and .Net.

## User Guide
<ul>
<li>STEP 1. Download [Tesseract](https://tesseract-ocr.github.io/tessdoc/Downloads.html) with version 4.0.0 or another higher version.</li>

<li>STEP 2. Install Tesseract under C:\Program File. Alternatively, changing the path of Tesseract engine is also available as below in Line 19 of Form1.cs.</li>
     
    var engine = new TesseractEngine("PutYourPathHere", "eng");

<li>STEP 3. Open the TessarctTest.exe</li>

<li>STEP 4. Drag and drop the picture into the textbox.</li>

<li>STEP 5. Click OCR button to run the program.</li>
</ul>
