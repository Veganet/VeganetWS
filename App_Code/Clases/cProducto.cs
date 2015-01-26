using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for Producto
/// </summary>
[DataContract]
public class cProducto
{
	public cProducto()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    [DataMember(IsRequired = true)]
    public int ProductoID
    { get; set; }

    [DataMember(IsRequired = true)]
    public string Nombre
    { get; set; }

    [DataMember(IsRequired = true)]
    public byte Imagen
    { get; set; }

    [DataMember(IsRequired = true)]
    public int SucursalID
    { get; set; }

    [DataMember(IsRequired = true)]
    public string SucursalStr
    { get; set; }


}