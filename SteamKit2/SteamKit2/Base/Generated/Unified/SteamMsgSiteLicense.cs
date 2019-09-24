//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable disable
#pragma warning disable 1591

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: steammessages_site_license.steamclient.proto
// Note: requires additional types generated from: steammessages_unified_base.steamclient.proto
namespace SteamKit2.Unified.Internal
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSiteManagerClient_IncomingClient_Request")]
  public partial class CSiteManagerClient_IncomingClient_Request : global::ProtoBuf.IExtensible
  {
    public CSiteManagerClient_IncomingClient_Request() {}
    

    private ulong? _site_instanceid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"site_instanceid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public ulong site_instanceid
    {
      get { return _site_instanceid?? default(ulong); }
      set { _site_instanceid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool site_instanceidSpecified
    {
      get { return _site_instanceid != null; }
      set { if (value == (_site_instanceid== null)) _site_instanceid = value ? this.site_instanceid : (ulong?)null; }
    }
    private bool ShouldSerializesite_instanceid() { return site_instanceidSpecified; }
    private void Resetsite_instanceid() { site_instanceidSpecified = false; }
    

    private ulong? _client_steamid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"client_steamid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public ulong client_steamid
    {
      get { return _client_steamid?? default(ulong); }
      set { _client_steamid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool client_steamidSpecified
    {
      get { return _client_steamid != null; }
      set { if (value == (_client_steamid== null)) _client_steamid = value ? this.client_steamid : (ulong?)null; }
    }
    private bool ShouldSerializeclient_steamid() { return client_steamidSpecified; }
    private void Resetclient_steamid() { client_steamidSpecified = false; }
    

    private uint? _client_local_ip;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"client_local_ip", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public uint client_local_ip
    {
      get { return _client_local_ip?? default(uint); }
      set { _client_local_ip = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool client_local_ipSpecified
    {
      get { return _client_local_ip != null; }
      set { if (value == (_client_local_ip== null)) _client_local_ip = value ? this.client_local_ip : (uint?)null; }
    }
    private bool ShouldSerializeclient_local_ip() { return client_local_ipSpecified; }
    private void Resetclient_local_ip() { client_local_ipSpecified = false; }
    

    private byte[] _connection_key;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"connection_key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] connection_key
    {
      get { return _connection_key?? null; }
      set { _connection_key = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool connection_keySpecified
    {
      get { return _connection_key != null; }
      set { if (value == (_connection_key== null)) _connection_key = value ? this.connection_key : (byte[])null; }
    }
    private bool ShouldSerializeconnection_key() { return connection_keySpecified; }
    private void Resetconnection_key() { connection_keySpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSiteManagerClient_IncomingClient_Response")]
  public partial class CSiteManagerClient_IncomingClient_Response : global::ProtoBuf.IExtensible
  {
    public CSiteManagerClient_IncomingClient_Response() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSiteLicense_ClientSeatCheckout_Notification")]
  public partial class CSiteLicense_ClientSeatCheckout_Notification : global::ProtoBuf.IExtensible
  {
    public CSiteLicense_ClientSeatCheckout_Notification() {}
    

    private uint? _appid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint appid
    {
      get { return _appid?? default(uint); }
      set { _appid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool appidSpecified
    {
      get { return _appid != null; }
      set { if (value == (_appid== null)) _appid = value ? this.appid : (uint?)null; }
    }
    private bool ShouldSerializeappid() { return appidSpecified; }
    private void Resetappid() { appidSpecified = false; }
    

    private uint? _eresult;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"eresult", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint eresult
    {
      get { return _eresult?? default(uint); }
      set { _eresult = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool eresultSpecified
    {
      get { return _eresult != null; }
      set { if (value == (_eresult== null)) _eresult = value ? this.eresult : (uint?)null; }
    }
    private bool ShouldSerializeeresult() { return eresultSpecified; }
    private void Reseteresult() { eresultSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSiteLicense_InitiateAssociation_Request")]
  public partial class CSiteLicense_InitiateAssociation_Request : global::ProtoBuf.IExtensible
  {
    public CSiteLicense_InitiateAssociation_Request() {}
    

    private ulong? _site_steamid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"site_steamid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public ulong site_steamid
    {
      get { return _site_steamid?? default(ulong); }
      set { _site_steamid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool site_steamidSpecified
    {
      get { return _site_steamid != null; }
      set { if (value == (_site_steamid== null)) _site_steamid = value ? this.site_steamid : (ulong?)null; }
    }
    private bool ShouldSerializesite_steamid() { return site_steamidSpecified; }
    private void Resetsite_steamid() { site_steamidSpecified = false; }
    

    private ulong? _site_instanceid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"site_instanceid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public ulong site_instanceid
    {
      get { return _site_instanceid?? default(ulong); }
      set { _site_instanceid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool site_instanceidSpecified
    {
      get { return _site_instanceid != null; }
      set { if (value == (_site_instanceid== null)) _site_instanceid = value ? this.site_instanceid : (ulong?)null; }
    }
    private bool ShouldSerializesite_instanceid() { return site_instanceidSpecified; }
    private void Resetsite_instanceid() { site_instanceidSpecified = false; }
    

    private uint? _client_local_ip;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"client_local_ip", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public uint client_local_ip
    {
      get { return _client_local_ip?? default(uint); }
      set { _client_local_ip = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool client_local_ipSpecified
    {
      get { return _client_local_ip != null; }
      set { if (value == (_client_local_ip== null)) _client_local_ip = value ? this.client_local_ip : (uint?)null; }
    }
    private bool ShouldSerializeclient_local_ip() { return client_local_ipSpecified; }
    private void Resetclient_local_ip() { client_local_ipSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSiteLicense_InitiateAssociation_Response")]
  public partial class CSiteLicense_InitiateAssociation_Response : global::ProtoBuf.IExtensible
  {
    public CSiteLicense_InitiateAssociation_Response() {}
    

    private byte[] _connection_key;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"connection_key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] connection_key
    {
      get { return _connection_key?? null; }
      set { _connection_key = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool connection_keySpecified
    {
      get { return _connection_key != null; }
      set { if (value == (_connection_key== null)) _connection_key = value ? this.connection_key : (byte[])null; }
    }
    private bool ShouldSerializeconnection_key() { return connection_keySpecified; }
    private void Resetconnection_key() { connection_keySpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSiteLicense_LCSAuthenticate_Request")]
  public partial class CSiteLicense_LCSAuthenticate_Request : global::ProtoBuf.IExtensible
  {
    public CSiteLicense_LCSAuthenticate_Request() {}
    

    private ulong? _instanceid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"instanceid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public ulong instanceid
    {
      get { return _instanceid?? default(ulong); }
      set { _instanceid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool instanceidSpecified
    {
      get { return _instanceid != null; }
      set { if (value == (_instanceid== null)) _instanceid = value ? this.instanceid : (ulong?)null; }
    }
    private bool ShouldSerializeinstanceid() { return instanceidSpecified; }
    private void Resetinstanceid() { instanceidSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSiteLicense_LCSAuthenticate_Response")]
  public partial class CSiteLicense_LCSAuthenticate_Response : global::ProtoBuf.IExtensible
  {
    public CSiteLicense_LCSAuthenticate_Response() {}
    

    private ulong? _site_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"site_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong site_id
    {
      get { return _site_id?? default(ulong); }
      set { _site_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool site_idSpecified
    {
      get { return _site_id != null; }
      set { if (value == (_site_id== null)) _site_id = value ? this.site_id : (ulong?)null; }
    }
    private bool ShouldSerializesite_id() { return site_idSpecified; }
    private void Resetsite_id() { site_idSpecified = false; }
    

    private string _site_name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"site_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string site_name
    {
      get { return _site_name?? ""; }
      set { _site_name = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool site_nameSpecified
    {
      get { return _site_name != null; }
      set { if (value == (_site_name== null)) _site_name = value ? this.site_name : (string)null; }
    }
    private bool ShouldSerializesite_name() { return site_nameSpecified; }
    private void Resetsite_name() { site_nameSpecified = false; }
    

    private bool? _new_session;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"new_session", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool new_session
    {
      get { return _new_session?? default(bool); }
      set { _new_session = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool new_sessionSpecified
    {
      get { return _new_session != null; }
      set { if (value == (_new_session== null)) _new_session = value ? this.new_session : (bool?)null; }
    }
    private bool ShouldSerializenew_session() { return new_sessionSpecified; }
    private void Resetnew_session() { new_sessionSpecified = false; }
    

    private bool? _no_site_licenses;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"no_site_licenses", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool no_site_licenses
    {
      get { return _no_site_licenses?? default(bool); }
      set { _no_site_licenses = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool no_site_licensesSpecified
    {
      get { return _no_site_licenses != null; }
      set { if (value == (_no_site_licenses== null)) _no_site_licenses = value ? this.no_site_licenses : (bool?)null; }
    }
    private bool ShouldSerializeno_site_licenses() { return no_site_licensesSpecified; }
    private void Resetno_site_licenses() { no_site_licensesSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSiteLicense_LCSAssociateUser_Request")]
  public partial class CSiteLicense_LCSAssociateUser_Request : global::ProtoBuf.IExtensible
  {
    public CSiteLicense_LCSAssociateUser_Request() {}
    

    private ulong? _steamid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"steamid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public ulong steamid
    {
      get { return _steamid?? default(ulong); }
      set { _steamid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool steamidSpecified
    {
      get { return _steamid != null; }
      set { if (value == (_steamid== null)) _steamid = value ? this.steamid : (ulong?)null; }
    }
    private bool ShouldSerializesteamid() { return steamidSpecified; }
    private void Resetsteamid() { steamidSpecified = false; }
    

    private uint? _local_ip;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"local_ip", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public uint local_ip
    {
      get { return _local_ip?? default(uint); }
      set { _local_ip = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool local_ipSpecified
    {
      get { return _local_ip != null; }
      set { if (value == (_local_ip== null)) _local_ip = value ? this.local_ip : (uint?)null; }
    }
    private bool ShouldSerializelocal_ip() { return local_ipSpecified; }
    private void Resetlocal_ip() { local_ipSpecified = false; }
    

    private ulong? _instanceid;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"instanceid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public ulong instanceid
    {
      get { return _instanceid?? default(ulong); }
      set { _instanceid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool instanceidSpecified
    {
      get { return _instanceid != null; }
      set { if (value == (_instanceid== null)) _instanceid = value ? this.instanceid : (ulong?)null; }
    }
    private bool ShouldSerializeinstanceid() { return instanceidSpecified; }
    private void Resetinstanceid() { instanceidSpecified = false; }
    

    private string _machine_name;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"machine_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string machine_name
    {
      get { return _machine_name?? ""; }
      set { _machine_name = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool machine_nameSpecified
    {
      get { return _machine_name != null; }
      set { if (value == (_machine_name== null)) _machine_name = value ? this.machine_name : (string)null; }
    }
    private bool ShouldSerializemachine_name() { return machine_nameSpecified; }
    private void Resetmachine_name() { machine_nameSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSiteLicense_LCSAssociateUser_Response")]
  public partial class CSiteLicense_LCSAssociateUser_Response : global::ProtoBuf.IExtensible
  {
    public CSiteLicense_LCSAssociateUser_Response() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSiteLicense_ClientSeatCheckout_Request")]
  public partial class CSiteLicense_ClientSeatCheckout_Request : global::ProtoBuf.IExtensible
  {
    public CSiteLicense_ClientSeatCheckout_Request() {}
    

    private ulong? _steamid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"steamid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public ulong steamid
    {
      get { return _steamid?? default(ulong); }
      set { _steamid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool steamidSpecified
    {
      get { return _steamid != null; }
      set { if (value == (_steamid== null)) _steamid = value ? this.steamid : (ulong?)null; }
    }
    private bool ShouldSerializesteamid() { return steamidSpecified; }
    private void Resetsteamid() { steamidSpecified = false; }
    

    private ulong? _instanceid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"instanceid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public ulong instanceid
    {
      get { return _instanceid?? default(ulong); }
      set { _instanceid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool instanceidSpecified
    {
      get { return _instanceid != null; }
      set { if (value == (_instanceid== null)) _instanceid = value ? this.instanceid : (ulong?)null; }
    }
    private bool ShouldSerializeinstanceid() { return instanceidSpecified; }
    private void Resetinstanceid() { instanceidSpecified = false; }
    

    private uint? _appid;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint appid
    {
      get { return _appid?? default(uint); }
      set { _appid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool appidSpecified
    {
      get { return _appid != null; }
      set { if (value == (_appid== null)) _appid = value ? this.appid : (uint?)null; }
    }
    private bool ShouldSerializeappid() { return appidSpecified; }
    private void Resetappid() { appidSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSiteLicense_ClientSeatCheckout_Response")]
  public partial class CSiteLicense_ClientSeatCheckout_Response : global::ProtoBuf.IExtensible
  {
    public CSiteLicense_ClientSeatCheckout_Response() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSiteLicense_ClientGetAvailableSeats_Request")]
  public partial class CSiteLicense_ClientGetAvailableSeats_Request : global::ProtoBuf.IExtensible
  {
    public CSiteLicense_ClientGetAvailableSeats_Request() {}
    

    private ulong? _steamid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"steamid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public ulong steamid
    {
      get { return _steamid?? default(ulong); }
      set { _steamid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool steamidSpecified
    {
      get { return _steamid != null; }
      set { if (value == (_steamid== null)) _steamid = value ? this.steamid : (ulong?)null; }
    }
    private bool ShouldSerializesteamid() { return steamidSpecified; }
    private void Resetsteamid() { steamidSpecified = false; }
    

    private ulong? _instanceid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"instanceid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public ulong instanceid
    {
      get { return _instanceid?? default(ulong); }
      set { _instanceid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool instanceidSpecified
    {
      get { return _instanceid != null; }
      set { if (value == (_instanceid== null)) _instanceid = value ? this.instanceid : (ulong?)null; }
    }
    private bool ShouldSerializeinstanceid() { return instanceidSpecified; }
    private void Resetinstanceid() { instanceidSpecified = false; }
    

    private uint? _appid;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint appid
    {
      get { return _appid?? default(uint); }
      set { _appid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool appidSpecified
    {
      get { return _appid != null; }
      set { if (value == (_appid== null)) _appid = value ? this.appid : (uint?)null; }
    }
    private bool ShouldSerializeappid() { return appidSpecified; }
    private void Resetappid() { appidSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSiteLicense_ClientGetAvailableSeats_Response")]
  public partial class CSiteLicense_ClientGetAvailableSeats_Response : global::ProtoBuf.IExtensible
  {
    public CSiteLicense_ClientGetAvailableSeats_Response() {}
    

    private uint? _available_seats;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"available_seats", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint available_seats
    {
      get { return _available_seats?? default(uint); }
      set { _available_seats = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool available_seatsSpecified
    {
      get { return _available_seats != null; }
      set { if (value == (_available_seats== null)) _available_seats = value ? this.available_seats : (uint?)null; }
    }
    private bool ShouldSerializeavailable_seats() { return available_seatsSpecified; }
    private void Resetavailable_seats() { available_seatsSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    public interface ISiteManagerClient
    {
      CSiteManagerClient_IncomingClient_Response IncomingClient(CSiteManagerClient_IncomingClient_Request request);
    NoResponse ClientSeatCheckoutNotification(CSiteLicense_ClientSeatCheckout_Notification request);
    
    }
    
    
    public interface ISiteLicense
    {
      CSiteLicense_InitiateAssociation_Response InitiateAssociation(CSiteLicense_InitiateAssociation_Request request);
    CSiteLicense_LCSAuthenticate_Response LCSAuthenticate(CSiteLicense_LCSAuthenticate_Request request);
    CSiteLicense_LCSAssociateUser_Response LCSAssociateUser(CSiteLicense_LCSAssociateUser_Request request);
    CSiteLicense_ClientSeatCheckout_Response ClientSeatCheckout(CSiteLicense_ClientSeatCheckout_Request request);
    CSiteLicense_ClientGetAvailableSeats_Response ClientGetAvailableSeats(CSiteLicense_ClientGetAvailableSeats_Request request);
    
    }
    
    
}
#pragma warning restore 1591
