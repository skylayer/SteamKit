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
    
// Generated from: steammessages_offline.steamclient.proto
// Note: requires additional types generated from: steammessages_unified_base.steamclient.proto
namespace SteamKit2.Unified.Internal
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"COffline_GetOfflineLogonTicket_Request")]
  public partial class COffline_GetOfflineLogonTicket_Request : global::ProtoBuf.IExtensible
  {
    public COffline_GetOfflineLogonTicket_Request() {}
    

    private uint? _priority;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"priority", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint priority
    {
      get { return _priority?? default(uint); }
      set { _priority = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool prioritySpecified
    {
      get { return _priority != null; }
      set { if (value == (_priority== null)) _priority = value ? this.priority : (uint?)null; }
    }
    private bool ShouldSerializepriority() { return prioritySpecified; }
    private void Resetpriority() { prioritySpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"COffline_GetOfflineLogonTicket_Response")]
  public partial class COffline_GetOfflineLogonTicket_Response : global::ProtoBuf.IExtensible
  {
    public COffline_GetOfflineLogonTicket_Response() {}
    

    private byte[] _serialized_ticket;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"serialized_ticket", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] serialized_ticket
    {
      get { return _serialized_ticket?? null; }
      set { _serialized_ticket = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool serialized_ticketSpecified
    {
      get { return _serialized_ticket != null; }
      set { if (value == (_serialized_ticket== null)) _serialized_ticket = value ? this.serialized_ticket : (byte[])null; }
    }
    private bool ShouldSerializeserialized_ticket() { return serialized_ticketSpecified; }
    private void Resetserialized_ticket() { serialized_ticketSpecified = false; }
    

    private byte[] _signature;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"signature", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] signature
    {
      get { return _signature?? null; }
      set { _signature = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool signatureSpecified
    {
      get { return _signature != null; }
      set { if (value == (_signature== null)) _signature = value ? this.signature : (byte[])null; }
    }
    private bool ShouldSerializesignature() { return signatureSpecified; }
    private void Resetsignature() { signatureSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"COffline_GetUnsignedOfflineLogonTicket_Request")]
  public partial class COffline_GetUnsignedOfflineLogonTicket_Request : global::ProtoBuf.IExtensible
  {
    public COffline_GetUnsignedOfflineLogonTicket_Request() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"COffline_OfflineLogonTicket")]
  public partial class COffline_OfflineLogonTicket : global::ProtoBuf.IExtensible
  {
    public COffline_OfflineLogonTicket() {}
    

    private uint? _accountid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"accountid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint accountid
    {
      get { return _accountid?? default(uint); }
      set { _accountid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool accountidSpecified
    {
      get { return _accountid != null; }
      set { if (value == (_accountid== null)) _accountid = value ? this.accountid : (uint?)null; }
    }
    private bool ShouldSerializeaccountid() { return accountidSpecified; }
    private void Resetaccountid() { accountidSpecified = false; }
    

    private uint? _rtime32_creation_time;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"rtime32_creation_time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public uint rtime32_creation_time
    {
      get { return _rtime32_creation_time?? default(uint); }
      set { _rtime32_creation_time = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool rtime32_creation_timeSpecified
    {
      get { return _rtime32_creation_time != null; }
      set { if (value == (_rtime32_creation_time== null)) _rtime32_creation_time = value ? this.rtime32_creation_time : (uint?)null; }
    }
    private bool ShouldSerializertime32_creation_time() { return rtime32_creation_timeSpecified; }
    private void Resetrtime32_creation_time() { rtime32_creation_timeSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"COffline_GetUnsignedOfflineLogonTicket_Response")]
  public partial class COffline_GetUnsignedOfflineLogonTicket_Response : global::ProtoBuf.IExtensible
  {
    public COffline_GetUnsignedOfflineLogonTicket_Response() {}
    

    private COffline_OfflineLogonTicket _ticket = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ticket", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public COffline_OfflineLogonTicket ticket
    {
      get { return _ticket; }
      set { _ticket = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    public interface IOffline
    {
      COffline_GetOfflineLogonTicket_Response GetOfflineLogonTicket(COffline_GetOfflineLogonTicket_Request request);
    COffline_GetUnsignedOfflineLogonTicket_Response GetUnsignedOfflineLogonTicket(COffline_GetUnsignedOfflineLogonTicket_Request request);
    
    }
    
    
}
#pragma warning restore 1591
