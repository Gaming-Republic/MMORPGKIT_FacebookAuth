// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: facebook_auth_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from facebook_auth_service.proto</summary>
public static partial class FacebookAuthServiceReflection {

  #region Descriptor
  /// <summary>File descriptor for facebook_auth_service.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static FacebookAuthServiceReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChtmYWNlYm9va19hdXRoX3NlcnZpY2UucHJvdG8iLQoQRmFjZWJvb2tMb2dp",
          "blJlcRIKCgJpZBgBIAEoCRINCgVlbWFpbBgCIAEoCSIkChFGYWNlYm9va0xv",
          "Z2luUmVzcBIPCgd1c2VyX2lkGAEgASgJMk0KE0ZhY2Vib29rQXV0aFNlcnZp",
          "Y2USNgoNRmFjZWJvb2tMb2dpbhIRLkZhY2Vib29rTG9naW5SZXEaEi5GYWNl",
          "Ym9va0xvZ2luUmVzcGIGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::FacebookLoginReq), global::FacebookLoginReq.Parser, new[]{ "Id", "Email" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::FacebookLoginResp), global::FacebookLoginResp.Parser, new[]{ "UserId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class FacebookLoginReq : pb::IMessage<FacebookLoginReq> {
  private static readonly pb::MessageParser<FacebookLoginReq> _parser = new pb::MessageParser<FacebookLoginReq>(() => new FacebookLoginReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<FacebookLoginReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::FacebookAuthServiceReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public FacebookLoginReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public FacebookLoginReq(FacebookLoginReq other) : this() {
    id_ = other.id_;
    email_ = other.email_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public FacebookLoginReq Clone() {
    return new FacebookLoginReq(this);
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 1;
  private string id_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Id {
    get { return id_; }
    set {
      id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "email" field.</summary>
  public const int EmailFieldNumber = 2;
  private string email_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Email {
    get { return email_; }
    set {
      email_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as FacebookLoginReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(FacebookLoginReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Id != other.Id) return false;
    if (Email != other.Email) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Id.Length != 0) hash ^= Id.GetHashCode();
    if (Email.Length != 0) hash ^= Email.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Id.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Id);
    }
    if (Email.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Email);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Id.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
    }
    if (Email.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Email);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(FacebookLoginReq other) {
    if (other == null) {
      return;
    }
    if (other.Id.Length != 0) {
      Id = other.Id;
    }
    if (other.Email.Length != 0) {
      Email = other.Email;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Id = input.ReadString();
          break;
        }
        case 18: {
          Email = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class FacebookLoginResp : pb::IMessage<FacebookLoginResp> {
  private static readonly pb::MessageParser<FacebookLoginResp> _parser = new pb::MessageParser<FacebookLoginResp>(() => new FacebookLoginResp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<FacebookLoginResp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::FacebookAuthServiceReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public FacebookLoginResp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public FacebookLoginResp(FacebookLoginResp other) : this() {
    userId_ = other.userId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public FacebookLoginResp Clone() {
    return new FacebookLoginResp(this);
  }

  /// <summary>Field number for the "user_id" field.</summary>
  public const int UserIdFieldNumber = 1;
  private string userId_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string UserId {
    get { return userId_; }
    set {
      userId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as FacebookLoginResp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(FacebookLoginResp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (UserId != other.UserId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (UserId.Length != 0) hash ^= UserId.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (UserId.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(UserId);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (UserId.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(UserId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(FacebookLoginResp other) {
    if (other == null) {
      return;
    }
    if (other.UserId.Length != 0) {
      UserId = other.UserId;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          UserId = input.ReadString();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
