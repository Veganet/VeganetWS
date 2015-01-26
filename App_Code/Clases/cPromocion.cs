using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for cPromocion
/// </summary>
/// 
[DataContract]
public class cPromocion
{
	public cPromocion()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    [DataMember(IsRequired = true)]
    public int PromocionID
    {
        get;
        set;
    }

    [DataMember(IsRequired = true)]
    public int SucursalID
    {
        get;
        set;
    }

    [DataMember(IsRequired = true)]
    public string SucursalStr
    {
        get;
        set;
    }

    [DataMember(IsRequired = true)]
    public Byte Imagen
    {
        get;
        set;
    }

    [DataMember(IsRequired = true)]
    public int Descripcion
    {
        get;
        set;
    }

    [DataMember(IsRequired = true)]
    public DateTime FechaVencimiento
    { get; set; }

}