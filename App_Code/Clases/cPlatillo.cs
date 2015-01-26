using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de cPlatillo
/// </summary>
[DataContract]
public class cPlatillo
{
	public cPlatillo()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}

    [DataMember(IsRequired=true)]
    public int PlatilloID { get; set; }

    [DataMember(IsRequired=true)]
    public string Nombre { get; set; }

    [DataMember(IsRequired=true)]
    public string Descripcion { get; set; }

    [DataMember(IsRequired=true)]
    public byte Imagen { get; set; }

    [DataMember(IsRequired=true)]
    public decimal Costo { get; set; }

    [DataMember(IsRequired=true)]
    public int SucursalID { get; set; }

    [DataMember(IsRequired=true)]
    public string SucursalStr { get; set; }

    [DataMember(IsRequired=true)]
    public int TipoPlatilloID { get; set; }

    [DataMember(IsRequired=true)]
    public string TipoPlatilloStr { get; set; }







}