﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignPatterns2.Capitulo08;

public class GeradorDeXml
{
    public string GeraXml(object obj)
    {
        XmlSerializer serializer = new XmlSerializer(obj.GetType());
        StringWriter writer = new StringWriter();
        serializer.Serialize(writer, obj);
        return writer.ToString();
    }
}
