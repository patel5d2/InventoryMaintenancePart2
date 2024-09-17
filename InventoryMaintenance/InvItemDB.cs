// Dharmin Patel
using System;
using System.Collections.Generic;
using System.Xml;

public static class InvItemDB
{
    private const string Path = @"..\..\..\InventoryItems.xml";

    public static List<InvItem> GetItems()
    {
        List<InvItem> items = new List<InvItem>();

        XmlReaderSettings settings = new XmlReaderSettings
        {
            IgnoreWhitespace = true,
            IgnoreComments = true
        };

        XmlReader xmlIn = XmlReader.Create(Path, settings);

        if (xmlIn.ReadToDescendant("Item"))
        {
            do
            {
                InvItem item;
                xmlIn.ReadStartElement("Item");
                string type = xmlIn.ReadElementContentAsString();
                if (type == "Plant")
                {
                    Plant p = new Plant();
                    ReadBase(xmlIn, p);
                    p.Size = xmlIn.ReadElementContentAsString();
                    item = p;
                }
                else
                {
                    Supply s = new Supply();
                    ReadBase(xmlIn, s);
                    s.Manufacturer = xmlIn.ReadElementContentAsString();
                    item = s;
                }
                items.Add(item);
            }
            while (xmlIn.ReadToNextSibling("Item"));
        }

        xmlIn.Close();
        return items;
    }

    private static void ReadBase(XmlReader xmlIn, InvItem i)
    {
        i.ItemNo = xmlIn.ReadElementContentAsInt();
        i.Description = xmlIn.ReadElementContentAsString();
        i.Price = xmlIn.ReadElementContentAsDecimal();
    }

    public static void SaveItems(List<InvItem> items)
    {
        XmlWriterSettings settings = new XmlWriterSettings
        {
            Indent = true,
            IndentChars = "    "
        };

        XmlWriter xmlOut = XmlWriter.Create(Path, settings);

        xmlOut.WriteStartDocument();
        xmlOut.WriteStartElement("Items");

        foreach (InvItem item in items)
        {
            xmlOut.WriteStartElement("Item");
            if (item is Plant p)
            {
                xmlOut.WriteElementString("Type", "Plant");
                WriteBase(p, xmlOut);
                xmlOut.WriteElementString("Size", p.Size);
            }
            else if (item is Supply s)
            {
                xmlOut.WriteElementString("Type", "Supply");
                WriteBase(s, xmlOut);
                xmlOut.WriteElementString("Manufacturer", s.Manufacturer);
            }
            xmlOut.WriteEndElement();
        }

        xmlOut.WriteEndElement();
        xmlOut.Close();
    }

    private static void WriteBase(InvItem item, XmlWriter xmlOut)
    {
        xmlOut.WriteElementString("ItemNo", item.ItemNo.ToString());
        xmlOut.WriteElementString("Description", item.Description);
        xmlOut.WriteElementString("Price", item.Price.ToString());
    }
}
