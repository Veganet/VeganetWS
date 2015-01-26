using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de cPomocionTipoAlimentacion
/// </summary>
[DataContract]
public class cPomocionTipoAlimentacion
{
	public cPomocionTipoAlimentacion()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}

    
    [DataMember(IsRequired=true)]
    public int PromocionTipoAlimentacionID {get;set;}

    
    [DataMember(IsRequired=true)]
    public int PromocionID {get;set;}

    
    [DataMember(IsRequired=true)]
    public string PromocionStr {get;set;}
    
    [DataMember(IsRequired=true)]
    public int TipoAlimentacionID {get;set;}

    
    [DataMember(IsRequired=true)]
    public string TipoAlimentacionStr{get;set;}
}