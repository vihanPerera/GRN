using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using System.Data.Common;
using PdfDocument = QuestPDF.Fluent.Document;

QuestPDF.Settings.License = LicenseType.Community;

var fileName = "Goods-reveived-note.pdf";

PdfDocument.Create(container =>
{
    container.Page(page =>
    {
        page.Size(PageSizes.A4.Portrait());
        page.Margin(1, Unit.Centimetre);
        page.PageColor(Colors.White);
        page.DefaultTextStyle(x => x.FontSize(10));

        page.Content()
            .Element(PageBorder)
            .PaddingVertical(1, Unit.Centimetre)
            .Column(x =>
            {
                x.Spacing(10);

                x.Item().Row(row =>
                {
                    row.RelativeItem().PaddingLeft(10).Column(columnLeft =>
                    {
                        columnLeft.Item().Text("EXPOLANKA FREIGHT (PVT) LIMITED")
                            .Bold()
                            .FontSize(10);

                        columnLeft.Item().Text("No 390, Avissawella Road")
                            .FontSize(9);

                        columnLeft.Item().Text("Wellampitiya 10600")
                            .FontSize(9);

                        columnLeft.Item().Text("Phone - +94 11479 1000")
                            .FontSize(9);

                        columnLeft.Item().Text("E - LKA-Info@efl.global | W - www.efl.global")
                            .FontSize(9);
                    });

                    row.ConstantItem(100).PaddingLeft(45).Height(50).Image("EFL.png");
                });

                x.Item().AlignCenter().Text("GOODS RECEIVED NOTE – B00134268").Underline().FontColor("#333333").FontSize(12).ExtraBold();
                

                x.Item().Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.ConstantColumn(25);
                        columns.ConstantColumn(240);
                        columns.ConstantColumn(269);
                    });


                    table.Cell().Element(CellStyleWithoutBorders).Text("").AlignRight();
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("Job Number").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("B00134268").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("1").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("CONSIGNEE").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("HELA CLOTHING (PVT) LTD").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("2").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("VESSEL & DATE").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("EVER URANUS 161E").FontSize(9).Bold()); ;

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("3").FontSize(8).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("CONTAINER COUNT, TYPE & QUANTITY").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("1 *20GP (375PKG) OF FABRIC").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("4").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("CONTAINER NO").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("TTNU1462594").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("5").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("SEAL NO").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text("");

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("6").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("EFL SEAL NUMBER").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text("");

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("7").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("BILL OF LADING NO").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("MLMUNCMB2314829").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("8").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("VEHICLE NO").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text("");

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("9").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("OVERALL REMARKS").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text("");

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("10").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("ENTRY NO").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("1").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("11").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("LOCATION 1").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text("");

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("12").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("LOCATION 2").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text("");

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("13").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("INVOICE NUMBER").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text("");
                });

                x.Item().Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.ConstantColumn(25);
                        columns.ConstantColumn(120);
                        columns.ConstantColumn(18);
                        columns.ConstantColumn(110);
                        columns.ConstantColumn(20);
                        columns.ConstantColumn(110);
                        columns.ConstantColumn(18);
                        columns.ConstantColumn(112);
                    });

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(8)); 
                    table.Cell().Element(HeaderStyleWithBorderLeft).Text(text => text.Span("").FontSize(8));
                    table.Cell().Element(HeaderStyleWithCustomBorders).Text(text => text.Span("").FontSize(8));
                    table.Cell().ColumnSpan(5).Element(HeaderStyleWithBorderRight).PaddingLeft(45).Text(text => 
                    {
                        text.Span("FOR EXPOLANKA USE ONLY)").FontSize(9).Bold();
                    });

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorderLeft).Text(text => text.Span("START DATE & TIME").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span(":-").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("DETENTION HOUR").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span(":-").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorderRight).Text(text => text.Span("").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorderLeft).Text(text => text.Span("ZONE IN DATE & TIME").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span(":-").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("CHARGABLE HOUR").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span(":-").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorderRight).Text(text => text.Span("").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorderLeft).Text(text => text.Span("ZONE OUT DATE & TIME").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span(":-").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("DETENTION PER HOUR").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span(":-").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorderRight).Text(text => text.Span("").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithLeftCustomBorders).Text(text => text.Span("FINISH DATE & TIME").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithCustomBorders).Text(text => text.Span(":-").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithCustomBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithCustomBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithCustomBorders).Text(text => text.Span("DETENTION CHARGE").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithCustomBorders).Text(text => text.Span(":-").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithRighttCustomBorders).Text(text => text.Span("").FontSize(9).Bold());


                });

                x.Item().Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.ConstantColumn(25);
                        columns.ConstantColumn(70);
                        columns.ConstantColumn(70);
                        columns.ConstantColumn(120);
                        columns.ConstantColumn(110);
                        columns.ConstantColumn(138);
                    });

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9));
                    table.Cell().ColumnSpan(4).Element(HeaderStyleWithBorderLeft).Text(text =>
                    {
                        text.Span("CONDITIONS OF THE GOODS & OVER ALL REMARKS)").FontSize(10).Bold();
                    });
                    table.Cell().Element(HeaderStyleWithBorderRight).Text(text => text.Span("").FontSize(9));

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(7).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("").FontSize(7).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("Dammage").FontSize(7).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("Open & Customs Examination").FontSize(7).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(7).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("").FontSize(7).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("Shortage").FontSize(7).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(7).Bold());
                    table.Cell().Element(CellStyleWithBorderRight).Text(text => text.Span("").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(7).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("").FontSize(7).Bold());
                    table.Cell().Element(CellStyleWithCustomBorders).Text(text => text.Span("Broken & Loose").FontSize(7).Bold());
                    table.Cell().Element(CellStyleWithCustomBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithCustomBorders).Text(text => text.Span("").FontSize(7).Bold());
                    table.Cell().Element(CellStyleWithRighttCustomBorders).Text(text => text.Span("").FontSize(9).Bold());

                });

                x.Item().Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.ConstantColumn(25);
                        columns.ConstantColumn(150);
                        columns.ConstantColumn(358);
                    });

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9));
                    table.Cell().Element(HeaderSpecialStyle2).Text(text => text.Span("").FontSize(9));
                    table.Cell().Element(HeaderSpecialStyle).Text(text => text.Span("FOR FACTORY/STORES SECURITY ENDORSEMENT").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Container().Height(20).Text(text => text.Span("").FontSize(7).Bold());
                    table.Cell().Element(CellStyleWithBorderLeft).Container().Height(20).PaddingTop(10).Text(text => text.Span("IN DATE & TIME :-").FontSize(7).Bold());
                    table.Cell().Element(CellStyleWithBorderRight).Container().Height(20).Text(text => text.Span("").FontSize(7).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Container().Height(20).Text(text => text.Span("").FontSize(7).Bold());
                    table.Cell().Element(CellStyleWithLeftCustomBorders).Container().Height(20).Text(text => text.Span("OUT DATE & TIME :-").FontSize(7).Bold());
                    table.Cell().Element(CellStyleWithRighttCustomBorders).Container().Height(20).Text(text => text.Span("").FontSize(7).Bold());

                });

                x.Item().Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.ConstantColumn(25);
                        columns.ConstantColumn(179);
                        columns.ConstantColumn(150);
                        columns.ConstantColumn(179);
                    });


                    table.Cell().Element(CellStyleWithoutBorders).PaddingTop(5).Text("").AlignRight();
                    table.Cell().Element(CellStyleWithoutBorders).PaddingTop(5).Text(text => text.Span("--------------------------------------------").FontSize(8).ExtraBold());
                    table.Cell().Element(CellStyleWithoutBorders).PaddingTop(5).Text(text => text.Span("").FontSize(8).ExtraBold());
                    table.Cell().Element(CellStyleWithoutBorders).PaddingTop(5).Text(text => text.Span("--------------------------------------------").FontSize(8).ExtraBold());

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("SIGNATURE OF THE WHARF CLERK").FontSize(8).ExtraBold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("NAME OF THE GOODS RECEIVER").FontSize(8).ExtraBold());

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).ExtraBold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("NAME:-").FontSize(8).ExtraBold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).ExtraBold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("DATE:-").FontSize(8).ExtraBold());

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).ExtraBold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("DATE:-").FontSize(8).ExtraBold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).ExtraBold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("TIME:-").FontSize(8).ExtraBold());
                });

                x.Item().AlignCenter().Text("#295, level 2,George R. De silava Mawatha, Colombo 13, Sri Lanka.\r\nTel +94 (11) 4337777, 2575169 Fax +94 (11) 4748888, 2576725 Web www.efl.global").FontColor("#000000").FontSize(9).Bold();
            });

        page.Footer()
            .AlignCenter()
            .Text(x =>
            {
                x.Span("Page ");
                x.CurrentPageNumber();
            });
    });
})
.ShowInPreviewer();

IContainer CellStyleWithBorders(IContainer container)
{
    return container
        .Border(1)
        .BorderColor("#000000")
        .PaddingVertical(3)
        .PaddingHorizontal(5)
        .AlignLeft();
}

IContainer CellStyleWithoutBorders(IContainer container)
{
    return container
      
        .PaddingVertical(3)
        .PaddingHorizontal(5)
        .AlignLeft();
}

IContainer HeaderStyleWithBorderLeft(IContainer container)
{
    return container
        .BorderLeft(1)
        .BorderTop(1)
        .BorderColor("#000000")
        .PaddingVertical(3)
        .PaddingBottom(10)
        .PaddingHorizontal(5)
        .AlignLeft();
}

IContainer HeaderStyleWithBorderRight(IContainer container)
{
    return container
        .BorderRight(1)
        .BorderTop(1)
        .BorderColor("#000000")
        .PaddingVertical(4)
        .PaddingBottom(10)
        .PaddingHorizontal(5)
        .AlignLeft();
}

IContainer HeaderSpecialStyle(IContainer container)
{
    return container
        .BorderBottom(1)
        .BorderTop(1)
        .BorderRight(1)
        .BorderColor("#000000")
        .PaddingVertical(4)
        .PaddingBottom(10)
        .PaddingHorizontal(5)
        .AlignLeft();
}

IContainer HeaderSpecialStyle2(IContainer container)
{
    return container
        .BorderBottom(1)
        .BorderTop(1)
        .BorderLeft(1)
        .BorderColor("#000000")
        .PaddingVertical(4)
        .PaddingBottom(10)
        .PaddingHorizontal(5)
        .AlignLeft();
}

IContainer HeaderStyleWithCustomBorders(IContainer container)
{
    return container
        .BorderTop(1)
        .BorderColor("#000000")
        .PaddingVertical(4)
        .PaddingBottom(10)
        .PaddingHorizontal(5)
        .AlignLeft();
}

IContainer CellStyleWithBorderLeft(IContainer container)
{
    return container
        .BorderLeft(1)
        .BorderColor("#000000")
        .PaddingVertical(4)
        .PaddingHorizontal(5)
        .AlignLeft();
}

IContainer CellStyleWithLeftCustomBorders(IContainer container)
{
    return container
        .BorderLeft(1)
        .BorderBottom(1)
        .BorderColor("#000000")
        .PaddingVertical(3)
        .PaddingHorizontal(5)
        .AlignLeft();
}

IContainer CellStyleWithRighttCustomBorders(IContainer container)
{
    return container
        .BorderRight(1)
        .BorderBottom(1)
        .BorderColor("#000000")
        .PaddingVertical(3)
        .PaddingHorizontal(5)
        .AlignLeft();
}

IContainer CellStyleWithCustomBorders(IContainer container)
{
    return container
        .BorderBottom(1)
        .BorderColor("#000000")
        .PaddingVertical(3)
        .PaddingHorizontal(5)
        .AlignLeft();
}

IContainer CellStyleWithBorderRight(IContainer container)
{
    return container
        .BorderRight(1)
        .BorderColor("#000000")
        .PaddingVertical(3)
        .PaddingHorizontal(5)
        .AlignLeft();
}

IContainer PageBorder(IContainer container)
{
    return container
        //.Border(1)
        //.BorderColor("#000000")
        .Padding(2);
}
