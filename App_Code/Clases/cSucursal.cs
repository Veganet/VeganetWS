using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for cSucursal
/// </summary>
/// 
[DataContract]
public class cSucursal
{
    
	public cSucursal()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    [DataMember(IsRequired=true)]
    public int SucursalID
    {
        get;
        set;
    }

    [DataMember(IsRequired = true)]
    public string Nombre
    {
        get;
        set;
    }

    [DataMember(IsRequired = true)]
    public string Descripcion
    {
        get;
        set;
    }

    [DataMember(IsRequired = true)]
    public int TipoEstablecimientoID
    {
        get;
        set;
    }

    [DataMember(IsRequired = true)]
    public int TipoEstablecimientoStr
    {
        get;
        set;
    }

    [DataMember(IsRequired = true)]
    public bool Activo
    {
        get;
        set;
    }

    [DataMember(IsRequired = true)]
    public DateTime FechaCreacion
    {
        get;
        set;
    }

    [DataMember(IsRequired = true)]
    public int TipoGiroID
    {
        get;
        set;
    }

    [DataMember(IsRequired = true)]
    public string TipoGiroStr
    {
        get;
        set;
    }

    [DataMember(IsRequired = true)]
    public int EstablecimientoID
    {
        get;
        set;
    }

    [DataMember(IsRequired = true)]
    public string EstablecimientoStr
    {
        get;
        set;
    }

    [DataMember(IsRequired = true)]
    public int CiudadID
    {
        get;
        set;
    }

    [DataMember(IsRequired = true)]
    public string CiudadStr
    {
        get;
        set;
    }

    [DataMember(IsRequired = true)]
    public int Latitud
    {
        get;
        set;
    }

    [DataMember(IsRequired = true)]
    public int Longitud
    {
        get;
        set;
    }

    [DataMember(IsRequired = true)]
    public string Direccion
    {
        get;
        set;
    }


}