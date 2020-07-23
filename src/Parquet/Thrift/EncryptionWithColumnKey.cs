#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Autogenerated by Thrift Compiler (0.13.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;


namespace Parquet.Thrift
{

   public partial class EncryptionWithColumnKey : TBase
  {
    private byte[] _key_metadata;

    /// <summary>
    /// Column path in schema *
    /// </summary>
    public List<string> Path_in_schema { get; set; }

    /// <summary>
    /// Retrieval metadata of column encryption key *
    /// </summary>
    public byte[] Key_metadata
    {
      get
      {
        return _key_metadata;
      }
      set
      {
        __isset.key_metadata = true;
        this._key_metadata = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool key_metadata;
    }

    public EncryptionWithColumnKey()
    {
    }

    public EncryptionWithColumnKey(List<string> path_in_schema) : this()
    {
      this.Path_in_schema = path_in_schema;
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_path_in_schema = false;
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.List)
              {
                {
                  TList _list16 = await iprot.ReadListBeginAsync(cancellationToken);
                  Path_in_schema = new List<string>(_list16.Count);
                  for(int _i17 = 0; _i17 < _list16.Count; ++_i17)
                  {
                    string _elem18;
                    _elem18 = await iprot.ReadStringAsync(cancellationToken);
                    Path_in_schema.Add(_elem18);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
                isset_path_in_schema = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                Key_metadata = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
        if (!isset_path_in_schema)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var struc = new TStruct("EncryptionWithColumnKey");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        field.Name = "path_in_schema";
        field.Type = TType.List;
        field.ID = 1;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.String, Path_in_schema.Count), cancellationToken);
          foreach (string _iter19 in Path_in_schema)
          {
            await oprot.WriteStringAsync(_iter19, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
        if (Key_metadata != null && __isset.key_metadata)
        {
          field.Name = "key_metadata";
          field.Type = TType.String;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBinaryAsync(Key_metadata, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      var other = that as EncryptionWithColumnKey;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return TCollections.Equals(Path_in_schema, other.Path_in_schema)
        && ((__isset.key_metadata == other.__isset.key_metadata) && ((!__isset.key_metadata) || (TCollections.Equals(Key_metadata, other.Key_metadata))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        hashcode = (hashcode * 397) + TCollections.GetHashCode(Path_in_schema);
        if(__isset.key_metadata)
          hashcode = (hashcode * 397) + Key_metadata.GetHashCode();
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("EncryptionWithColumnKey(");
      sb.Append(", Path_in_schema: ");
      sb.Append(Path_in_schema);
      if (Key_metadata != null && __isset.key_metadata)
      {
        sb.Append(", Key_metadata: ");
        sb.Append(Key_metadata);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
