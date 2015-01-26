using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for cSysTipoCatalogo
/// </summary>
[DataContract]

public class cSysTipoCatalogo
{
	public cSysTipoCatalogo()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    [DataMember(IsRequired = true)]
    public int TipoCatalogoID
    { get; set; }

    [DataMember(IsRequired = true)]
    public string Concepto
    { get; set; }

    [DataMember(IsRequired = true)]
    public string Descripcion
    { get; set; }

    [DataMember(IsRequired = true)]
    public string Observacion
    { get; set; }

    [DataMember(IsRequired = true)]
    public bool Activo
    { get; set; }

    [DataMember(IsRequired = true)]
    public bool Protegido
    { get; set; }
}