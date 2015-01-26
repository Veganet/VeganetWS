using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de cProductoTipoAlimentacion
/// </summary>
[DataContract]
public class cProductoTipoAlimentacion
{
	public cProductoTipoAlimentacion()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}

    [DataMember(IsRequired=true)]
    public int ProductoTipoAlimentacionID {get;set;}
    [DataMember(IsRequired=true)]
    public int ProductoID {get; set; }
    [DataMember(IsRequired=true)]
    public string ProductoStr {get; set; }
    [DataMember(IsRequired=true)]
    public int TipoAlimentacionID {get; set; }
    [DataMember(IsRequired=true)]
    public string TipoAlimentacionStr {get; set; }
    
}