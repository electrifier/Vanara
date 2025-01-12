﻿![Vanara](https://raw.githubusercontent.com/dahall/Vanara/master/docs/icons/VanaraHeading.png)
### **Vanara.PInvoke.DWrite NuGet Package**
[![Version](https://img.shields.io/nuget/v/Vanara.PInvoke.DWrite?label=NuGet&style=flat-square)](https://github.com/dahall/Vanara/releases)
[![Build status](https://img.shields.io/appveyor/build/dahall/vanara?label=AppVeyor%20build&style=flat-square)](https://ci.appveyor.com/project/dahall/vanara)

PInvoke API (methods, structures and constants) imported from Windows DWrite.dll.

### **What is Vanara?**

[Vanara](https://github.com/dahall/Vanara) is a community project that contains various .NET assemblies which have P/Invoke functions, interfaces, enums and structures from Windows libraries. Each assembly is associated with one or a few tightly related libraries.

### **Issues?**

First check if it's already fixed by trying the [AppVeyor build](https://ci.appveyor.com/nuget/vanara-prerelease).
If you're still running into problems, file an [issue](https://github.com/dahall/Vanara/issues).

### **Included in Vanara.PInvoke.DWrite**

Functions | Enumerations | Structures | Interfaces
--- | --- | --- | ---
DWriteCreateFactory                                                                                                | DWRITE_BREAK_CONDITION DWRITE_FACTORY_TYPE DWRITE_FLOW_DIRECTION DWRITE_FONT_FACE_TYPE DWRITE_FONT_FEATURE_TAG DWRITE_FONT_FILE_TYPE DWRITE_FONT_SIMULATIONS DWRITE_FONT_STRETCH DWRITE_FONT_STYLE DWRITE_FONT_WEIGHT DWRITE_INFORMATIONAL_STRING_ID DWRITE_LINE_SPACING_METHOD DWRITE_NUMBER_SUBSTITUTION_METHOD DWRITE_PARAGRAPH_ALIGNMENT DWRITE_PIXEL_GEOMETRY DWRITE_READING_DIRECTION DWRITE_RENDERING_MODE DWRITE_SCRIPT_SHAPES DWRITE_TEXT_ALIGNMENT DWRITE_TEXTURE_TYPE DWRITE_TRIMMING_GRANULARITY DWRITE_WORD_WRAPPING DWRITE_BASELINE DWRITE_GLYPH_ORIENTATION_ANGLE DWRITE_OUTLINE_THRESHOLD DWRITE_PANOSE_ARM_STYLE DWRITE_PANOSE_ASPECT DWRITE_PANOSE_ASPECT_RATIO DWRITE_PANOSE_CHARACTER_RANGES DWRITE_PANOSE_CONTRAST DWRITE_PANOSE_DECORATIVE_CLASS DWRITE_PANOSE_DECORATIVE_TOPOLOGY DWRITE_PANOSE_FAMILY DWRITE_PANOSE_FILL DWRITE_PANOSE_FINIALS DWRITE_PANOSE_LETTERFORM DWRITE_PANOSE_LINING DWRITE_PANOSE_MIDLINE DWRITE_PANOSE_PROPORTION DWRITE_PANOSE_SCRIPT_FORM DWRITE_PANOSE_SCRIPT_TOPOLOGY DWRITE_PANOSE_SERIF_STYLE DWRITE_PANOSE_SPACING DWRITE_PANOSE_STROKE_VARIATION DWRITE_PANOSE_SYMBOL_ASPECT_RATIO DWRITE_PANOSE_SYMBOL_KIND DWRITE_PANOSE_TOOL_KIND DWRITE_PANOSE_WEIGHT DWRITE_PANOSE_XASCENT DWRITE_PANOSE_XHEIGHT DWRITE_TEXT_ANTIALIAS_MODE DWRITE_VERTICAL_GLYPH_ORIENTATION DWRITE_GRID_FIT_MODE DWRITE_OPTICAL_ALIGNMENT DWRITE_AUTOMATIC_FONT_AXES DWRITE_COLOR_COMPOSITE_MODE DWRITE_CONTAINER_TYPE DWRITE_FONT_AXIS_ATTRIBUTES DWRITE_FONT_FAMILY_MODEL DWRITE_FONT_LINE_GAP_USAGE DWRITE_FONT_PROPERTY_ID DWRITE_FONT_SOURCE_TYPE DWRITE_LOCALITY DWRITE_PAINT_ATTRIBUTES DWRITE_PAINT_FEATURE_LEVEL DWRITE_PAINT_TYPE DWRITE_RENDERING_MODE1                              | DWRITE_CLUSTER_METRICS DWRITE_FONT_FEATURE DWRITE_FONT_METRICS DWRITE_GLYPH_METRICS DWRITE_GLYPH_OFFSET DWRITE_GLYPH_RUN DWRITE_GLYPH_RUN_DESCRIPTION DWRITE_HIT_TEST_METRICS DWRITE_INLINE_OBJECT_METRICS DWRITE_LINE_BREAKPOINT DWRITE_LINE_METRICS DWRITE_MATRIX DWRITE_OVERHANG_METRICS DWRITE_SCRIPT_ANALYSIS DWRITE_SHAPING_GLYPH_PROPERTIES DWRITE_SHAPING_TEXT_PROPERTIES DWRITE_STRIKETHROUGH DWRITE_TEXT_METRICS DWRITE_TEXT_RANGE DWRITE_TRIMMING DWRITE_TYPOGRAPHIC_FEATURES DWRITE_UNDERLINE DWRITE_CARET_METRICS DWRITE_FONT_METRICS1 DWRITE_JUSTIFICATION_OPPORTUNITY DWRITE_PANOSE DWRITE_SCRIPT_PROPERTIES DWRITE_UNICODE_RANGE DWRITE_COLOR_GLYPH_RUN DWRITE_TEXT_METRICS1 DWRITE_BITMAP_DATA_BGRA32 DWRITE_COLOR_GLYPH_RUN1 DWRITE_FILE_FRAGMENT DWRITE_FONT_AXIS_RANGE DWRITE_FONT_AXIS_TAG DWRITE_FONT_AXIS_VALUE DWRITE_FONT_PROPERTY DWRITE_GLYPH_IMAGE_DATA DWRITE_LINE_METRICS1 DWRITE_LINE_SPACING DWRITE_PAINT_COLOR DWRITE_PAINT_ELEMENT TEXT SCRIPT DECORATIVE SYMBOL <values>e__FixedBuffer PAINT_UNION PAINT_LAYERS PAINT_SOLID_GLYPH PAINT_LINEAR_GRADIENT PAINT_RADIAL_GRADIENT PAINT_SWEEP_GRADIENT PAINT_GLYPH PAINT_COLOR_GLYPH PAINT_COMPOSITE                                         | IDWriteBitmapRenderTarget IDWriteFactory IDWriteFont IDWriteFontCollection IDWriteFontCollectionLoader IDWriteFontFace IDWriteFontFamily IDWriteFontFile IDWriteFontFileEnumerator IDWriteFontFileLoader IDWriteFontFileStream IDWriteFontList IDWriteGdiInterop IDWriteGlyphRunAnalysis IDWriteInlineObject IDWriteLocalFontFileLoader IDWriteLocalizedStrings IDWriteNumberSubstitution IDWritePixelSnapping IDWriteRenderingParams IDWriteTextAnalysisSink IDWriteTextAnalysisSource IDWriteTextAnalyzer IDWriteTextFormat IDWriteTextLayout IDWriteTextRenderer IDWriteTypography IDWriteBitmapRenderTarget1 IDWriteFactory1 IDWriteFont1 IDWriteFontFace1 IDWriteRenderingParams1 IDWriteTextAnalysisSink1 IDWriteTextAnalysisSource1 IDWriteTextAnalyzer1 IDWriteTextLayout1 IDWriteColorGlyphRunEnumerator IDWriteFactory2 IDWriteFont2 IDWriteFontFace2 IDWriteFontFallback IDWriteFontFallbackBuilder IDWriteRenderingParams2 IDWriteTextAnalyzer2 IDWriteTextFormat1 IDWriteTextLayout2 IDWriteTextRenderer1 IDWriteAsyncResult IDWriteBitmapRenderTarget2 IDWriteBitmapRenderTarget3 IDWriteColorGlyphRunEnumerator1 IDWriteFactory3 IDWriteFactory4 IDWriteFactory5 IDWriteFactory6 IDWriteFactory7 IDWriteFactory8 IDWriteFont3 IDWriteFontCollection1 IDWriteFontCollection2 IDWriteFontCollection3 IDWriteFontDownloadListener IDWriteFontDownloadQueue IDWriteFontFace3 IDWriteFontFace4 IDWriteFontFace5 IDWriteFontFace6 IDWriteFontFace7 IDWriteFontFaceReference IDWriteFontFaceReference1 IDWriteFontFallback1 IDWriteFontFamily1 IDWriteFontFamily2 IDWriteFontList1 IDWriteFontList2 IDWriteFontResource IDWriteFontSet IDWriteFontSet1 IDWriteFontSet2 IDWriteFontSet3 IDWriteFontSet4 IDWriteFontSetBuilder IDWriteFontSetBuilder1 IDWriteFontSetBuilder2 IDWriteGdiInterop1 IDWriteInMemoryFontFileLoader IDWritePaintReader IDWriteRemoteFontFileLoader IDWriteRemoteFontFileStream IDWriteRenderingParams3 IDWriteStringList IDWriteTextFormat2 IDWriteTextFormat3 IDWriteTextLayout3 IDWriteTextLayout4 