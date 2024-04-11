# OCR_Tool

## Overview
This is a simple tool for OCR (Optical Character Recognition) by combinations of Tessract and .Net.

## User Guide
<ol>
<li>Download [Tesseract](https://tesseract-ocr.github.io/tessdoc/Downloads.html) with version 4.0.0 or another higher version.</li>

<li>Install Tesseract under C:\Program File. Alternatively, changing the path of Tesseract engine is also available as below in Line 19 of Form1.cs.</li>
     
    var engine = new TesseractEngine("PutYourPathHere", "eng");

<li>Open the TessarctTest.exe</li>

<li>Drag and drop the picture into the textbox.</li>

<li>Click OCR button to run the program.</li>
</ol>
