// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CommandBuffer.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Redhatgamedev.Srt {

  /// <summary>Holder for reflection information generated from CommandBuffer.proto</summary>
  public static partial class CommandBufferReflection {

    #region Descriptor
    /// <summary>File descriptor for CommandBuffer.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommandBufferReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNDb21tYW5kQnVmZmVyLnByb3RvEhFyZWRoYXRnYW1lZGV2LnNydBobU2Vj",
            "dXJpdHlDb21tYW5kQnVmZmVyLnByb3RvGhtSYXdJbnB1dENvbW1hbmRCdWZm",
            "ZXIucHJvdG8ioQIKDUNvbW1hbmRCdWZmZXISQAoEdHlwZRgBIAIoDjIyLnJl",
            "ZGhhdGdhbWVkZXYuc3J0LkNvbW1hbmRCdWZmZXIuQ29tbWFuZEJ1ZmZlclR5",
            "cGUSRwoVc2VjdXJpdHlDb21tYW5kQnVmZmVyGAIgASgLMigucmVkaGF0Z2Ft",
            "ZWRldi5zcnQuU2VjdXJpdHlDb21tYW5kQnVmZmVyEkcKFXJhd0lucHV0Q29t",
            "bWFuZEJ1ZmZlchgDIAEoCzIoLnJlZGhhdGdhbWVkZXYuc3J0LlJhd0lucHV0",
            "Q29tbWFuZEJ1ZmZlciI8ChFDb21tYW5kQnVmZmVyVHlwZRILCgdVTktOT1dO",
            "EAASDAoIU0VDVVJJVFkQARIMCghSQVdJTlBVVBAC"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Redhatgamedev.Srt.SecurityCommandBufferReflection.Descriptor, global::Redhatgamedev.Srt.RawInputCommandBufferReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Redhatgamedev.Srt.CommandBuffer), global::Redhatgamedev.Srt.CommandBuffer.Parser, new[]{ "Type", "SecurityCommandBuffer", "RawInputCommandBuffer" }, null, new[]{ typeof(global::Redhatgamedev.Srt.CommandBuffer.Types.CommandBufferType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CommandBuffer : pb::IMessage<CommandBuffer>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CommandBuffer> _parser = new pb::MessageParser<CommandBuffer>(() => new CommandBuffer());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CommandBuffer> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Redhatgamedev.Srt.CommandBufferReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CommandBuffer() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CommandBuffer(CommandBuffer other) : this() {
      _hasBits0 = other._hasBits0;
      type_ = other.type_;
      securityCommandBuffer_ = other.securityCommandBuffer_ != null ? other.securityCommandBuffer_.Clone() : null;
      rawInputCommandBuffer_ = other.rawInputCommandBuffer_ != null ? other.rawInputCommandBuffer_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CommandBuffer Clone() {
      return new CommandBuffer(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private readonly static global::Redhatgamedev.Srt.CommandBuffer.Types.CommandBufferType TypeDefaultValue = global::Redhatgamedev.Srt.CommandBuffer.Types.CommandBufferType.Unknown;

    private global::Redhatgamedev.Srt.CommandBuffer.Types.CommandBufferType type_;
    /// <summary>
    /// [default = UNKNOWN];
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Redhatgamedev.Srt.CommandBuffer.Types.CommandBufferType Type {
      get { if ((_hasBits0 & 1) != 0) { return type_; } else { return TypeDefaultValue; } }
      set {
        _hasBits0 |= 1;
        type_ = value;
      }
    }
    /// <summary>Gets whether the "type" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasType {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "type" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearType() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "securityCommandBuffer" field.</summary>
    public const int SecurityCommandBufferFieldNumber = 2;
    private global::Redhatgamedev.Srt.SecurityCommandBuffer securityCommandBuffer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Redhatgamedev.Srt.SecurityCommandBuffer SecurityCommandBuffer {
      get { return securityCommandBuffer_; }
      set {
        securityCommandBuffer_ = value;
      }
    }

    /// <summary>Field number for the "rawInputCommandBuffer" field.</summary>
    public const int RawInputCommandBufferFieldNumber = 3;
    private global::Redhatgamedev.Srt.RawInputCommandBuffer rawInputCommandBuffer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Redhatgamedev.Srt.RawInputCommandBuffer RawInputCommandBuffer {
      get { return rawInputCommandBuffer_; }
      set {
        rawInputCommandBuffer_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CommandBuffer);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CommandBuffer other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (!object.Equals(SecurityCommandBuffer, other.SecurityCommandBuffer)) return false;
      if (!object.Equals(RawInputCommandBuffer, other.RawInputCommandBuffer)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasType) hash ^= Type.GetHashCode();
      if (securityCommandBuffer_ != null) hash ^= SecurityCommandBuffer.GetHashCode();
      if (rawInputCommandBuffer_ != null) hash ^= RawInputCommandBuffer.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (HasType) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (securityCommandBuffer_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(SecurityCommandBuffer);
      }
      if (rawInputCommandBuffer_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RawInputCommandBuffer);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasType) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (securityCommandBuffer_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(SecurityCommandBuffer);
      }
      if (rawInputCommandBuffer_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RawInputCommandBuffer);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasType) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (securityCommandBuffer_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SecurityCommandBuffer);
      }
      if (rawInputCommandBuffer_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RawInputCommandBuffer);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CommandBuffer other) {
      if (other == null) {
        return;
      }
      if (other.HasType) {
        Type = other.Type;
      }
      if (other.securityCommandBuffer_ != null) {
        if (securityCommandBuffer_ == null) {
          SecurityCommandBuffer = new global::Redhatgamedev.Srt.SecurityCommandBuffer();
        }
        SecurityCommandBuffer.MergeFrom(other.SecurityCommandBuffer);
      }
      if (other.rawInputCommandBuffer_ != null) {
        if (rawInputCommandBuffer_ == null) {
          RawInputCommandBuffer = new global::Redhatgamedev.Srt.RawInputCommandBuffer();
        }
        RawInputCommandBuffer.MergeFrom(other.RawInputCommandBuffer);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Type = (global::Redhatgamedev.Srt.CommandBuffer.Types.CommandBufferType) input.ReadEnum();
            break;
          }
          case 18: {
            if (securityCommandBuffer_ == null) {
              SecurityCommandBuffer = new global::Redhatgamedev.Srt.SecurityCommandBuffer();
            }
            input.ReadMessage(SecurityCommandBuffer);
            break;
          }
          case 26: {
            if (rawInputCommandBuffer_ == null) {
              RawInputCommandBuffer = new global::Redhatgamedev.Srt.RawInputCommandBuffer();
            }
            input.ReadMessage(RawInputCommandBuffer);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Type = (global::Redhatgamedev.Srt.CommandBuffer.Types.CommandBufferType) input.ReadEnum();
            break;
          }
          case 18: {
            if (securityCommandBuffer_ == null) {
              SecurityCommandBuffer = new global::Redhatgamedev.Srt.SecurityCommandBuffer();
            }
            input.ReadMessage(SecurityCommandBuffer);
            break;
          }
          case 26: {
            if (rawInputCommandBuffer_ == null) {
              RawInputCommandBuffer = new global::Redhatgamedev.Srt.RawInputCommandBuffer();
            }
            input.ReadMessage(RawInputCommandBuffer);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the CommandBuffer message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CommandBufferType {
        [pbr::OriginalName("UNKNOWN")] Unknown = 0,
        [pbr::OriginalName("SECURITY")] Security = 1,
        [pbr::OriginalName("RAWINPUT")] Rawinput = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code