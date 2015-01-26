using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for cSysPais
/// </summary>
[DataContract]

public class cSysPais
{
	public cSysPais()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    [DataMember(IsRequired = true)]
    public int PaisID
    { get; set; }

    [DataMember(IsRequired = true)]
    public string Descripcion
    { get; set; }

    [DataMember(IsRequired = true)]
    public bool Activo
    { get; set; }

}